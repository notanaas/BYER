import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'dart:math' as math;

class LoginScreenSafeArea extends StatelessWidget {
  const LoginScreenSafeArea({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      height: MediaQuery.of(context).padding.top,
      decoration: const BoxDecoration(
          gradient: LinearGradient(
        transform: GradientRotation(math.pi / 2),
        colors: [
          Color(0xFF730062),
          Color(0xffF00B51),
        ],
      )),
    );
  }
}

class LoginScreenTemplate extends StatelessWidget {
  final List<Widget> children;

  const LoginScreenTemplate({super.key, required this.children});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        padding: const EdgeInsets.only(bottom: 17),
        width: double.infinity,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            const LoginScreenSafeArea(),
            Expanded(
              flex: 1,
              child: Stack(
                children: [
                  FractionallySizedBox(
                      widthFactor: 1.0,
                      child: SvgPicture.asset(
                        'assets/images/template_header.svg',
                        fit: BoxFit.fill,
                      )),
                  Center(
                    child: Transform.translate(
                      offset: const Offset(0, 40),
                      child: Column(
                        children: [
                          SvgPicture.asset('assets/images/template_logo.svg',
                              fit: BoxFit.cover),
                          const Spacer(),
                          Padding(
                            padding: const EdgeInsets.symmetric(horizontal: 28),
                            child: Column(
                              children: children,
                            ),
                          ),
                          const Spacer(),
                          const SizedBox(height: 40),
                        ],
                      ),
                    ),
                  ),
                  Positioned(
                    bottom: 0,
                    right: 0,
                    left: 0,
                    child: Container(
                      alignment: Alignment.center,
                      child: const Text(
                        '© 2024 BYER All Rights Reserved',
                        style: TextStyle(
                          fontSize: 16,
                          color: Color(0xFF444444),
                          fontFamily: 'Inter',
                          fontStyle: FontStyle.normal,
                          fontWeight: FontWeight.w400,
                        ),
                      ),
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
