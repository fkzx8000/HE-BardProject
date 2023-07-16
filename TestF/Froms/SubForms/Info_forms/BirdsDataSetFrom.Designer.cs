namespace TestF.Forms.SubForms.Info_forms
{
    partial class BirdsDataSetFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.siteLOGO = new System.Windows.Forms.Label();
            this.BirdDataset = new System.Windows.Forms.DataGridView();
            this.Serial_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species_bird_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subspecies_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatch_date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bird_sex_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSerialNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSerialNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdDataset)).BeginInit();
            this.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(847, 80);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.exitBTN.Location = new System.Drawing.Point(817, 0);
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
            this.siteLOGO.Location = new System.Drawing.Point(315, 18);
            this.siteLOGO.Name = "siteLOGO";
            this.siteLOGO.Size = new System.Drawing.Size(250, 46);
            this.siteLOGO.TabIndex = 0;
            this.siteLOGO.Text = "מאגר ציפורים";
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
            this.BirdDataset.Location = new System.Drawing.Point(1, 83);
            this.BirdDataset.Name = "BirdDataset";
            this.BirdDataset.Size = new System.Drawing.Size(846, 413);
            this.BirdDataset.TabIndex = 4;
            this.BirdDataset.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BirdDataset_CellDoubleClick_1);
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
            // BirdsDataSetFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(847, 498);
            this.Controls.Add(this.BirdDataset);
            this.Controls.Add(this.panelTitleBar);
            this.MaximumSize = new System.Drawing.Size(863, 537);
            this.MinimumSize = new System.Drawing.Size(863, 537);
            this.Name = "BirdsDataSetFrom";
            this.Text = "InfoBirdsFrom";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdDataset)).EndInit();
            this.ResumeLayout(false);

        }

        private void BirdDataset_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label siteLOGO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BirdDataset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn species_bird_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn subspecies_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatch_date_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bird_sex_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageNumber_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSerialNumber_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSerialNumber_col;
    }
}