using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Project
{
    public partial class Addmovie : Form
    {
        public Addmovie()
        {
            InitializeComponent();


        }
        string connectionString = @"Data Source=localhost;Initial Catalog=movie;Integrated Security=True";


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime currentDate = DateTime.Today;

            if (selectedDate < currentDate)
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            string movieName = txtMovie.Text;
            string movieDate = txtDate.Text;
            Image movieImage = picMovie.Image;

            if (movieImage == null || string.IsNullOrWhiteSpace(movieDate) || string.IsNullOrWhiteSpace(movieName))
            {
                MessageBox.Show("Please make sure all information is filled.");
                return;
            }

            if (IsMovieNameExists(movieName, connectionString))
            {
                MessageBox.Show("Movie name already exists in the database.", "Error");
                return;
            }

            if (IsMovieDateExists(movieDate, connectionString))
            {
                MessageBox.Show("A movie is already scheduled for the selected date.", "Error");
                return;
            }

            // Convert the movie image to byte array
            byte[] imageBytes = ImageToByteArray(movieImage);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO movieInfo (movieName, movieDate, movieImage) VALUES (@movieName, @movieDate, @movieImage)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@movieName", movieName);
                command.Parameters.AddWithValue("@movieDate", movieDate);
                command.Parameters.AddWithValue("@movieImage", imageBytes);

                command.ExecuteNonQuery();

                MessageBox.Show("Movie added successfully.", "Success");
            }
        }

        private bool IsMovieDateExists(string movieDate, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM movieInfo WHERE movieDate = @movieDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@movieDate", movieDate);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }


        private bool IsMovieNameExists(string movieName, string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM movieInfo WHERE movieName = @movieName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@movieName", movieName);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
    }

    private byte[] ImageToByteArray(Image image)
    {

        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE from movieInfo WHERE movieName = @movieName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@movieName", txtMovie.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Movie deleted !");
                }
                else
                {
                    MessageBox.Show("Movie not forund");
                }


            }
            txtDate.Text = "";
            txtMovie.Text = "";
            picMovie.Image = null;

        }

        private void Addmovie_Load(object sender, EventArgs e)
        {
            
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            userOradmin userPage = new userOradmin();
            userPage.Show();
            this.Hide();
        }
    
       

       

        private void boxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMovie = boxMovies.SelectedItem?.ToString();

            if (selectedMovie == null)
            {
                MessageBox.Show("No available movies");
            }
            else 
            { 
            string query = "SELECT movieName, movieDate, movieImage FROM movieInfo WHERE movieName = @MovieName";
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

                            txtMovie.Text = movieName;
                            txtDate.Text = movieDate;
                        }
                        else
                        {
                            picMovie.Image = null;
                            txtMovie.Text = "No Movie Found";
                            txtDate.Text = string.Empty;

                        }
                    }
                }
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog photoDialog = new OpenFileDialog();
            photoDialog.FileName = "";
            photoDialog.Filter = "Support Images|*.jpg;*.jpeg;*.png";
            if (photoDialog.ShowDialog() == DialogResult.OK)
            {
                picMovie.Load(photoDialog.FileName);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePicker1.Text;

        }

        private void picMovie_Click(object sender, EventArgs e)
        {

        }
    }
 }

