import 'package:dio/dio.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:intl/intl.dart';
import '../service/room_service.dart';
import '../util/error.dart';
import '../service/booking_service.dart';

class BookRoomScreen extends StatefulWidget {
  final int roomId;

  const BookRoomScreen({Key? key, required this.roomId}) : super(key: key);

  @override
  _BookRoomScreenState createState() => _BookRoomScreenState();
}

class _BookRoomScreenState extends State<BookRoomScreen>
    with SingleTickerProviderStateMixin {
  late Room _roomDetails;
  bool _isLoading = true;
  DateTime _startDate = DateTime.now();
  DateTime _endDate = DateTime.now().add(const Duration(days: 1));
  late TabController _tabController;

  @override
  void initState() {
    super.initState();
    _tabController = TabController(length: 2, vsync: this);
    _fetchRoomDetails();
  }

  Future<void> _fetchRoomDetails() async {
    try {
      _roomDetails = await RoomService.get(widget.roomId);
    } catch (e) {
      if (context.mounted) {
        showErrorMessage(context, "Failed to fetch room details");
      }
    } finally {
      if (context.mounted) {
        setState(() {
          _isLoading = false;
        });
      }
    }
  }

  Future<void> _selectDate(BuildContext context, bool isStartDate) async {
    final DateTime? pickedDate = await showDatePicker(
      context: context,
      initialDate: isStartDate ? _startDate : _endDate,
      firstDate: DateTime.now(),
      lastDate: DateTime(2025),
    );

    if (pickedDate != null) {
      setState(() {
        if (isStartDate) {
          _startDate = pickedDate;
          if (_endDate.isBefore(_startDate)) {
            _endDate = _startDate.add(const Duration(days: 1));
          }
        } else {
          if (pickedDate.isBefore(_startDate)) {
            _startDate = pickedDate.subtract(const Duration(days: 1));
          }
          _endDate = pickedDate;
        }
      });
    }
  }

  Future<void> _bookRoom() async {
    try {
      await BookingService.create(
        widget.roomId,
        _startDate,
        _endDate,
      );
      if (context.mounted) {
        Navigator.of(context).pushNamedAndRemoveUntil(
          '/home',
          (route) => false,
        );
      }
    } on DioException catch (e) {
      if (context.mounted) {
        showErrorDialog(context, e);
      }
    } on Exception {
      if (context.mounted) {
        showErrorMessage(context, "Something went wrong");
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    final textTheme = Theme.of(context).textTheme.apply(
          bodyColor: Colors.white,
          displayColor: const Color(0xffA4A4A4),
          fontFamily: 'Inter',
        );

    return Scaffold(
      appBar: AppBar(
        title: const Text('Book a Room'),
        backgroundColor: Theme.of(context).colorScheme.primary,
        bottom: TabBar(
          controller: _tabController,
          unselectedLabelStyle: textTheme.bodyMedium!.copyWith(
            color: Colors.white,
          ),
          labelStyle: textTheme.bodyMedium!,
          tabs: const [
            Tab(text: 'Details'),
            Tab(text: 'Reviews'),
          ],
        ),
      ),
      body: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : TabBarView(
              controller: _tabController,
              children: [
                buildRoomDetailsView(context, textTheme),
                RoomReviewsPage(roomId: widget.roomId)
              ],
            ),
    );
  }

  Widget buildRoomDetailsView(BuildContext context, TextTheme textTheme) {
    return SingleChildScrollView(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          const Placeholder(
            fallbackHeight: 200.0,
            fallbackWidth: double.infinity,
          ),
          const SizedBox(height: 8),
          buildRoomDetailsTable(textTheme),
          const Divider(color: Colors.white),
          _buildDateTile(
              'Start Date', _startDate, () => _selectDate(context, true)),
          _buildDateTile(
              'End Date', _endDate, () => _selectDate(context, false)),
          buildBookingButton(),
        ],
      ),
    );
  }

  Widget buildBookingButton() {
    return SizedBox(
      width: double.infinity,
      height: 80,
      child: Padding(
        padding: const EdgeInsets.symmetric(vertical: 16.0, horizontal: 8.0),
        child: ElevatedButton(
          style: ElevatedButton.styleFrom(
            foregroundColor: Colors.white,
            backgroundColor: const Color(0xffF00B51),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(10.0),
            ),
          ),
          onPressed: _bookRoom,
          child: const Text('Book'),
        ),
      ),
    );
  }

  Widget buildRoomDetailsTable(TextTheme textTheme) {
    return Table(
      columnWidths: const {
        0: FractionColumnWidth(0.3),
        1: FractionColumnWidth(0.7),
      },
      children: [
        buildTableRow('Name:', _roomDetails.name, textTheme),
        buildTableRow('Description:', _roomDetails.description, textTheme),
        buildTableRow('Price:', '${_roomDetails.price} JOD', textTheme),
        buildTableRow('Capacity:', '${_roomDetails.capacity}', textTheme),
        buildTableRow('Longitude:', '${_roomDetails.longitude}', textTheme),
        buildTableRow('Latitude:', '${_roomDetails.latitude}', textTheme),
        buildTableRow('Address:', _roomDetails.address, textTheme),
        buildTableRow('Owner ID:', '${_roomDetails.ownerId}', textTheme)
      ],
    );
  }

  TableRow buildTableRow(String title, String value, TextTheme textTheme) {
    return TableRow(
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(vertical: 8.0),
          child: Text(title, style: textTheme.bodyLarge),
        ),
        Padding(
          padding: const EdgeInsets.symmetric(vertical: 8.0),
          child: Text(value, style: textTheme.bodyMedium),
        ),
      ],
    );
  }

  Widget _buildDateTile(String title, DateTime date, VoidCallback onTap) {
    return Container(
      decoration: BoxDecoration(
        border: Border.all(color: Colors.grey),
        borderRadius: BorderRadius.circular(8.0),
      ),
      margin: const EdgeInsets.symmetric(vertical: 8.0),
      child: ListTile(
        title: Text(title, style: const TextStyle(color: Colors.white)),
        subtitle: Text(
          DateFormat('yyyy-MM-dd').format(date),
          style: const TextStyle(color: Color(0xffA4A4A4)),
        ),
        trailing: const Icon(Icons.calendar_today, color: Colors.white),
        onTap: onTap,
      ),
    );
  }

