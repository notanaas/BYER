import 'dart:io';
import 'dart:typed_data';

import 'package:byer/service/auth_service.dart';
import 'package:byer/service/upload_service.dart';
import 'package:byer/service/user_service.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({super.key});

  @override
  State<StatefulWidget> createState() => ProfilePageState();
}

class ProfilePageState extends State<ProfilePage> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: UserService.get(),
      builder: (ctx, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(
            child: SizedBox(
              height: 30,
              width: 30,
              child: CircularProgressIndicator(),
            ),
          );
        }

        if (snapshot.hasError) {
          return Container();
        }
        return SafeArea(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Center(
                child: Column(
                  children: [
                    const SizedBox(height: 20),
                    Text(
                      "${snapshot.data!.name}'s Profile",
                      style: const TextStyle(
                        color: Colors.white,
                        fontSize: 20,
                      ),
                    ),
                    const SizedBox(height: 30),
                    FutureBuilder(future: _getUserImage(snapshot.data!),
                        builder: (context, snapshot) {
                          if (snapshot.connectionState ==
                              ConnectionState.waiting) {
                            return const Center(
                              child: SizedBox(
                                height: 30,
                                width: 30,
                                child: CircularProgressIndicator(),
                              ),
                            );
                          }

                          if (snapshot.hasError) {
                            return Container();
                          }
                          return ProfileImage(parent: this, image: snapshot.data);
                        }),
                    const SizedBox(height: 30),
                  ],
                ),
              ),
              Column(
                children: [
                  Container(
                    margin: const EdgeInsets.symmetric(horizontal: 15),
                    padding: const EdgeInsets.symmetric(
                        horizontal: 15, vertical: 13),
                    decoration: const BoxDecoration(
                      border: Border.symmetric(
                        horizontal:
                        BorderSide(color: Color(0x3FFF0000), width: 0.5),
                      ),
                    ),
                    child: Row(
                      children: [
                        const Text(
                          "Email:",
                          style: TextStyle(
                            color: Color(0xFFF00B51),
                            fontSize: 17,
                            fontWeight: FontWeight.w300,
                          ),
                        ),
                        const SizedBox(width: 15),
                        Text(
                          snapshot.data!.email,
                          style: const TextStyle(
                              color: Colors.white, fontSize: 17),
                        )
                      ],
                    ),
                  ),
                ],
              ),
              const Expanded(child: SizedBox()),
              Center(
                child: Theme(
                  data: ThemeData(),
                  child: ElevatedButton(
                    onPressed: () async {
                      await AuthService.logout();
                      if (context.mounted) {
                        Navigator.pushNamedAndRemoveUntil(
                            context, '/login', (route) => false);
                      }
                    },
                    child: const Text('Logout'),
                  ),
                ),
              ),
              const SizedBox(height: 30),
            ],
          ),
        );
      },
    );
  }

  Future<Uint8List?> _getUserImage(User user) async {
    print(user.profileImage);
    if (user.profileImage == null) {
      return null;
    }
    return await UploadService.getRaw(user.profileImage!);
  }

}


class ProfileImage extends StatefulWidget {

  final ProfilePageState parent;
  final Uint8List? image;

  ProfileImage({Key? key, required this.parent, this.image}) : super(key: key);


  @override
  State<ProfileImage> createState() => _ProfileImageState(parent);
}

class _ProfileImageState extends State<ProfileImage> {

  final ProfilePageState parent;

  _ProfileImageState(this.parent);

  @override
  Widget build(BuildContext context) {
    return Container(
      height: 120,
      width: 120,
      decoration: BoxDecoration(
        shape: BoxShape.circle,
        border: Border.all(color: const Color(0xFFF00B51), width: 2),
      ),
      child: GestureDetector(
        onTap: () async {
          _changeImage(context);
        },
        child: ClipOval(
          child: widget.image != null ? Image.memory(widget.image!) : Image.asset(
              "assets/images/user_placeholder.jpg"),
        ),
      ),
    );
  }

  void _changeImage(BuildContext context) {
    showModalBottomSheet(
      context: context,
      builder: (context) {

        return SizedBox(
          height: 100,
          child: Column(
            children: [
              ListTile(
                leading: const Icon(Icons.camera_alt),
                title: const Text('Camera'),
                onTap: () {
                  Navigator.pop(context);
                  _uploadImage(context, ImageSource.camera);
                },
              ),
              ListTile(
                leading: const Icon(Icons.photo_library),
                title: const Text('Gallery'),
                onTap: () {
                  Navigator.pop(context);
                  _uploadImage(context, ImageSource.gallery);
                },
              ),
            ],
          ),
        );
      },
    );
  }

  void _uploadImage(BuildContext context, ImageSource source) async {
    var image = await ImagePicker().pickImage(source: source);
    if (image == null) {
      return;
    }
    var imageName = await UserService.changeProfileImage(File(image.path));
    parent.setState(() {
    });
  }
}