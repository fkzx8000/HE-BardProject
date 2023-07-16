namespace TestF.Forms.SubForms.Info_forms
{
    partial class CageDataSetFrom
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
            this.cageDataset = new System.Windows.Forms.DataGridView();
            this.Serial_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageDataset)).BeginInit();
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
            this.panelTitleBar.Size = new System.Drawing.Size(544, 80);
            this.panelTitleBar.TabIndex = 5;
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
            this.exitBTN.Location = new System.Drawing.Point(514, 0);
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
            this.siteLOGO.Location = new System.Drawing.Point(164, 18);
            this.siteLOGO.Name = "siteLOGO";
            this.siteLOGO.Size = new System.Drawing.Size(244, 46);
            this.siteLOGO.TabIndex = 0;
            this.siteLOGO.Text = "מאגר כלובים";
            // 
            // cageDataset
            // 
            this.cageDataset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cageDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cageDataset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_col,
            this.Length_col,
            this.width_col,
            this.height_col,
            this.material_col});
            this.cageDataset.Location = new System.Drawing.Point(0, 83);
            this.cageDataset.Name = "cageDataset";
            this.cageDataset.Size = new System.Drawing.Size(546, 379);
            this.cageDataset.TabIndex = 6;
            this.cageDataset.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CageDataset_CellDoubleClick);

            // 
            // Serial_col
            // 
            this.Serial_col.HeaderText = "מספר סידורי";
            this.Serial_col.Name = "Serial_col";
            // 
            // Length_col
            // 
            this.Length_col.HeaderText = "אורך";
            this.Length_col.Name = "Length_col";
            // 
            // width_col
            // 
            this.width_col.HeaderText = "רוחב";
            this.width_col.Name = "width_col";
            // 
            // height_col
            // 
            this.height_col.HeaderText = "גובה";
            this.height_col.Name = "height_col";
            // 
            // material_col
            // 
            this.material_col.HeaderText = "חומר";
            this.material_col.Name = "material_col";
            // 
            // CageDataSetFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(544, 461);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.cageDataset);
            this.MaximumSize = new System.Drawing.Size(560, 500);
            this.MinimumSize = new System.Drawing.Size(560, 500);
            this.Name = "CageDataSetFrom";
            this.Text = "CageDataSetFrom";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label siteLOGO;
        private System.Windows.Forms.DataGridView cageDataset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn width_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_col;
    }
}