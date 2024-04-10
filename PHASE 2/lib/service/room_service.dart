import 'package:dio/dio.dart';
import 'api_service.dart';

class Room {
  final int id;
  final int ownerId;
  final String name;
  final String description;
  final int capacity;
  final double price;
  final DateTime createdAt;
  final double longitude;
  final double latitude;
  final String address;
  final String imageName;

  Room(
      this.id,
      this.ownerId,
      this.name,
      this.description,
      this.capacity,
      this.price,
      this.createdAt,
      this.longitude,
      this.latitude,
      this.address,
      this.imageName);
}

class RoomReview {
  final int roomId;
  final int userId;
  final String userName;
  final int? rating;
  final String? comment;
  final DateTime createdAt;

  RoomReview(this.roomId, this.userId, this.userName, this.rating, this.comment,
      this.createdAt);
}

class RoomService {
  static Future<Room> get(int roomId) async {
    final response = await ApiService.getRoom(roomId);
    return mapRoom(response);
  }

  static Future<List<Room>> list(String? name, DateTime? startDate,
      DateTime? endDate, double longitude, double latitude) async {
    final response = await ApiService.listRooms(
        name, startDate, endDate, longitude, latitude);
    var roomIds = response.data['rooms'].map<int>((room) => room as int).toList();
    return Future.wait<Room>(roomIds.map<Future<Room>>(RoomService.get));
  }

  static Future<Room> create(
      String name,
      String description,
      int capacity,
      double price,
      double longitude,
      double latitude,
      String address,
      String imageBase64) async {
    final response = await ApiService.createRoom(name, description, capacity,
        price, longitude, latitude, address, imageBase64);
    return mapRoom(response);
  }


  static Future<List<RoomReview>> listReviews(int roomId) async {
    final response = await ApiService.listReviews(roomId);
    var reviews = response.data['reviews'].map<RoomReview>((review) {
      return RoomReview(
        review['room_id'],
        review['user_id'],
        review['user_name'],
        review['rating'],
        review['comment'],
        DateTime.parse(review['created_at']),
      );
    }).toList();
    return reviews;
  }

  static Future<void> placeRating(int roomId, int rating) async {
    await ApiService.placeRating(roomId, rating);
  }

  static Future<void> placeComment(int roomId, String comment) async {
    await ApiService.placeComment(roomId, comment);
  }

  static Room mapRoom(Response response) {
    return Room(
      response.data['id'],
      response.data['owner_id'],
      response.data['name'],
      response.data['description'],
      response.data['capacity'],
      response.data['price'],
      DateTime.parse(response.data['created_at']),
      response.data['longitude'],
      response.data['latitude'],
      response.data['address'],
      response.data['image_name'],
    );
  }
}
