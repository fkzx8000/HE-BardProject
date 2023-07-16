namespace TestF.forms
{
    partial class CageSearchFrom
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
            this.cageNumber = new TestF.UI.UItextbox();
            this.sexBirdBox = new TestF.UI.UIComboBox();
            this.Search = new TestF.UI.UIBtu();
            this.SuspendLayout();
            // 
            // cageNumber
            // 
            this.cageNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cageNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.cageNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cageNumber.BorderSize = 2;
            this.cageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cageNumber.ForeColor = System.Drawing.Color.Silver;
            this.cageNumber.Location = new System.Drawing.Point(305, 143);
            this.cageNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cageNumber.Multiline = false;
            this.cageNumber.Name = "cageNumber";
            this.cageNumber.Padding = new System.Windows.Forms.Padding(7);
            this.cageNumber.PasswordChar = false;
            this.cageNumber.Size = new System.Drawing.Size(200, 31);
            this.cageNumber.TabIndex = 25;
            this.cageNumber.Texts = "מספר כלוב";
            this.cageNumber.UnderlinedStyle = true;
            this.cageNumber.Click += new System.EventHandler(this.cageNumber_Click);
            this.cageNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cageNumber_KeyPress);
            this.cageNumber.Leave += new System.EventHandler(this.cageNumber_Leave);
            // 
            // sexBirdBox
            // 
            this.sexBirdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexBirdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.sexBirdBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.sexBirdBox.BorderSize = 1;
            this.sexBirdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.sexBirdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sexBirdBox.ForeColor = System.Drawing.Color.Silver;
            this.sexBirdBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.sexBirdBox.Items.AddRange(new object[] {
            "ברזל",
            "עץ",
            "פלסטיק"});
            this.sexBirdBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.sexBirdBox.ListTextColor = System.Drawing.Color.DimGray;
            this.sexBirdBox.Location = new System.Drawing.Point(305, 203);
            this.sexBirdBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sexBirdBox.Name = "sexBirdBox";
            this.sexBirdBox.Padding = new System.Windows.Forms.Padding(1);
            this.sexBirdBox.Size = new System.Drawing.Size(200, 30);
            this.sexBirdBox.TabIndex = 24;
            this.sexBirdBox.Texts = "             חומר הכלוב";
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.Search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Search.BorderRadius = 20;
            this.Search.BorderSize = 0;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Guttman Haim-Condensed", 21.75F);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(305, 263);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 40);
            this.Search.TabIndex = 23;
            this.Search.Text = "חפש";
            this.Search.TextColor = System.Drawing.Color.White;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CageSearchFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(794, 481);
            this.Controls.Add(this.cageNumber);
            this.Controls.Add(this.sexBirdBox);
            this.Controls.Add(this.Search);
            this.Name = "CageSearchFrom";
            this.Text = "חיפוש כלוב";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UIBtu Search;
        private UI.UIComboBox sexBirdBox;
        private UI.UItextbox cageNumber;
    }
}