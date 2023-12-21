using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class seatsData : Form
    {
        private readonly string connectionString = @"Data Source=localhost;Initial Catalog=movie;Integrated Security=True";
        private string selectedMovie;
        int remainingSeats;

        public seatsData(string movieName, int seats)
        {
            InitializeComponent();
            selectedMovie = movieName;
            remainingSeats = seats;
        }

        private void seatsData_Load(object sender, EventArgs e)
        {
            LoadRemainingSeats();
            GenerateSeatButtons();
        }

        private void GenerateSeatButtons()
        {
            const int seatButtonWidth = 40;
            const int seatButtonHeight = 40;
            const int seatButtonMargin = 5;

            int seatNumber = 1;

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    Button seatButton = new Button();
                    seatButton.Text = seatNumber.ToString();
                    seatButton.Width = seatButtonWidth;
                    seatButton.Height = seatButtonHeight;
                    seatButton.Margin = new Padding(seatButtonMargin);
                    seatButton.Click += SeatButton_Click;

                    flowLayoutPanel1.Controls.Add(seatButton);

                    seatNumber++;
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            int seatNumber = int.Parse(seatButton.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO ReservedSeats (SeatNumber, MovieName) VALUES (@SeatNumber, @MovieName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SeatNumber", seatNumber);
                command.Parameters.AddWithValue("@MovieName", selectedMovie);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    seatButton.BackColor = Color.Red;
                    seatButton.Enabled = false;

                    remainingSeats--;
                    UpdateRemainingSeatsLabel();

                }

            }
        }

    

    private void LoadRemainingSeats()
        {
            lblSeats.Text = $"Remaining Seats: {remainingSeats}";
        }

        private void UpdateRemainingSeatsLabel()
        {
            lblSeats.Text = $"Remaining Seats: {remainingSeats}";
        }

        public int RemainingSeats
        {
            get { return remainingSeats; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            userPage bb = new userPage();
            bb.Show();
            this.Hide();
        }
    }
}
