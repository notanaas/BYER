import 'package:byer/service/auth_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';

class SplashScreen extends StatefulWidget {
  const SplashScreen({super.key});

  @override
  State<StatefulWidget> createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  @override
  void initState() {
    super.initState();
    AuthService.isLoggedIn().then((loggedIn) {
      if (loggedIn) {
        Navigator.of(context)
            .pushNamedAndRemoveUntil('/home', (route) => false);
      } else {
        Navigator.of(context)
            .pushNamedAndRemoveUntil('/welcome', (route) => false);
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            SvgPicture.asset('assets/images/template_logo.svg',
                fit: BoxFit.fill),
            const SizedBox(height: 100),
            const CircularProgressIndicator(
                color: Color(0xFFF00B51), strokeWidth: 5),
          ],
        ),
      ),
    );
  }
}
