import 'dart:convert';
import 'dart:io';
import 'dart:typed_data';

import 'package:flutter/material.dart';
import 'package:dio/dio.dart';
import 'api_service.dart';

class User {
  final int id;
  final String email;
  final String name;
  final String? profileImage;

  User({
    required this.id,
    required this.email,
    required this.name,
    this.profileImage,
  });
}

class UserService {
  static Future<User> get() async {
    try {
      final response = await ApiService.get_user();
      return User(
        id: response.data['id'],
        email: response.data['email'],
        name: response.data['name'],
        profileImage: response.data['profile_image'],
      );
    } on DioException {
      rethrow;
    }
  }

  static Future<void> signUp(BuildContext context, String name, String email, String password) async {
    try {
      await ApiService.signUp(name, email, password);
    } on DioException {
      rethrow;
    }
  }

  static Future<String> changeProfileImage(File file) async {
    try {
      var base64Image = base64Encode(file.readAsBytesSync());
      var response = await ApiService.changeUserProfileImage(base64Image);
      return response.data['name'];
    } on DioException {
      rethrow;
    }
  }
}
