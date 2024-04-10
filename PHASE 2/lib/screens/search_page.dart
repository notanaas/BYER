import 'package:byer/models/location_model_resp.dart';
import 'package:byer/screens/book_room_screen.dart';
import 'package:byer/service/room_service.dart';
import 'package:flutter/material.dart';

import 'history_page.dart';

class SearchPage extends StatefulWidget {
  const SearchPage({super.key});

  @override
  State<StatefulWidget> createState() => _SearchPageState();
}

class _SearchPageState extends State<SearchPage> {
  LocationModelResp? selectedModel;
  Future<List<Room>>? fRoom;
  final TextEditingController _searchController = TextEditingController();
  bool isFilterActive = false;

  @override
  void initState() {
    super.initState();
    _searchController.addListener(_onSearchChanged);
    _onSearchChanged();
  }

  @override
  void dispose() {
    _searchController.removeListener(_onSearchChanged);
    _searchController.dispose();
    super.dispose();
  }

  void _onSearchChanged() {
    final searchText = _searchController.text.trim();
    setState(() {
        isFilterActive = selectedModel != null;
        fRoom = RoomService.list(
          searchText.trim().isEmpty ? null : searchText.trim(),
          null,
          null,
          selectedModel != null ? selectedModel!.longitude : 0,
          selectedModel != null ? selectedModel!.latitude : 0,
        );
    });
  }

  void toggleFilterIcon() {
    setState(() {
      isFilterActive = !isFilterActive;
      if (!isFilterActive) {
        selectedModel = null;
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 10),
          child: Row(
            children: [
              Expanded(
                child: Container(
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(6),
                      border: Border.all(
                        color: const Color(0xFF404040),
                        width: 1,
                      ),
                      color: const Color(0xFF0D0D0D)),
                  child: TextField(
                    controller: _searchController,
                    keyboardType: TextInputType.text,
                    cursorColor: const Color(0xFFB1B1B1),
                    decoration: const InputDecoration(
                      prefixIcon:
                          Icon(Icons.search, color: Color(0xffB1B1B1)),
                      hintText: "Search by name",
                      border: InputBorder.none,
                      contentPadding: EdgeInsets.symmetric(vertical: 15),
                      hintStyle: TextStyle(
                        color: Color(0xffB1B1B1),
                        fontFamily: 'Inter',
                        fontSize: 18,
                        fontWeight: FontWeight.w400,
                      ),
                    ),
                    style: const TextStyle(
                      color: Color(0xffB1B1B1),
                      fontFamily: 'Inter',
                      fontSize: 18,
                      fontWeight: FontWeight.w400,
                    ),
                  ),
                ),
              ),
              isFilterActive
                  ? IconButton(
                      onPressed: toggleFilterIcon,
                      icon: const Icon(
                        Icons.clear,
                        size: 29,
                        color: Colors.grey,
                      ),
                    )
                  : IconButton(
                      onPressed: () async {
                        final data = await Navigator.of(context).pushNamed("/search");
                        setState(() {
                          selectedModel = data as LocationModelResp?;
                          isFilterActive = selectedModel != null;
                        });
                      },
                      icon: const Icon(
                        Icons.filter_alt_sharp,
                        size: 29,
                        color: Colors.grey,
                      ),
                    ),
            ],
          ),
        ),
        Expanded(
          child: FutureBuilder<List<Room>>(
            future: fRoom,
            builder: (ctx, snapshot) {
              if (snapshot.connectionState == ConnectionState.waiting) {
                return const Center(
                  child: SizedBox(
                    height: 30,
                    width: 30,
                    child: CircularProgressIndicator(),
                  ),
                );
              }

              if (snapshot.hasError || !snapshot.hasData) {
                return const Center(
                  child: Text(
                    'No results found',
                    style: TextStyle(
                      color: Colors.grey,
                      fontFamily: 'Inter',
                      fontSize: 24,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                );
              }

              List<Room> rooms = snapshot.data!;
              return ListView.builder(
                itemCount: rooms.length,
                itemBuilder: (ctx, index) {
                  Room room = rooms[index];
                  return ListingCard(
                      room: room,
                      onClick: () {
                        final page = BookRoomScreen(roomId: room.id);
                        Navigator.of(context).push(
                          MaterialPageRoute(builder: (context) => page),
                        );
                      });
                },
              );
            },
          ),
        ),
      ],
    );
  }
}