/* ---------------------------------- Ratings Tab ---------------------------------- */
}

class RoomReviewsPage extends StatefulWidget {
  final int roomId;

  const RoomReviewsPage({super.key, required this.roomId});

  @override
  State<RoomReviewsPage> createState() => _RoomReviewsPageState();
}

class _RoomReviewsPageState extends State<RoomReviewsPage> {
  final TextEditingController _commentController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
        future: RoomService.listReviews(widget.roomId),
        builder: (context, snapshot) {
          if (snapshot.hasData) {
            return buildRatingsView(
                context, Theme.of(context).textTheme, snapshot.data!);
          } else {
            return const Center(child: CircularProgressIndicator());
          }
        });
  }

  Widget buildRatingsView(
      BuildContext context, TextTheme textTheme, List<RoomReview> reviews) {
    return SingleChildScrollView(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          buildOverallRating(textTheme, reviews),
          const SizedBox(height: 16),
          buildCommentInput(textTheme),
          const SizedBox(height: 16),
          buildReviewsList(textTheme, reviews),
        ],
      ),
    );
  }

  Widget buildCommentInput(TextTheme textTheme) {
    return SizedBox(
      width: double.infinity,
      child: Row(
        children: [
          Expanded(
            child: TextField(
              controller: _commentController,
              decoration: const InputDecoration(
                border: OutlineInputBorder(),
                hintText: 'Leave a comment',
                hintStyle: TextStyle(color: Colors.grey),
              ),
              style: textTheme.bodyText1?.copyWith(color: Colors.white),
            ),
          ),
          IconButton(
            onPressed: () async {
              await RoomService.placeComment(
                  widget.roomId, _commentController.text);
              setState(() {
                _commentController.clear();
                var snackBar = SnackBar(
                    content: const Text('Comment added'),
                    backgroundColor: const Color(0xFFF00B51),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10.0),
                    )
                );
                ScaffoldMessenger.of(context).showSnackBar(snackBar);
              });
            },
            icon: const Icon(Icons.send, color: Colors.white),
          ),
        ],
      ),
    );
  }

  double _userRating = 0.0;

  Widget buildOverallRating(TextTheme textTheme, List<RoomReview> reviews) {
    var ratings = reviews.map((review) => review.rating).nonNulls;
    var totalRating = ratings.fold(0.0, (sum, rating) => sum + rating / 2.0);
    var averageRating = ratings.isEmpty ? 0.0 : totalRating / ratings.length;
    return Container(
      padding: const EdgeInsets.all(16.0),
      decoration: BoxDecoration(
        color: const Color(0xFF1A1A1A),
        borderRadius: BorderRadius.circular(8.0),
      ),
      width: double.infinity,
      child: Column(
        children: [
          Text(
            'Overall Rating',
            style: textTheme.titleLarge?.copyWith(color: Colors.white),
          ),
          const SizedBox(height: 8),
          RatingBarIndicator(
            rating: averageRating,
            itemBuilder: (context, index) => const Icon(
              Icons.star,
              color: Color(0xffF00B51),
            ),
            itemCount: 5,
            itemSize: 40.0,
            direction: Axis.horizontal,
          ),
          Row(
            children: [
              Text(
                "${averageRating.toStringAsFixed(1)} out of 5",
                style: textTheme.titleMedium?.copyWith(color: Colors.white),
              ),
              const SizedBox(width: 8),
              Text(
                "(${ratings.length} ratings)",
                style: textTheme.bodyMedium?.copyWith(color: Colors.grey),
              ),
            ],
            mainAxisAlignment: MainAxisAlignment.center,
          ),
          const SizedBox(height: 16),
          RatingBar(
            initialRating: _userRating ?? 0,
            minRating: 1,
            direction: Axis.horizontal,
            allowHalfRating: true,
            itemCount: 5,
            itemPadding: const EdgeInsets.symmetric(horizontal: 4.0),
            ratingWidget: RatingWidget(
              full: const Icon(Icons.star, color: Color(0xffF00B51)),
              half: const Icon(Icons.star_half, color: Color(0xffF00B51)),
              empty: const Icon(Icons.star_border, color: Color(0xffF00B51)),
            ),
            onRatingUpdate: (rating) async {
              await RoomService.placeRating(
                  widget.roomId, (rating * 2).toInt());
              setState(() {
                _userRating = rating;
              });
            },
          ),
        ],
      ),
    );
  }

  Widget buildReviewsList(TextTheme textTheme, List<RoomReview> reviews) {
    return Column(
      children: reviews
          .where((review) => review.comment != null)
          .map((review) => buildReviewCard(review, textTheme))
          .toList(),
    );
  }

  Widget buildReviewCard(RoomReview review, TextTheme textTheme) {
    String formattedDate =
        DateFormat('MMMM dd, yyyy, hh:mm a').format(review.createdAt);
    return SizedBox(
      width: double.infinity,
      child: Card(
        color: const Color(0xFF1A1A1A),
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Stack(
            children: [
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        review.userName,
                        style: textTheme.titleMedium
                            ?.copyWith(color: Colors.white),
                      ),
                      review.rating == null
                          ? Container()
                          : RatingBarIndicator(
                              rating: review.rating! / 2.0,
                              itemBuilder: (context, index) => const Icon(
                                Icons.star,
                                color: Color(0xffF00B51),
                              ),
                              itemCount: 5,
                              itemSize: 20.0,
                              direction: Axis.horizontal,
                            ),
                    ],
                  ),
                  const SizedBox(height: 8),
                  Text(
                    review.comment!,
                    style: textTheme.bodyLarge?.copyWith(color: Colors.white),
                  ),
                  Align(
                    alignment: Alignment.bottomRight,
                    child: Text(
                      formattedDate,
                      style: textTheme.bodyMedium?.copyWith(color: Colors.grey),
                    ),
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }
}
