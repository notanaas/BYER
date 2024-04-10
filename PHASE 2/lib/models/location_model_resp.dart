class LocationModelResp {
  final String address;
  final double longitude;
  final double latitude;

  LocationModelResp({
    required this.address,
    required this.longitude,
    required this.latitude,
  });

  factory LocationModelResp.fromMap(Map<String, dynamic> map) {
    return LocationModelResp(
      address: map["display_name"],
      longitude: double.parse(map["lon"]),
      latitude: double.parse(map["lat"]),
    );
  }
}
