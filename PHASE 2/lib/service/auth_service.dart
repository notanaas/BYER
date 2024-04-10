import 'package:flutter/material.dart';
import 'package:dio/dio.dart';
import 'secure_storage_service.dart';
import 'api_service.dart';

class AuthService {
  static Future<void> login(
      BuildContext context, String email, String password) async {
    try {
      final response = await ApiService.login(email, password);
      final accessToken = response.data['access_token'];
      final refreshToken = response.data['refresh_token'];
      await SecureStorageService.write('access_token', accessToken);
      await SecureStorageService.write('refresh_token', refreshToken);
    } on DioException {
      rethrow;
    }
  }

  static logout() async {
    await SecureStorageService.deleteAll();
  }

  static Future<bool> isLoggedIn() async {
    var refreshToken = await SecureStorageService.read("refresh_token");
    if (refreshToken == null) {
      return false;
    }
    var response = await ApiService.refresh(refreshToken);
    if (response.statusCode == 200) {
      await SecureStorageService.write(
          "access_token", response.data["access_token"]);
      await SecureStorageService.write(
          "refresh_token", response.data["refresh_token"]);
      return true;
    }
    return false;
  }
}
