namespace TestF.Forms.MineForms
{
    partial class RegistrarFrom
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
            this.Fill_panel = new System.Windows.Forms.Panel();
            this.ID_Box = new TestF.UI.UItextbox();
            this.loginBtu = new TestF.UI.UIBtu();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasswordBox = new TestF.UI.UItextbox();
            this.UserNameBox = new TestF.UI.UItextbox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.GoBack = new System.Windows.Forms.Button();
            this.BtuMiniSize = new System.Windows.Forms.Button();
            this.BtuMaxSize = new System.Windows.Forms.Button();
            this.exitBtu = new System.Windows.Forms.Button();
            this.Fill_panel.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fill_panel
            // 
            this.Fill_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Fill_panel.Controls.Add(this.ID_Box);
            this.Fill_panel.Controls.Add(this.loginBtu);
            this.Fill_panel.Controls.Add(this.textBox1);
            this.Fill_panel.Controls.Add(this.PasswordBox);
            this.Fill_panel.Controls.Add(this.UserNameBox);
            this.Fill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill_panel.Location = new System.Drawing.Point(0, 0);
            this.Fill_panel.Name = "Fill_panel";
            this.Fill_panel.Size = new System.Drawing.Size(664, 511);
            this.Fill_panel.TabIndex = 10;
            // 
            // ID_Box
            // 
            this.ID_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ID_Box.BorderColor = System.Drawing.Color.DarkGray;
            this.ID_Box.BorderFocusColor = System.Drawing.Color.PaleTurquoise;
            this.ID_Box.BorderSize = 2;
            this.ID_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID_Box.ForeColor = System.Drawing.Color.DimGray;
            this.ID_Box.Location = new System.Drawing.Point(215, 290);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(4);
            this.ID_Box.Multiline = false;
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Padding = new System.Windows.Forms.Padding(7);
            this.ID_Box.PasswordChar = false;
            this.ID_Box.Size = new System.Drawing.Size(250, 31);
            this.ID_Box.TabIndex = 9;
            this.ID_Box.Texts = "ID";
            this.ID_Box.UnderlinedStyle = true;
            this.ID_Box.Click += new System.EventHandler(this.ID_Box_Click);
            this.ID_Box.Leave += new System.EventHandler(this.ID_Box_Leave);
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
            this.loginBtu.Location = new System.Drawing.Point(278, 340);
            this.loginBtu.Name = "loginBtu";
            this.loginBtu.Size = new System.Drawing.Size(126, 40);
            this.loginBtu.TabIndex = 6;
            this.loginBtu.Text = "הרשם";
            this.loginBtu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtu.UseVisualStyleBackColor = false;
            this.loginBtu.Click += new System.EventHandler(this.loginBtu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.GoBack);
            this.panelTitleBar.Controls.Add(this.BtuMiniSize);
            this.panelTitleBar.Controls.Add(this.BtuMaxSize);
            this.panelTitleBar.Controls.Add(this.exitBtu);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(664, 76);
            this.panelTitleBar.TabIndex = 11;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // GoBack
            // 
            this.GoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.GoBack.FlatAppearance.BorderSize = 0;
            this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack.Image = global::TestF.Properties.Resources.חץ_אחורה;
            this.GoBack.Location = new System.Drawing.Point(0, 0);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(70, 76);
            this.GoBack.TabIndex = 13;
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
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
            // RegistrarFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Fill_panel);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "RegistrarFrom";
            this.Text = "הרשמה";
            this.Fill_panel.ResumeLayout(false);
            this.Fill_panel.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fill_panel;
        private UI.UIBtu loginBtu;
        private System.Windows.Forms.TextBox textBox1;
        private UI.UItextbox PasswordBox;
        private UI.UItextbox UserNameBox;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button BtuMiniSize;
        private System.Windows.Forms.Button BtuMaxSize;
        private System.Windows.Forms.Button exitBtu;
        private UI.UItextbox ID_Box;
        private System.Windows.Forms.Button GoBack;
    }
}