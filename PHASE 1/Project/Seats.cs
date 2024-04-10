using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Seats : Form
    {
        public Seats(string selectedMovie)
        {
            InitializeComponent();
        }

        public class seats
        {
            public static int movieSeats { get; set; } = 40;
        }

        string connectionString = @"Data Source=localhost;Initial Catalog=movie;Integrated Security=True";

        private void Seats_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            userPage back = new userPage();
            back.Show();
            this.Hide();
        }

        private void btnSeat1_Click(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat1.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();

            }

        }

        private void btnSeat2_Click(object sender, EventArgs e)
        {


            seats.movieSeats = seats.movieSeats - 1;
            btnSeat2.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();

            }


        }

        private void btnSeat3_Click(object sender, EventArgs e)
        {


            seats.movieSeats = seats.movieSeats - 1;
            btnSeat3.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();

            }

        }

        private void btnSeat4_Click(object sender, EventArgs e)
        {
            seats.movieSeats = seats.movieSeats - 1;
            btnSeat4.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();

            }

        }

        private void btnSeat5_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat5.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();

            }
        }

        private void btnSeat6_Click_1(object sender, EventArgs e)
        {
            seats.movieSeats = seats.movieSeats - 1;
            btnSeat6.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();

            }




        }

        private void btnSeat7_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat7.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }
        }

        private void btnSeat8_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat8.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }
        }
        private void btnSeat9_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat9.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat10_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat10.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat11_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat11.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat12_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat12.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }



        }

        private void btnSeat13_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat13.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat14_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat13.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }



        }

        private void btnSeat15_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat14.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat16_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat15.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat17_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat16.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat18_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat17.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat19_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat18.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat20_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat19.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat21_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat20.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat22_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat21.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat23_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat22.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat24_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat23.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat25_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat24.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat26_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat25.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }


        private void btnSeat27_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat26.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat28_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat27.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat29_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat28.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat30_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat29.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat31_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat30.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat32_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat31.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat33_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat32.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat34_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat32.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat35_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat33.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat36_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat34.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat37_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat35.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);

                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat38_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat36.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);
                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat39_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat37.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);
                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();


            }


        }

        private void btnSeat40_Click_1(object sender, EventArgs e)
        {

            seats.movieSeats = seats.movieSeats - 1;
            btnSeat38.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE movieInfo SET movieSeats = @movieSeats";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@movieSeats", seats.movieSeats);
                cmd.ExecuteNonQuery();
                lblSeats.Text = seats.movieSeats.ToString();
            }
        }

        
    }
}
