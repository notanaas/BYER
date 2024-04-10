import 'package:byer/service/auth_service.dart';
import 'package:byer/util/error.dart';
import 'package:dio/dio.dart';
import 'package:flutter/gestures.dart';
import 'package:flutter/material.dart';

import '../components/login_template.dart';
import '../components/login_textbox.dart';
import '../components/primary_login_button.dart';

class LoginScreen extends StatelessWidget {
  final TextEditingController emailController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();

  LoginScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return LoginScreenTemplate(
      children: <Widget>[
        LoginTextBox(
            type: TextInputType.emailAddress,
            labelText: "Email",
            placeholderText: "Your email address",
            controller: emailController),
        const SizedBox(height: 25),
        LoginTextBox(
            type: TextInputType.visiblePassword,
            labelText: "Password",
            placeholderText: "Your password",
            controller: passwordController),
        const SizedBox(height: 11),
        Align(
          alignment: Alignment.centerLeft,
          child: Text.rich(
            TextSpan(
              text: "Forgot password?",
              style: const TextStyle(
                color: Color(0xffA4A4A4),
                fontFamily: 'Inter',
                fontSize: 18,
                fontWeight: FontWeight.w400,
              ),
              recognizer: TapGestureRecognizer()..onTap = () {},
            ),
          ),
        ),
        const SizedBox(height: 11),
        PrimaryLoginButton(
          onPressed: () async {
            var email = emailController.text;
            var password = passwordController.text;
            tryToLogin(context, email, password);
          },
          child: const Text('Login'),
        ),
      ],
    );
  }

  tryToLogin(BuildContext context, String email, String password) async {
    try {
      await AuthService.login(context, email, password);
      if (context.mounted) {
        Navigator.of(context)
            .pushNamedAndRemoveUntil('/home', (route) => false);
      }
    } on DioException catch (e) {
      if (context.mounted) {
        showErrorDialog(context, e);
      }
    }
  }
}
