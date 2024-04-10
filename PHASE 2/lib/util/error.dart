import 'dart:io';

import 'package:dio/dio.dart';
import 'package:flutter/material.dart';

void showErrorDialog(BuildContext context, DioException exception) {
  var response = exception.response;
  String message;
  if (response != null) {
    message = getErrorMessage(response.data['message']);
  } else {
    message = "Unknown error";
  }
  if (!Platform.isAndroid) {
    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Error'),
        content: Text(message),
        actions: [
          TextButton(
            onPressed: () {
              Navigator.of(context).pop();
            },
            child: const Text('OK'),
          ),
        ],
      ),
    );
  } else {}
}

void showErrorMessage(BuildContext context, String message) {
  ScaffoldMessenger.of(context).showSnackBar(SnackBar(
      content: Text(message),
      backgroundColor: const Color(0xFFF00B51),
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(2.0),
      )));
}

String getErrorMessage(message) {
  switch (message) {
    case 'Invalid credentials':
    case 'Wrong credentials':
      return 'The email or password you entered is incorrect.';
    default:
      return message;
  }
}
