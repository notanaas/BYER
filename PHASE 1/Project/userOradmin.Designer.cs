namespace Project
{
    partial class userOradmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userOradmin));
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.Black;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Font = new System.Drawing.Font("MS Gothic", 25F, System.Drawing.FontStyle.Italic);
            this.btnUser.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUser.Location = new System.Drawing.Point(0, -1);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(138, 66);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "USER";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("MS Gothic", 25F, System.Drawing.FontStyle.Italic);
            this.btnAdmin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.Location = new System.Drawing.Point(780, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(140, 65);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.btnExit.ForeColor = System.Drawing.Color.DarkGray;
            this.btnExit.Location = new System.Drawing.Point(0, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(920, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.DarkGray;
            this.txtPass.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Italic);
            this.txtPass.Location = new System.Drawing.Point(389, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(164, 27);
            this.txtPass.TabIndex = 4;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Black;
            this.lblPass.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Italic);
            this.lblPass.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPass.Location = new System.Drawing.Point(144, 9);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(239, 20);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Please enter password :";
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Black;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPass.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Italic);
            this.btnPass.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPass.Location = new System.Drawing.Point(575, 2);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(158, 27);
            this.btnPass.TabIndex = 6;
            this.btnPass.Text = "Check Password";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
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
            this.label5.Location = new System.Drawing.Point(239, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 40);
            this.label5.TabIndex = 34;
            this.label5.Text = "VIP";
            this.label5.UseWaitCursor = true;
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
            this.label4.Location = new System.Drawing.Point(510, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 40);
            this.label4.TabIndex = 35;
            this.label4.Text = " CINEMA";
            this.label4.UseWaitCursor = true;
            // 
            // userOradmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 484);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUser);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userOradmin";
            this.Text = "user Or Admin";
            this.Load += new System.EventHandler(this.userOradmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdmin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnPass;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}