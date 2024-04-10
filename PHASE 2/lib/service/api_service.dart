import 'package:byer/service/secure_storage_service.dart';
import 'package:dio/dio.dart';
import 'package:flutter/foundation.dart';

class ApiService {
  static final Dio _dio = Dio(BaseOptions(
      // baseUrl: "http://10.0.2.2:3000/v1",
      baseUrl: "http://127.0.0.1:3000/v1",
      connectTimeout: const Duration(seconds: 5),
      receiveTimeout: const Duration(seconds: 5),
      headers: {
        "Content-Type": "application/json",
        "Accept": "application/json",
        "Accept-Language": "en",
        "Accept-Charset": "utf-8",
        "User-Agent": "Byer/1.0.0",
      }))
    ..interceptors.add(InterceptorsWrapper(
      onRequest: (options, handler) async {
        final accessToken = await SecureStorageService.read("access_token");
        if (accessToken != null) {
          options.headers["Authorization"] = "Bearer $accessToken";
        }
        return handler.next(options);
      },
      onResponse: (response, handler) async {
        return handler.next(response);
      },
      onError: (DioException e, handler) async {
        if (kDebugMode) {
          print(e.response?.data);
        }
        if (e.response?.statusCode == 401) {
          final refreshToken = await SecureStorageService.read("refresh_token");
          if (refreshToken != null && e.requestOptions.path != "/auth/refresh") {
            final response = await _dio.post("/auth/refresh", data: {"refresh_token": refreshToken});
            if (response.statusCode == 200) {
              await SecureStorageService.write(
                  "access_token", response.data["access_token"]);
              await SecureStorageService.write(
                  "refresh_token", response.data["refresh_token"]);
              return handler.resolve(await _dio.fetch(e.requestOptions));
            }
          } else {
            await SecureStorageService.deleteAll();
            // TODO: navigate to '/login'
          }
        }
        return handler.next(e);
      },
    ));

  static Future<Response> login(String email, String password) async {
    return await _dio.post("/auth/login", data: {
      "email": email,
      "password": password,
    });
  }

  static Future<Response> refresh(String refreshToken) async {
    return await _dio.post("/auth/refresh", data: {
      "refresh_token": refreshToken,
    });
  }

  static Future<Response> get_user() async {
    return await _dio.get('/user');
  }

  static signUp(String name, String email, String password) async {
    return await _dio.post("/user/create", data: {
      "email": email,
      "name": name,
      "password": password,
    });
  }

  static Future<Response> getRoom(int id) async {
    return await _dio.get("/room", data: {
      "id": id,
    });
  }

  static Future<Response> listRooms(String? name, DateTime? startDate,
      DateTime? endDate, double longitude, double latitude) async {
    return await _dio.get("/room/list", data: {
      "name": name,
      "start_date": startDate,
      "end_date": endDate,
      "longitude": longitude,
      "latitude": latitude,
    });
  }

  static Future<Response> createRoom(
      String name,
      String description,
      int capacity,
      double price,
      double longitude,
      double latitude,
      String address,
      String imageBase64) async {
    return await _dio.post("/room/create", data: {
      "name": name,
      "description": description,
      "capacity": capacity,
      "price": price,
      "longitude": longitude,
      "latitude": latitude,
      "address": address,
      "image": imageBase64,
    });
  }

  static Future<Response> getBooking(int id) async {
    return await _dio.get("/booking", data: {
      "id": id,
    });
  }

  static Future<Response> createBooking(
      int roomId, DateTime startTime, DateTime endTime) async {
    return await _dio.post("/booking/create", data: {
      "room_id": roomId,
      "start_time": startTime.toIso8601String(),
      "end_time": endTime.toIso8601String()
    });
  }

  static Future<Response> getBookingHistory() async {
    return await _dio.get("/booking/history");
  }

  static Future<Response> getBookingActive() async {
    return await _dio.get("/booking/active");
  }

  static Future<Response> uploadUserImage(String base64Image) async {
    return await _dio.post("/user/upload", data: {
      "image": base64Image
    });
  }

  static Future<Response> getUpload(String name) async {
    return await _dio.get("/upload", data: {
      "name": name
    });
  }

  static Future<Response> changeUserProfileImage(String base64) async {
    return await _dio.post("/user/upload", data: {
      "image": base64
    });
  }

  static Future<Response> listReviews(int roomId) async {
    return await _dio.get("/room/reviews/list", data: {
      "room_id": roomId
    });
  }

  static Future<Response> placeRating(int roomId, int rating) async {
    return await _dio.post("/room/reviews/rating", data: {
      "room_id": roomId,
      "rating": rating
    });
  }

  static Future<Response> placeComment(int roomId, String comment) async {
    return await _dio.post("/room/reviews/comment", data: {
      "room_id": roomId,
      "comment": comment
    });
  }
}
