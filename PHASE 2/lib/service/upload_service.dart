import 'dart:convert';
import 'dart:typed_data';

import 'package:dio/dio.dart';

import 'api_service.dart';

class UploadService {
  static Future<Uint8List> getRaw(String name) async {
    try {
      var response = await ApiService.getUpload(name);
      var base64 = response.data['image'];
      return base64Decode(base64);
    } on DioException {
      rethrow;
    }
  }
}
