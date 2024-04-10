import 'package:flutter/material.dart';
import 'dart:math' as math;

class PrimaryLoginButton extends StatelessWidget {
  final VoidCallback onPressed;
  final Widget child;

  const PrimaryLoginButton(
      {super.key, required this.onPressed, required this.child});

  @override
  Widget build(BuildContext context) {
    return Container(
      height: 57,
      width: double.infinity,
      constraints: const BoxConstraints(
        maxWidth: 349 + 100,
      ),
      decoration: const BoxDecoration(
          gradient: LinearGradient(
              transform: GradientRotation(math.pi / 7),
              colors: [Color(0xFFEF0B51), Color(0xFF8C025F)]),
          borderRadius: BorderRadius.all(Radius.circular(10.0))),
      child: FilledButton(
          onPressed: onPressed,
          style: FilledButton.styleFrom(
              foregroundColor: const Color(0xFFECECEC),
              textStyle: const TextStyle(
                fontFamily: 'Inter',
                fontSize: 24,
                fontWeight: FontWeight.w500,
              ),
              backgroundColor: Colors.transparent,
              shadowColor: Colors.transparent),
          child: child),
    );
  }
}
