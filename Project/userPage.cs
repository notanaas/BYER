using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static Project.Seats;
using static Project.drinksAndSnacks;


namespace Project
{
    public partial class userPage : Form
    {
        double totalprice;
        double tickets = seats.movieSeats;
        double priceds = drinksandsnacks.priceSnacks;
        string selectedMovie;
       // int remainingSeats;
        public userPage()
        {
            InitializeComponent();

        }
        string connectionString = @"Data Source=localhost;Initial Catalog=movie;Integrated Security=True";



        private void picMovie_Click_1(object sender, EventArgs e)
        {
            Seats bb = new Seats(selectedMovie);
            bb.Show();
            this.Hide();
        }

        private void btnDrink2_Click(object sender, EventArgs e)
        {
            drinksAndSnacks dd = new drinksAndSnacks();
            dd.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            userOradmin back = new userOradmin();
            back.Show();
            this.Hide();
        }



        private void userPage_Load(object sender, EventArgs e)
        {
            

                tickets = (tickets-40) * 12;
                totalprice = totalprice + tickets + priceds;
                lblTotal.Text = totalprice.ToString("c");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT movieName FROM movieInfo";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string movieName = reader["movieName"].ToString();
                            boxMovies.Items.Add(movieName);
                        }
                    }
                    else
                    {
                        boxMovies.Items.Add("No movies found");
                    }
                }
            }

        }

        private void boxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMovie = boxMovies.SelectedItem?.ToString();

            if (selectedMovie == null)
            {
                MessageBox.Show("No available movies");
            }
            else
            {
                string query = "SELECT movieName, movieDate, movieImage, movieSeats FROM movieInfo WHERE movieName = @MovieName";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MovieName", selectedMovie);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            byte[] imageBytes = reader["movieImage"] as byte[];
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);
                                    picMovie.Image = image;
                                }
                            }
                            else
                            {
                                picMovie.Image = null;
                            }

                            string movieName = reader["movieName"].ToString();
                            string movieDate = reader["movieDate"].ToString();
                            string movieSeat = reader["movieSeats"].ToString();

                            txtDate.Text = movieDate;
                            txtSeats.Text = movieSeat;
                        }
                        else
                        {
                            picMovie.Image = null;
                            txtDate.Text = string.Empty;
                            txtSeats.Text = "";

                        }
                    }
                }

            }
        }

        private void txtSeats_Click(object sender, EventArgs e)
        {

        }
    }

}











