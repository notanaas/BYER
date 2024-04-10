import 'package:dio/dio.dart';
import 'package:flutter/gestures.dart';
import 'package:flutter/material.dart';

import '../components/login_template.dart';
import '../components/login_textbox.dart';
import '../components/primary_login_button.dart';
import '../service/auth_service.dart';
import '../service/user_service.dart';
import '../util/error.dart';

class SignUpScreen extends StatelessWidget {
  final TextEditingController nameController = TextEditingController();
  final TextEditingController emailController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();

  SignUpScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return LoginScreenTemplate(
      children: <Widget>[
        LoginTextBox(
            type: TextInputType.name,
            labelText: "Full Name",
            placeholderText: "Your name",
            controller: nameController),
        const SizedBox(height: 25),
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
        const SizedBox(height: 25),
        PrimaryLoginButton(
          onPressed: () {
            var name = nameController.text;
            var email = emailController.text;
            var password = passwordController.text;
            tryToSignUp(context, name, email, password);
          },
          child: const Text('Sign Up'),
        ),
        const SizedBox(height: 60),
        Align(
          alignment: Alignment.center,
          child: Text.rich(
            TextSpan(
              text: "By clicking Sign Up, you agree to our ",
              style: const TextStyle(
                color: Color(0xffA4A4A4),
                fontFamily: 'Inter',
                fontSize: 18,
                fontWeight: FontWeight.w500,
              ),
              children: [
                TextSpan(
                  text: "Terms and Condition",
                  style: const TextStyle(
                    color: Color(0xffF00B51),
                    fontFamily: 'Inter',
                    fontSize: 18,
                    fontWeight: FontWeight.w500,
                  ),
                  recognizer: TapGestureRecognizer()..onTap = () {},
                ),
                const TextSpan(
                  text: " & ",
                  style: TextStyle(
                    color: Color(0xffA4A4A4),
                    fontFamily: 'Inter',
                    fontSize: 18,
                    fontWeight: FontWeight.w500,
                  ),
                ),
                TextSpan(
                  text: "Privacy Policy",
                  style: const TextStyle(
                    color: Color(0xffF00B51),
                    fontFamily: 'Inter',
                    fontSize: 18,
                    fontWeight: FontWeight.w500,
                  ),
                  recognizer: TapGestureRecognizer()..onTap = () {},
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }

  tryToSignUp(
      BuildContext context, String name, String email, String password) async {
    try {
      await UserService.signUp(context, name, email, password);
      if (context.mounted) {
        await AuthService.login(context, email, password);
        if (context.mounted) {
          Navigator.of(context)
              .pushNamedAndRemoveUntil('/home', (route) => false);
        }
      }
    } on DioException catch (e) {
      if (context.mounted) {
        showErrorDialog(context, e);
      }
      rethrow;
    }
  }
}
