import 'package:flutter/material.dart';

@optionalTypeArgs
Future<T?> pushNavigate<T extends Object?>(
    BuildContext context, String screen) {
  return Navigator.of(context).pushNamed(screen);
}
