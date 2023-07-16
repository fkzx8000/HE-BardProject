namespace TestF
{
    partial class LoginFrom
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BtuMiniSize = new System.Windows.Forms.Button();
            this.BtuMaxSize = new System.Windows.Forms.Button();
            this.exitBtu = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.Fill_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtuRegistrar = new TestF.UI.UIBtu();
            this.loginBtu = new TestF.UI.UIBtu();
            this.PasswordBox = new TestF.UI.UItextbox();
            this.UserNameBox = new TestF.UI.UItextbox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.Fill_panel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.panelLogo);
            this.panelTitleBar.Controls.Add(this.BtuMiniSize);
            this.panelTitleBar.Controls.Add(this.BtuMaxSize);
            this.panelTitleBar.Controls.Add(this.exitBtu);
            this.panelTitleBar.Controls.Add(this.LogoBox);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(664, 76);
            this.panelTitleBar.TabIndex = 8;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // BtuMiniSize
            // 
            this.BtuMiniSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtuMiniSize.FlatAppearance.BorderSize = 0;
            this.BtuMiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtuMiniSize.Font = new System.Drawing.Font("Kristen ITC", 13F);
            this.BtuMiniSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtuMiniSize.Location = new System.Drawing.Point(571, 3);
            this.BtuMiniSize.Name = "BtuMiniSize";
            this.BtuMiniSize.Size = new System.Drawing.Size(30, 30);
            this.BtuMiniSize.TabIndex = 11;
            this.BtuMiniSize.Text = "O";
            this.BtuMiniSize.UseVisualStyleBackColor = true;
            this.BtuMiniSize.Click += new System.EventHandler(this.BtuMiniSize_Click);
            // 
            // BtuMaxSize
            // 
            this.BtuMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtuMaxSize.FlatAppearance.BorderSize = 0;
            this.BtuMaxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtuMaxSize.Font = new System.Drawing.Font("Kristen ITC", 13F);
            this.BtuMaxSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtuMaxSize.Location = new System.Drawing.Point(601, 3);
            this.BtuMaxSize.Name = "BtuMaxSize";
            this.BtuMaxSize.Size = new System.Drawing.Size(30, 30);
            this.BtuMaxSize.TabIndex = 10;
            this.BtuMaxSize.Text = "O";
            this.BtuMaxSize.UseVisualStyleBackColor = true;
            this.BtuMaxSize.Click += new System.EventHandler(this.BtuMaxSize_Click);
            // 
            // exitBtu
            // 
            this.exitBtu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtu.FlatAppearance.BorderSize = 0;
            this.exitBtu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtu.Font = new System.Drawing.Font("Kristen ITC", 13F);
            this.exitBtu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtu.Location = new System.Drawing.Point(631, 3);
            this.exitBtu.Name = "exitBtu";
            this.exitBtu.Size = new System.Drawing.Size(30, 30);
            this.exitBtu.TabIndex = 9;
            this.exitBtu.Text = "O";
            this.exitBtu.UseVisualStyleBackColor = true;
            this.exitBtu.Click += new System.EventHandler(this.exitBtu_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::TestF.Properties.Resources.logoLogin;
            this.LogoBox.Location = new System.Drawing.Point(22, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(123, 57);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // Fill_panel
            // 
            this.Fill_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Fill_panel.Controls.Add(this.BtuRegistrar);
            this.Fill_panel.Controls.Add(this.loginBtu);
            this.Fill_panel.Controls.Add(this.textBox1);
            this.Fill_panel.Controls.Add(this.PasswordBox);
            this.Fill_panel.Controls.Add(this.UserNameBox);
            this.Fill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill_panel.Location = new System.Drawing.Point(0, 0);
            this.Fill_panel.Name = "Fill_panel";
            this.Fill_panel.Size = new System.Drawing.Size(664, 511);
            this.Fill_panel.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // BtuRegistrar
            // 
            this.BtuRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtuRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtuRegistrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtuRegistrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtuRegistrar.BorderRadius = 20;
            this.BtuRegistrar.BorderSize = 0;
            this.BtuRegistrar.FlatAppearance.BorderSize = 0;
            this.BtuRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtuRegistrar.Font = new System.Drawing.Font("Guttman Hatzvi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtuRegistrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtuRegistrar.Location = new System.Drawing.Point(22, 444);
            this.BtuRegistrar.Name = "BtuRegistrar";
            this.BtuRegistrar.Size = new System.Drawing.Size(126, 40);
            this.BtuRegistrar.TabIndex = 7;
            this.BtuRegistrar.Text = "הרשם";
            this.BtuRegistrar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtuRegistrar.UseVisualStyleBackColor = false;
            this.BtuRegistrar.Click += new System.EventHandler(this.BtuRegistrar_Click);
            // 
            // loginBtu
            // 
            this.loginBtu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.loginBtu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.loginBtu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtu.BorderRadius = 20;
            this.loginBtu.BorderSize = 0;
            this.loginBtu.FlatAppearance.BorderSize = 0;
            this.loginBtu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtu.Font = new System.Drawing.Font("Guttman Hatzvi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginBtu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtu.Location = new System.Drawing.Point(278, 300);
            this.loginBtu.Name = "loginBtu";
            this.loginBtu.Size = new System.Drawing.Size(126, 40);
            this.loginBtu.TabIndex = 6;
            this.loginBtu.Text = "התחבר";
            this.loginBtu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtu.UseVisualStyleBackColor = false;
            this.loginBtu.Click += new System.EventHandler(this.loginBtu_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PasswordBox.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordBox.BorderFocusColor = System.Drawing.Color.PaleTurquoise;
            this.PasswordBox.BorderSize = 2;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PasswordBox.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordBox.Location = new System.Drawing.Point(215, 240);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Multiline = false;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordBox.PasswordChar = true;
            this.PasswordBox.Size = new System.Drawing.Size(250, 31);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.Texts = "password";
            this.PasswordBox.UnderlinedStyle = true;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.UserNameBox.BorderColor = System.Drawing.Color.DarkGray;
            this.UserNameBox.BorderFocusColor = System.Drawing.Color.PaleTurquoise;
            this.UserNameBox.BorderSize = 2;
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UserNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.UserNameBox.Location = new System.Drawing.Point(215, 190);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameBox.Multiline = false;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Padding = new System.Windows.Forms.Padding(7);
            this.UserNameBox.PasswordChar = false;
            this.UserNameBox.Size = new System.Drawing.Size(250, 31);
            this.UserNameBox.TabIndex = 4;
            this.UserNameBox.Texts = "username";
            this.UserNameBox.UnderlinedStyle = true;
            this.UserNameBox.Click += new System.EventHandler(this.UserNameBox_Click);
            this.UserNameBox.Leave += new System.EventHandler(this.UserNameBox_Leave);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(146, 76);
            this.panelLogo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TestF.Properties.Resources.logoLogin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Fill_panel);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "LoginFrom";
            this.Text = "Form1";
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.Fill_panel.ResumeLayout(false);
            this.Fill_panel.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion


        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button BtuMiniSize;
        private System.Windows.Forms.Button BtuMaxSize;
        private System.Windows.Forms.Button exitBtu;
        private System.Windows.Forms.Panel Fill_panel;
        private UI.UIBtu BtuRegistrar;
        private UI.UIBtu loginBtu;
        private System.Windows.Forms.TextBox textBox1;
        private UI.UItextbox PasswordBox;
        private UI.UItextbox UserNameBox;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

