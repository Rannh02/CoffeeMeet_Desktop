namespace POS_CofeeMeet
{
    partial class LoginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UserTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            PasswordTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            CancelButton = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jan_29__2026__07_02_41_PM;
            pictureBox1.Location = new Point(12, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(69, 40, 41);
            label1.Location = new Point(152, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 50);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // UserTxtBox
            // 
            UserTxtBox.Anchor = AnchorStyles.None;
            UserTxtBox.CustomizableEdges = customizableEdges1;
            UserTxtBox.DefaultText = "";
            UserTxtBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UserTxtBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UserTxtBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UserTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UserTxtBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UserTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserTxtBox.ForeColor = Color.Black;
            UserTxtBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UserTxtBox.IconLeft = Properties.Resources.user;
            UserTxtBox.IconLeftCursor = Cursors.Hand;
            UserTxtBox.IconRightCursor = Cursors.Hand;
            UserTxtBox.Location = new Point(65, 142);
            UserTxtBox.Name = "UserTxtBox";
            UserTxtBox.PlaceholderForeColor = Color.Black;
            UserTxtBox.PlaceholderText = "";
            UserTxtBox.SelectedText = "";
            UserTxtBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UserTxtBox.Size = new Size(206, 31);
            UserTxtBox.TabIndex = 2;
            UserTxtBox.TextChanged += UserTxtBox_TextChanged;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Anchor = AnchorStyles.None;
            PasswordTxtBox.CustomizableEdges = customizableEdges3;
            PasswordTxtBox.DefaultText = "";
            PasswordTxtBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTxtBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTxtBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTxtBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTxtBox.ForeColor = Color.Black;
            PasswordTxtBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTxtBox.IconLeft = Properties.Resources.key;
            PasswordTxtBox.IconLeftCursor = Cursors.Hand;
            PasswordTxtBox.IconRightCursor = Cursors.Hand;
            PasswordTxtBox.IconRightOffset = new Point(0, 1);
            PasswordTxtBox.Location = new Point(65, 190);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.PlaceholderForeColor = Color.Black;
            PasswordTxtBox.PlaceholderText = "";
            PasswordTxtBox.SelectedText = "";
            PasswordTxtBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTxtBox.Size = new Size(206, 31);
            PasswordTxtBox.TabIndex = 3;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BorderColor = Color.FromArgb(69, 40, 41);
            LoginButton.BorderRadius = 5;
            LoginButton.BorderThickness = 1;
            LoginButton.CustomizableEdges = customizableEdges5;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.FromArgb(232, 209, 197);
            LoginButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.FromArgb(69, 40, 41);
            LoginButton.HoverState.FillColor = Color.FromArgb(156, 140, 132);
            LoginButton.HoverState.ForeColor = Color.FromArgb(243, 232, 223);
            LoginButton.Location = new Point(65, 249);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LoginButton.Size = new Size(206, 29);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.Click += LoginButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.None;
            CancelButton.BorderRadius = 5;
            CancelButton.BorderThickness = 1;
            CancelButton.CustomizableEdges = customizableEdges7;
            CancelButton.DisabledState.BorderColor = Color.DarkGray;
            CancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancelButton.FillColor = Color.Red;
            CancelButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.FromArgb(235, 233, 231);
            CancelButton.HoverState.FillColor = Color.FromArgb(192, 0, 0);
            CancelButton.HoverState.ForeColor = Color.FromArgb(235, 233, 231);
            CancelButton.Location = new Point(65, 284);
            CancelButton.Name = "CancelButton";
            CancelButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            CancelButton.Size = new Size(206, 29);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 103);
            label2.Name = "label2";
            label2.Size = new Size(203, 16);
            label2.TabIndex = 6;
            label2.Text = "Welcome to Login form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 232);
            ClientSize = new Size(337, 325);
            Controls.Add(label2);
            Controls.Add(CancelButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UserTxtBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CofeeMeet Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox UserTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Label label2;
    }
}
