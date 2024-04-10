import 'dart:convert';
import 'dart:io';

import 'package:byer/util/error.dart';
import 'package:dio/dio.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';

import '../service/room_service.dart';

class EnlistRoomPage extends StatefulWidget {
  const EnlistRoomPage({Key? key}) : super(key: key);

  @override
  _EnlistRoomPageState createState() => _EnlistRoomPageState();
}

class _EnlistRoomPageState extends State<EnlistRoomPage> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  final TextEditingController _nameController = TextEditingController();
  final TextEditingController _descriptionController = TextEditingController();
  final TextEditingController _capacityController = TextEditingController();
  final TextEditingController _priceController = TextEditingController();
  final TextEditingController _longitudeController = TextEditingController();
  final TextEditingController _latitudeController = TextEditingController();
  final TextEditingController _addressController = TextEditingController();
  String? _imageBase64;

  Future<void> _enlistRoom() async {
    if (_formKey.currentState!.validate()) {
      var imageBase64 = _imageBase64;
      if (imageBase64 == null) {
        showErrorMessage(context, "Please upload an image");
        return;
      }
      try {
        await RoomService.create(
          _nameController.text,
          _descriptionController.text,
          int.parse(_capacityController.text),
          double.parse(_priceController.text),
          double.parse(_longitudeController.text),
          double.parse(_latitudeController.text),
          _addressController.text,
          imageBase64,
        );
      } on DioException catch (e) {
        if (context.mounted) {
          showErrorDialog(context, e);
        }
        return;
      } on FormatException {
        if (context.mounted) {
          showErrorMessage(context, "Invalid input in one of the fields");
        }
        return;
      }

      if (context.mounted) {
        Navigator.of(context)
            .pushNamedAndRemoveUntil('/home', (route) => false);
      }
    }
  }

  static const MIN_WIDTH = 1024;
  static const MIN_HEIGHT = 768;

  Future<void> _uploadImage() async {
    FilePickerResult? result = await FilePicker.platform.pickFiles(
      type: FileType.image,
    );

    if (result != null) {
      PlatformFile file = result.files.first;
      var decodedImage =
          await decodeImageFromList(File(file.path!).readAsBytesSync());
      if (decodedImage.width < MIN_WIDTH || decodedImage.height < MIN_HEIGHT) {
        showErrorMessage(context,
            "Image dimensions are too small. Please upload a larger image.");
        return;
      }
      setState(() {
        _imageBase64 = base64Encode(File(file.path!).readAsBytesSync());
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Enlist a Room'),
        backgroundColor: Theme.of(context).colorScheme.primary,
      ),
      body: Form(
        key: _formKey,
        child: ListView(
          padding: const EdgeInsets.all(16.0),
          children: [
            EnlistRoomTextField(
              controller: _nameController,
              labelText: 'Name',
            ),
            EnlistRoomTextField(
              controller: _descriptionController,
              labelText: 'Description',
            ),
            EnlistRoomTextField(
              controller: _capacityController,
              labelText: 'Capacity',
              isNumeric: true,
            ),
            EnlistRoomTextField(
              controller: _priceController,
              labelText: 'Price',
              isNumeric: true,
            ),
            EnlistRoomTextField(
              controller: _longitudeController,
              labelText: 'Longitude',
              isNumeric: true,
            ),
            EnlistRoomTextField(
              controller: _latitudeController,
              labelText: 'Latitude',
              isNumeric: true,
            ),
            EnlistRoomTextField(
              controller: _addressController,
              labelText: 'Address',
            ),
            const SizedBox(height: 20),
            SizedBox(
              height: 40,
              child: ElevatedButton(
                onPressed: _uploadImage,
                style: ElevatedButton.styleFrom(
                  foregroundColor: Colors.white,
                  backgroundColor: const Color(0xffF00B51),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(10.0),
                  ),
                ),
                child: const Text('Upload Image'),
              ),
            ),
            const SizedBox(height: 20),
            SizedBox(
              height: 40,
              child: ElevatedButton(
                  onPressed: _enlistRoom,
                  style: ElevatedButton.styleFrom(
                    foregroundColor: Colors.white,
                    backgroundColor: const Color(0xffF00B51),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10.0),
                    ),
                  ),
                  child: const Text('Enlist Room')),
            ),
          ],
        ),
      ),
    );
  }
}

class EnlistRoomTextField extends StatelessWidget {
  final TextEditingController controller;
  final String labelText;
  final bool isNumeric;
  final int maxLines;
  final String? Function(String?)? validator;

  const EnlistRoomTextField({
    Key? key,
    required this.controller,
    required this.labelText,
    this.isNumeric = false,
    this.maxLines = 1,
    this.validator,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: controller,
      decoration: InputDecoration(labelText: labelText),
      keyboardType: isNumeric
          ? const TextInputType.numberWithOptions(decimal: true)
          : TextInputType.text,
      maxLines: maxLines,
      validator: validator ??
          (value) {
            if (value == null || value.isEmpty) {
              return 'Please enter $labelText';
            }
            if (isNumeric && value.isNotEmpty) {
              final number = num.tryParse(value);
              if (number == null) {
                return 'Please enter a valid number';
              }
            }
            return null;
          },
      style: const TextStyle(
          color: Color(0xffB1B1B1),
          fontFamily: 'Inter',
          fontSize: 18,
          fontWeight: FontWeight.w400),
    );
  }
}
