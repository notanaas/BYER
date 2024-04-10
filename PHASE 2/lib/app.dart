import 'package:byer/screens/search_screen.dart';
import 'package:flutter/material.dart';

import 'screens/home_screen.dart';
import 'screens/login_screen.dart';
import 'screens/signup_screen.dart';
import 'screens/splash_screen.dart';
import 'screens/welcome_screen.dart';

var byerThemeData = ThemeData(
    useMaterial3: true,
    dialogTheme: const DialogTheme(
      backgroundColor: Color(0xFF0F0F0F),
      surfaceTintColor: Color(0xFF0F0F0F),
      titleTextStyle: TextStyle(
        color: Colors.white,
        fontFamily: 'Inter',
        fontSize: 20,
        fontWeight: FontWeight.w500,
      ),
      contentTextStyle: TextStyle(
        color: Colors.white,
        fontFamily: 'Inter',
        fontSize: 16,
        fontWeight: FontWeight.w400,
      ),
      actionsPadding: EdgeInsets.all(10),
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.all(Radius.circular(10)),
      ),
      iconColor: Colors.white,
    ),
    buttonTheme: const ButtonThemeData(
      buttonColor: Color(0xFFF00B51),
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.all(Radius.circular(10)),
      ),
      highlightColor: Color(0xFFE60045),
      splashColor: Color(0xFFE60045),
    ),
    datePickerTheme: const DatePickerThemeData(
      backgroundColor: Color(0xFF0F0F0F)
    ),
    filledButtonTheme: FilledButtonThemeData(
      style: ButtonStyle(
        textStyle: MaterialStateProperty.all(
          const TextStyle(
            fontSize: 16,
            fontWeight: FontWeight.w600,
          ),
        ),
        shape: MaterialStateProperty.all(
          RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(10),
          ),
        ),
      ),
    ),
    colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple).copyWith(
        background: const Color(0xFF0F0F0F),
        brightness: Brightness.dark,
        primary: const Color(0xFFF00B51)));

class ByerApp extends StatefulWidget {
  const ByerApp({super.key});

  @override
  State<StatefulWidget> createState() => _ByerAppState();
}

class _ByerAppState extends State<ByerApp> {
  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'Byer',
        theme: byerThemeData,
        initialRoute: '/splash', // TODO change later
        routes: {
          '/splash': (context) => const SplashScreen(),
          '/welcome': (context) => const WelcomeScreen(),
          '/login': (context) => LoginScreen(),
          '/signup': (context) => SignUpScreen(),
          '/home': (context) => const HomeScreen(),
          '/search': (context) => const SearchScreen(),
        });
  }
}
