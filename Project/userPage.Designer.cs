namespace Project
{
    partial class userPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPage));
            this.boxMovies = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.movieInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataSet = new Project.movieDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDrink2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.labelMovieDate = new System.Windows.Forms.Label();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.movieInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieInfoTableAdapter = new Project.movieDataSetTableAdapters.movieInfoTableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.txtSeats = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMovies
            // 
            this.boxMovies.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.boxMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.boxMovies, "boxMovies");
            this.boxMovies.ForeColor = System.Drawing.Color.White;
            this.boxMovies.FormattingEnabled = true;
            this.boxMovies.Name = "boxMovies";
            this.boxMovies.UseWaitCursor = true;
            this.boxMovies.SelectedIndexChanged += new System.EventHandler(this.boxMovies_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.label3.UseWaitCursor = true;
            // 
            // movieInfoBindingSource1
            // 
            this.movieInfoBindingSource1.DataMember = "movieInfo";
            this.movieInfoBindingSource1.DataSource = this.movieDataSet;
            // 
            // movieDataSet
            // 
            this.movieDataSet.DataSetName = "movieDataSet";
            this.movieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            this.label11.UseWaitCursor = true;
            // 
            // btnDrink2
            // 
            this.btnDrink2.BackColor = System.Drawing.Color.Transparent;
            this.btnDrink2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.btnDrink2, "btnDrink2");
            this.btnDrink2.ForeColor = System.Drawing.Color.White;
            this.btnDrink2.Name = "btnDrink2";
            this.btnDrink2.UseVisualStyleBackColor = false;
            this.btnDrink2.UseWaitCursor = true;
            this.btnDrink2.Click += new System.EventHandler(this.btnDrink2_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            this.label9.UseWaitCursor = true;
            // 
            // lblSeats
            // 
            this.lblSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblSeats.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblSeats, "lblSeats");
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.UseWaitCursor = true;
            // 
            // labelMovieDate
            // 
            this.labelMovieDate.BackColor = System.Drawing.Color.Transparent;
            this.labelMovieDate.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.labelMovieDate, "labelMovieDate");
            this.labelMovieDate.Name = "labelMovieDate";
            this.labelMovieDate.UseWaitCursor = true;
            // 
            // labelMovieName
            // 
            this.labelMovieName.BackColor = System.Drawing.Color.Transparent;
            this.labelMovieName.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.labelMovieName, "labelMovieName");
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            // 
            // movieInfoBindingSource
            // 
            this.movieInfoBindingSource.DataMember = "movieInfo";
            this.movieInfoBindingSource.DataSource = this.movieDataSet;
            // 
            // movieInfoTableAdapter
            // 
            this.movieInfoTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.UseWaitCursor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.UseWaitCursor = true;
            // 
            // picMovie
            // 
            this.picMovie.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picMovie, "picMovie");
            this.picMovie.Name = "picMovie";
            this.picMovie.TabStop = false;
            this.picMovie.UseWaitCursor = true;
            this.picMovie.Click += new System.EventHandler(this.picMovie_Click_1);
            // 
            // txtSeats
            // 
            resources.ApplyResources(this.txtSeats, "txtSeats");
            this.txtSeats.BackColor = System.Drawing.Color.Transparent;
            this.txtSeats.ForeColor = System.Drawing.Color.White;
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.UseWaitCursor = true;
            this.txtSeats.Click += new System.EventHandler(this.txtSeats_Click);
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Name = "txtDate";
            this.txtDate.UseWaitCursor = true;
            // 
            // userPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.picMovie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDrink2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxMovies);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMovieDate);
            this.Controls.Add(this.labelMovieName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "userPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.userPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelMovieDate;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.ListBox boxMovies;
        private movieDataSet movieDataSet;
        private System.Windows.Forms.BindingSource movieInfoBindingSource;
        private movieDataSetTableAdapters.movieInfoTableAdapter movieInfoTableAdapter;
        private System.Windows.Forms.BindingSource movieInfoBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDrink2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.Label txtSeats;
        private System.Windows.Forms.Label txtDate;
    }
}