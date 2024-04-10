import 'dart:math';
import 'package:byer/service/booking_service.dart';
import 'package:byer/service/room_service.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class HistoryPage extends StatefulWidget {
  const HistoryPage({super.key});

  @override
  State<StatefulWidget> createState() => _HistoryPageState();
}

class _HistoryPageState extends State<HistoryPage> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: FutureBuilder(
        future: getBookingHistory(),
        builder: (context, snapshot) {
          if (snapshot.hasData) {
            List<Booking> bookings = snapshot.data!;
            return ListView.builder(
              itemCount: bookings.length,
              itemBuilder: (context, index) {
                var booking = bookings[index];
                return ListingCard(
                  room: booking.room,
                  startTime: booking.startTime,
                  endTime: booking.endTime,
                );
              },
            );
          } else {
            return const Center(child: CircularProgressIndicator());
          }
        },
      ),
    );
  }

  static Future<List<Booking>> getBookingHistory() async {
    return await BookingService.listHistory();
  }
}

class ListingCard extends StatefulWidget {
  final Room room;
  final DateTime? startTime;
  final DateTime? endTime;
  final Function()? onClick;

  const ListingCard({
    super.key,
    required this.room,
    this.startTime,
    this.endTime,
    this.onClick,
  });

  @override
  _ListingCardState createState() => _ListingCardState();
}

class _ListingCardState extends State<ListingCard> {
  bool isHovered = false;

  @override
  Widget build(BuildContext context) {
    return MouseRegion(
      cursor: SystemMouseCursors.click,
      onEnter: (_) => setState(() => isHovered = true),
      onExit: (_) => setState(() => isHovered = false),
      child: GestureDetector(
        onTap: widget.onClick,
        child: Card(
          color: isHovered ? Colors.grey[800] : Colors.grey[900],
          margin: const EdgeInsets.all(8.0),
          elevation: isHovered ? 8 : 4,
          child: ListTile(
            title: Text(
              widget.room.name,
              style: const TextStyle(
                  color: Colors.white, fontSize: 18, fontFamily: 'Inter'),
            ),
            subtitle: Padding(
              padding: const EdgeInsets.only(top: 8.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    widget.room.description
                        .substring(0, min(50, widget.room.description.length)),
                    style:
                        TextStyle(color: Colors.grey[500], fontFamily: 'Inter'),
                  ),
                  const SizedBox(height: 8),
                  if (widget.startTime != null)
                    Text(
                      'Start: ${DateFormat('yyyy-MM-dd – kk:mm').format(widget.startTime!)}',
                      style: TextStyle(
                          color: Colors.grey[400], fontFamily: 'Inter'),
                    ),
                  if (widget.endTime != null)
                    Text(
                      'End: ${DateFormat('yyyy-MM-dd – kk:mm').format(widget.endTime!)}',
                      style: TextStyle(
                          color: Colors.grey[400], fontFamily: 'Inter'),
                    ),
                ],
              ),
            ),
            leading: const Icon(Icons.place, color: Colors.white70),
            trailing: Text(
              'JOD ${widget.room.price}',
              style: const TextStyle(
                  color: Color(0xffF00B51), fontSize: 16, fontFamily: 'Inter'),
            ),
          ),
        ),
      ),
    );
  }
}
