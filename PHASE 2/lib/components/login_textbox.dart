import 'package:flutter/material.dart';

class LoginTextBox extends StatelessWidget {
  final TextInputType type;
  final String labelText;
  final String placeholderText;
  final TextEditingController controller;

  const LoginTextBox({
    Key? key,
    required this.type,
    required this.labelText,
    required this.placeholderText,
    required this.controller,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Align(
          alignment: Alignment.centerLeft,
          child: Text(
            labelText,
            style: const TextStyle(
              color: Color(0xffA4A4A4),
              fontFamily: 'Inter',
              fontSize: 16,
              fontWeight: FontWeight.w400,
            ),
          ),
        ),
        const SizedBox(height: 5),
        Container(
          decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(6),
              border: Border.all(
                color: const Color(0xFF404040),
                width: 1,
              ),
              color: const Color(0xFF0D0D0D)),
          child: TextField(
            controller: controller,
            keyboardType: type,
            keyboardAppearance: Brightness.dark,
            obscureText: type == TextInputType.visiblePassword,
            cursorColor: const Color(0xFFB1B1B1),
            decoration: InputDecoration(
              enabledBorder: InputBorder.none,
              focusedBorder: InputBorder.none,
              disabledBorder: InputBorder.none,
              errorBorder: InputBorder.none,
              focusedErrorBorder: InputBorder.none,
              hintText: placeholderText,
              labelStyle: const TextStyle(
                color: Color(0xffB1B1B1),
                fontFamily: 'Inter',
                fontSize: 18,
                fontWeight: FontWeight.w400,
              ),
              hintStyle: const TextStyle(
                color: Color(0xffB1B1B1),
                fontFamily: 'Inter',
                fontSize: 18,
                fontWeight: FontWeight.w400,
              ),
              border: InputBorder.none,
              contentPadding: const EdgeInsets.only(left: 10),
            ),
            style: const TextStyle(
              color: Color(0xffB1B1B1),
              fontFamily: 'Inter',
              fontSize: 18,
              fontWeight: FontWeight.w400,
            ),
          ),
        ),
      ],
    );
  }
}
