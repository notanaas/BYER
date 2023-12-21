namespace Project
{
    partial class Addmovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmovie));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.photoDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Dat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.boxMovies = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 756);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(1110, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.UseWaitCursor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 704);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(768, 52);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.UseWaitCursor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picMovie
            // 
            this.picMovie.BackColor = System.Drawing.Color.Transparent;
            this.picMovie.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picMovie.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMovie.Location = new System.Drawing.Point(768, 165);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(342, 591);
            this.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovie.TabIndex = 15;
            this.picMovie.TabStop = false;
            this.picMovie.Tag = "";
            this.picMovie.UseWaitCursor = true;
            this.picMovie.Click += new System.EventHandler(this.picMovie_Click);
            // 
            // photoDialog
            // 
            this.photoDialog.FileName = "openFileDialog1";
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnPhoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhoto.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.btnPhoto.ForeColor = System.Drawing.Color.Transparent;
            this.btnPhoto.Location = new System.Drawing.Point(0, 624);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(768, 40);
            this.btnPhoto.TabIndex = 27;
            this.btnPhoto.Text = "&Browse for a photo";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.UseWaitCursor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDate.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.txtDate.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDate.Location = new System.Drawing.Point(163, 224);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(158, 24);
            this.txtDate.TabIndex = 39;
            this.txtDate.UseWaitCursor = true;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dateTimePicker1.CustomFormat = "ddd dd/MM/yyyy  hh : mm ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 274);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 30);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // Dat
            // 
            this.Dat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dat.AutoSize = true;
            this.Dat.BackColor = System.Drawing.Color.Black;
            this.Dat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Dat.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Dat.ForeColor = System.Drawing.Color.White;
            this.Dat.Location = new System.Drawing.Point(10, 224);
            this.Dat.Name = "Dat";
            this.Dat.Size = new System.Drawing.Size(82, 24);
            this.Dat.TabIndex = 36;
            this.Dat.Text = "Date/Day";
            this.Dat.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Movie Name";
            this.label1.UseWaitCursor = true;
            // 
            // txtMovie
            // 
            this.txtMovie.BackColor = System.Drawing.Color.White;
            this.txtMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovie.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtMovie.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.txtMovie.ForeColor = System.Drawing.Color.White;
            this.txtMovie.Location = new System.Drawing.Point(163, 188);
            this.txtMovie.Multiline = true;
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(158, 30);
            this.txtMovie.TabIndex = 32;
            this.txtMovie.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.Location = new System.Drawing.Point(0, 664);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(768, 40);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // boxMovies
            // 
            this.boxMovies.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.boxMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxMovies.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boxMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxMovies.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.boxMovies.ForeColor = System.Drawing.Color.Transparent;
            this.boxMovies.FormattingEnabled = true;
            this.boxMovies.ItemHeight = 33;
            this.boxMovies.Location = new System.Drawing.Point(0, 0);
            this.boxMovies.Name = "boxMovies";
            this.boxMovies.Size = new System.Drawing.Size(1110, 165);
            this.boxMovies.Sorted = true;
            this.boxMovies.TabIndex = 20;
            this.boxMovies.UseWaitCursor = true;
            this.boxMovies.SelectedIndexChanged += new System.EventHandler(this.boxMovies_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "Available movies";
            this.label7.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(625, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 40);
            this.label4.TabIndex = 44;
            this.label4.Text = "CINEMA";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(417, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 40);
            this.label5.TabIndex = 43;
            this.label5.Text = "VIP";
            this.label5.UseWaitCursor = true;
            // 
            // Addmovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 796);
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.picMovie);
            this.Controls.Add(this.boxMovies);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Addmovie";
            this.ShowIcon = false;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Addmovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.OpenFileDialog photoDialog;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Dat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ListBox boxMovies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}