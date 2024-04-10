import 'package:flutter/cupertino.dart';

import '../components/login_template.dart';
import '../components/primary_login_button.dart';
import '../util/navigator.dart';

class WelcomeScreen extends StatelessWidget {
  const WelcomeScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return LoginScreenTemplate(
      children: [
        PrimaryLoginButton(
          onPressed: () {
            pushNavigate(context, '/login');
          },
          child: const Text('Login'),
        ),
        const SizedBox(height: 10),
        PrimaryLoginButton(
          onPressed: () {
            pushNavigate(context, '/signup');
          },
          child: const Text('Sign Up'),
        ),
      ],
    );
  }
}
