using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class userOradmin : Form
    {
        public object Interaction { get; private set; }

        public userOradmin()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            userPage userPage = new userPage();
            userPage.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtPass.Visible = true;
            lblPass.Visible = true;
            btnPass.Visible = true;            
        }

        private void userOradmin_Load(object sender, EventArgs e)
        {
            txtPass.Visible = false;
            lblPass.Visible = false;
            btnPass.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string pass = "1234";

            if(txtPass.Text == pass)
            {
                Addmovie addmovie = new Addmovie();
                addmovie.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password");

            }
        }
    }
}
