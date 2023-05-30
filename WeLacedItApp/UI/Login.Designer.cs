namespace WeLacedItApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelUsername = new Label();
            panel2 = new Panel();
            labelPassword = new Label();
            panel3 = new Panel();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonSignIn = new Button();
            usernameLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)usernameLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.Control;
            labelUsername.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(55, 182);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(118, 23);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(19, 226);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 2);
            panel2.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.Control;
            labelPassword.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(55, 247);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 23);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(19, 296);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(385, 2);
            panel3.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.Control;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(19, 208);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.RightToLeft = RightToLeft.No;
            textBoxUsername.Size = new Size(385, 15);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Control;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(19, 278);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(385, 15);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(192, 211, 254);
            buttonSignIn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignIn.ForeColor = Color.Black;
            buttonSignIn.Location = new Point(132, 322);
            buttonSignIn.Margin = new Padding(3, 2, 3, 2);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(146, 40);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // usernameLogo
            // 
            usernameLogo.Image = (Image)resources.GetObject("usernameLogo.Image");
            usernameLogo.Location = new Point(19, 176);
            usernameLogo.Margin = new Padding(3, 2, 3, 2);
            usernameLogo.Name = "usernameLogo";
            usernameLogo.Size = new Size(31, 26);
            usernameLogo.SizeMode = PictureBoxSizeMode.Zoom;
            usernameLogo.TabIndex = 7;
            usernameLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 242);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(376, 247);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(422, 123);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 398);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(usernameLogo);
            Controls.Add(buttonSignIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(panel3);
            Controls.Add(labelPassword);
            Controls.Add(panel2);
            Controls.Add(labelUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "We Laced It";
            ((System.ComponentModel.ISupportInitialize)usernameLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUsername;
        private Panel panel2;
        private Label labelPassword;
        private Panel panel3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonSignIn;
        private PictureBox usernameLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLogo;
    }
}