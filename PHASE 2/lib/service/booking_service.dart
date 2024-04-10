import 'package:byer/service/room_service.dart';

import 'api_service.dart';

class Booking {
  final int id;
  final Room room;
  final int userId;
  final DateTime startTime;
  final DateTime endTime;
  final DateTime createdAt;

  Booking(this.id, this.room, this.userId, this.startTime, this.endTime,
      this.createdAt);
}

class BookingService {
  static Future<Booking> get(int roomId) async {
    final response = await ApiService.getBooking(roomId);
    return await mapBooking(response.data);
  }

  static Future<Booking> create(
      int roomId, DateTime startTime, DateTime endTime) async {
    final response = await ApiService.createBooking(roomId, startTime, endTime);
    return await mapBooking(response.data);
  }

  static Future<List<Booking>> listHistory() async {
    final response = await ApiService.getBookingHistory();
    var bookings = response.data['history'];
    var futures = bookings.map<Future<Booking>>(mapBooking);
    return Future.wait<Booking>(futures);
  }

  static Future<List<Booking>> listActive() async {
    final response = await ApiService.getBookingActive();
    var bookings = response.data['bookings'];
    var futures = bookings.map<Future<Booking>>(mapBooking);
    return Future.wait<Booking>(futures);
  }

  static Future<Booking> mapBooking(dynamic response) async {
    final room = await RoomService.get(response['room_id'] as int);
    return Booking(
      response['id'],
      room,
      response['user_id'],
      DateTime.parse(response['start_time']),
      DateTime.parse(response['end_time']),
      DateTime.parse(response['created_at']),
    );
  }

}
