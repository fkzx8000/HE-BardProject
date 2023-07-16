namespace TestF.Forms.SubForms.Info_forms
{
    partial class InfoCageFrom
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
            this.Static_material = new System.Windows.Forms.Label();
            this.Static_CageNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.siteLOGO = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.Static_size = new System.Windows.Forms.Label();
            this.BirdDataset = new System.Windows.Forms.DataGridView();
            this.Serial_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species_bird_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subspecies_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatch_date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bird_sex_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSerialNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSerialNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexBirdBox = new TestF.UI.UIComboBox();
            this.height_box = new TestF.UI.UItextbox();
            this.width_box = new TestF.UI.UItextbox();
            this.Length_box = new TestF.UI.UItextbox();
            this.Save_BTU = new TestF.UI.UIBtu();
            this.S_num = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirdDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // Static_material
            // 
            this.Static_material.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Static_material.AutoSize = true;
            this.Static_material.Font = new System.Drawing.Font("Guttman Haim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Static_material.Location = new System.Drawing.Point(593, 138);
            this.Static_material.Name = "Static_material";
            this.Static_material.Size = new System.Drawing.Size(68, 30);
            this.Static_material.TabIndex = 41;
            this.Static_material.Text = ":חומר";
            // 
            // Static_CageNumber
            // 
            this.Static_CageNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Static_CageNumber.AutoSize = true;
            this.Static_CageNumber.Font = new System.Drawing.Font("Guttman Haim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Static_CageNumber.Location = new System.Drawing.Point(593, 94);
            this.Static_CageNumber.Name = "Static_CageNumber";
            this.Static_CageNumber.Size = new System.Drawing.Size(143, 30);
            this.Static_CageNumber.TabIndex = 37;
            this.Static_CageNumber.Text = ":מספר כלוב";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 80);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TestF.Properties.Resources.לוגוTDD;
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitBTN
            // 
            this.exitBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitBTN.FlatAppearance.BorderSize = 0;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.Font = new System.Drawing.Font("Kristen ITC", 13F);
            this.exitBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBTN.Location = new System.Drawing.Point(774, 0);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(30, 30);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.Text = "O";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // siteLOGO
            // 
            this.siteLOGO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siteLOGO.AutoSize = true;
            this.siteLOGO.Font = new System.Drawing.Font("Guttman Haim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.siteLOGO.ForeColor = System.Drawing.Color.White;
            this.siteLOGO.Location = new System.Drawing.Point(303, 20);
            this.siteLOGO.Name = "siteLOGO";
            this.siteLOGO.Size = new System.Drawing.Size(268, 46);
            this.siteLOGO.TabIndex = 0;
            this.siteLOGO.Text = "מידע על כלוב";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.exitBTN);
            this.panelTitleBar.Controls.Add(this.siteLOGO);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(804, 80);
            this.panelTitleBar.TabIndex = 36;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // Static_size
            // 
            this.Static_size.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Static_size.AutoSize = true;
            this.Static_size.Font = new System.Drawing.Font("Guttman Haim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Static_size.Location = new System.Drawing.Point(593, 176);
            this.Static_size.Name = "Static_size";
            this.Static_size.Size = new System.Drawing.Size(145, 30);
            this.Static_size.TabIndex = 60;
            this.Static_size.Text = ":גודל הכלוב";
            // 
            // BirdDataset
            // 
            this.BirdDataset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BirdDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BirdDataset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_col,
            this.species_bird_col,
            this.subspecies_col,
            this.hatch_date_col,
            this.Bird_sex_col,
            this.cageNumber_col,
            this.FSerialNumber_col,
            this.MSerialNumber_col});
            this.BirdDataset.Location = new System.Drawing.Point(-46, 223);
            this.BirdDataset.Name = "BirdDataset";
            this.BirdDataset.Size = new System.Drawing.Size(846, 228);
            this.BirdDataset.TabIndex = 10;
            // 
            // Serial_col
            // 
            this.Serial_col.HeaderText = "מספר סידורי";
            this.Serial_col.Name = "Serial_col";
            // 
            // species_bird_col
            // 
            this.species_bird_col.HeaderText = "זן הציפור";
            this.species_bird_col.Name = "species_bird_col";
            // 
            // subspecies_col
            // 
            this.subspecies_col.HeaderText = "תת זן";
            this.subspecies_col.Name = "subspecies_col";
            // 
            // hatch_date_col
            // 
            this.hatch_date_col.HeaderText = "תאריך בקיעה";
            this.hatch_date_col.Name = "hatch_date_col";
            // 
            // Bird_sex_col
            // 
            this.Bird_sex_col.HeaderText = "מין הציפור";
            this.Bird_sex_col.Name = "Bird_sex_col";
            // 
            // cageNumber_col
            // 
            this.cageNumber_col.HeaderText = "מספר כלוב";
            this.cageNumber_col.Name = "cageNumber_col";
            // 
            // FSerialNumber_col
            // 
            this.FSerialNumber_col.HeaderText = "מספר סידורי אב";
            this.FSerialNumber_col.Name = "FSerialNumber_col";
            // 
            // MSerialNumber_col
            // 
            this.MSerialNumber_col.HeaderText = "מספר סידורי אם";
            this.MSerialNumber_col.Name = "MSerialNumber_col";
            // 
            // sexBirdBox
            // 
            this.sexBirdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexBirdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.sexBirdBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sexBirdBox.BorderSize = 1;
            this.sexBirdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.sexBirdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sexBirdBox.ForeColor = System.Drawing.Color.Silver;
            this.sexBirdBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sexBirdBox.Items.AddRange(new object[] {
            "ברזל",
            "עץ",
            "פלסטיק"});
            this.sexBirdBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.sexBirdBox.ListTextColor = System.Drawing.Color.DimGray;
            this.sexBirdBox.Location = new System.Drawing.Point(386, 138);
            this.sexBirdBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sexBirdBox.Name = "sexBirdBox";
            this.sexBirdBox.Padding = new System.Windows.Forms.Padding(1);
            this.sexBirdBox.Size = new System.Drawing.Size(200, 30);
            this.sexBirdBox.TabIndex = 65;
            this.sexBirdBox.Texts = "             חומר הכלוב";
            // 
            // height_box
            // 
            this.height_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.height_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.height_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.height_box.BorderFocusColor = System.Drawing.Color.LightSkyBlue;
            this.height_box.BorderSize = 2;
            this.height_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.height_box.ForeColor = System.Drawing.Color.Silver;
            this.height_box.Location = new System.Drawing.Point(386, 175);
            this.height_box.Margin = new System.Windows.Forms.Padding(4);
            this.height_box.Multiline = false;
            this.height_box.Name = "height_box";
            this.height_box.Padding = new System.Windows.Forms.Padding(7);
            this.height_box.PasswordChar = false;
            this.height_box.Size = new System.Drawing.Size(60, 31);
            this.height_box.TabIndex = 68;
            this.height_box.Texts = "גובה";
            this.height_box.UnderlinedStyle = true;
            this.height_box.Click += new System.EventHandler(this.height_box_Click);
            this.height_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            this.height_box.Leave += new System.EventHandler(this.height_box_Leave);
            // 
            // width_box
            // 
            this.width_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.width_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.width_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.width_box.BorderFocusColor = System.Drawing.Color.LightSkyBlue;
            this.width_box.BorderSize = 2;
            this.width_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width_box.ForeColor = System.Drawing.Color.Silver;
            this.width_box.Location = new System.Drawing.Point(439, 175);
            this.width_box.Margin = new System.Windows.Forms.Padding(4);
            this.width_box.Multiline = false;
            this.width_box.Name = "width_box";
            this.width_box.Padding = new System.Windows.Forms.Padding(7);
            this.width_box.PasswordChar = false;
            this.width_box.Size = new System.Drawing.Size(80, 31);
            this.width_box.TabIndex = 67;
            this.width_box.Texts = "רוחב";
            this.width_box.UnderlinedStyle = true;
            this.width_box.Click += new System.EventHandler(this.width_box_Click);
            this.width_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            this.width_box.Leave += new System.EventHandler(this.width_box_Leave);
            // 
            // Length_box
            // 
            this.Length_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Length_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Length_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Length_box.BorderFocusColor = System.Drawing.Color.LightSkyBlue;
            this.Length_box.BorderSize = 2;
            this.Length_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Length_box.ForeColor = System.Drawing.Color.Silver;
            this.Length_box.Location = new System.Drawing.Point(512, 175);
            this.Length_box.Margin = new System.Windows.Forms.Padding(4);
            this.Length_box.Multiline = false;
            this.Length_box.Name = "Length_box";
            this.Length_box.Padding = new System.Windows.Forms.Padding(7);
            this.Length_box.PasswordChar = false;
            this.Length_box.Size = new System.Drawing.Size(74, 31);
            this.Length_box.TabIndex = 66;
            this.Length_box.Texts = "אורך";
            this.Length_box.UnderlinedStyle = true;
            this.Length_box.Click += new System.EventHandler(this.Length_box_Click);
            this.Length_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            this.Length_box.Leave += new System.EventHandler(this.Length_box_Leave);
            // 
            // Save_BTU
            // 
            this.Save_BTU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Save_BTU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Save_BTU.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Save_BTU.BorderRadius = 20;
            this.Save_BTU.BorderSize = 0;
            this.Save_BTU.FlatAppearance.BorderSize = 0;
            this.Save_BTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_BTU.Font = new System.Drawing.Font("Guttman Haim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Save_BTU.ForeColor = System.Drawing.Color.DarkGray;
            this.Save_BTU.Location = new System.Drawing.Point(238, 108);
            this.Save_BTU.Name = "Save_BTU";
            this.Save_BTU.Size = new System.Drawing.Size(127, 84);
            this.Save_BTU.TabIndex = 69;
            this.Save_BTU.Text = "שמור";
            this.Save_BTU.TextColor = System.Drawing.Color.DarkGray;
            this.Save_BTU.UseVisualStyleBackColor = false;
            this.Save_BTU.Click += new System.EventHandler(this.Save_BTU_Click);
            // 
            // S_num
            // 
            this.S_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.S_num.AutoSize = true;
            this.S_num.Font = new System.Drawing.Font("Guttman Haim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.S_num.Location = new System.Drawing.Point(478, 98);
            this.S_num.Name = "S_num";
            this.S_num.Size = new System.Drawing.Size(108, 26);
            this.S_num.TabIndex = 70;
            this.S_num.Text = "00000000";
            // 
            // InfoCageFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.S_num);
            this.Controls.Add(this.Save_BTU);
            this.Controls.Add(this.height_box);
            this.Controls.Add(this.width_box);
            this.Controls.Add(this.Length_box);
            this.Controls.Add(this.sexBirdBox);
            this.Controls.Add(this.BirdDataset);
            this.Controls.Add(this.Static_size);
            this.Controls.Add(this.Static_material);
            this.Controls.Add(this.Static_CageNumber);
            this.Controls.Add(this.panelTitleBar);
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "InfoCageFrom";
            this.Text = "InfoCageFrom";
            this.Load += new System.EventHandler(this.InfoCageFrom_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirdDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Static_material;
        private System.Windows.Forms.Label Static_CageNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label siteLOGO;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label Static_size;
        private System.Windows.Forms.DataGridView BirdDataset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn species_bird_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn subspecies_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatch_date_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bird_sex_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageNumber_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSerialNumber_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSerialNumber_col;
        private UI.UIComboBox sexBirdBox;
        private UI.UItextbox height_box;
        private UI.UItextbox width_box;
        private UI.UItextbox Length_box;
        private UI.UIBtu Save_BTU;
        private System.Windows.Forms.Label S_num;
    }
}