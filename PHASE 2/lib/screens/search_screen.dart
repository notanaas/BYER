import 'dart:convert';
import 'package:byer/models/location_model_resp.dart';
import 'package:dio/dio.dart';
import 'package:flutter/material.dart';

class SearchScreen extends StatefulWidget {
  const SearchScreen({super.key});

  @override
  State<SearchScreen> createState() => _SearchScreenState();
}

class _SearchScreenState extends State<SearchScreen> {
  final TextEditingController _controller = TextEditingController();
  Future<Response<String>>? _resp;
  final Dio dio = Dio();

  Uri _getApiURI(String location) => Uri(
        scheme: 'https',
        host: 'nominatim.openstreetmap.org',
        path: 'search.php',
        queryParameters: {
          "q": location,
          "format": "jsonv2",
        },
      );

  void onSearch(String search) {
    if (search.length < 3 || search.length > 30) return;
    setState(() {
      _resp = dio.getUri(_getApiURI(search));
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
          icon: const Icon(Icons.chevron_left),
          onPressed: () => Navigator.of(context).maybePop(null),
        ),
        title: TextField(
          controller: _controller,
          keyboardType: TextInputType.text,
          cursorColor: Theme.of(context).primaryColor,
          onChanged: onSearch,
          decoration: const InputDecoration(
            hintText: 'Search location',
            border: InputBorder.none,
          ),
          style: const TextStyle(
            fontSize: 18,
            color: Colors.white,
          ),
        ),
        backgroundColor: Theme.of(context).colorScheme.primary,
        elevation: 0,
      ),
      body: SafeArea(
        child: FutureBuilder(
          future: _resp,
          builder: (ctx, snapshot) {
            if (snapshot.connectionState == ConnectionState.waiting) {
              return const Center(child: CircularProgressIndicator());
            }

            if (snapshot.hasError || snapshot.data?.data == null) {
              return const Center(child: Text('No results found'));
            }

            List<dynamic> data = jsonDecode(snapshot.data!.data!);

            return ListView.builder(
              itemCount: data.length,
              itemBuilder: (ctx, index) {
                var location = LocationModelResp.fromMap(data[index]);
                return _Location(
                  location: location,
                  onPress: (selectedLocation) {
                    Navigator.of(context).maybePop(selectedLocation);
                  },
                );
              },
            );
          },
        ),
      ),
    );
  }
}

class _Location extends StatelessWidget {
  const _Location({required this.location, this.onPress});

  final LocationModelResp location;
  final Function(LocationModelResp)? onPress;

  @override
  Widget build(BuildContext context) {
    return ListTile(
      title: Text(
        location.address,
        style: TextStyle(color: Theme.of(context).primaryColor),
      ),
      onTap: () => onPress?.call(location),
    );
  }
}
