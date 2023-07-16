namespace TestF.forms
{
    partial class BirdSearchFrom
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
            this.DateBirthBox = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.dynamic_serial_number = new TestF.UI.UItextbox();
            this.SubSpeciesBird = new TestF.UI.UIComboBox();
            this.SpeciesBird = new TestF.UI.UIComboBox();
            this.Search = new TestF.UI.UIBtu();
            this.sexBirdBox = new TestF.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // DateBirthBox
            // 
            this.DateBirthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateBirthBox.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.DateBirthBox.Location = new System.Drawing.Point(305, 293);
            this.DateBirthBox.Name = "DateBirthBox";
            this.DateBirthBox.Size = new System.Drawing.Size(200, 20);
            this.DateBirthBox.TabIndex = 26;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxDate.Location = new System.Drawing.Point(524, 285);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(144, 40);
            this.checkBoxDate.TabIndex = 27;
            this.checkBoxDate.Text = "האם לכלול את\r\n התאריך בחיפוש";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // dynamic_serial_number
            // 
            this.dynamic_serial_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dynamic_serial_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.dynamic_serial_number.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.dynamic_serial_number.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.dynamic_serial_number.BorderSize = 2;
            this.dynamic_serial_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dynamic_serial_number.ForeColor = System.Drawing.Color.Silver;
            this.dynamic_serial_number.Location = new System.Drawing.Point(299, 60);
            this.dynamic_serial_number.Margin = new System.Windows.Forms.Padding(4);
            this.dynamic_serial_number.Multiline = false;
            this.dynamic_serial_number.Name = "dynamic_serial_number";
            this.dynamic_serial_number.Padding = new System.Windows.Forms.Padding(7);
            this.dynamic_serial_number.PasswordChar = false;
            this.dynamic_serial_number.Size = new System.Drawing.Size(206, 31);
            this.dynamic_serial_number.TabIndex = 25;
            this.dynamic_serial_number.Texts = "מספר סידורי";
            this.dynamic_serial_number.UnderlinedStyle = true;
            this.dynamic_serial_number.Click += new System.EventHandler(this.SerialBox_Click);
            this.dynamic_serial_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialBox_KeyPress);
            this.dynamic_serial_number.Leave += new System.EventHandler(this.SerialBox_Leave);
            // 
            // SubSpeciesBird
            // 
            this.SubSpeciesBird.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubSpeciesBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.SubSpeciesBird.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.SubSpeciesBird.BorderSize = 1;
            this.SubSpeciesBird.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SubSpeciesBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SubSpeciesBird.ForeColor = System.Drawing.Color.Silver;
            this.SubSpeciesBird.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.SubSpeciesBird.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.SubSpeciesBird.ListTextColor = System.Drawing.Color.DimGray;
            this.SubSpeciesBird.Location = new System.Drawing.Point(305, 177);
            this.SubSpeciesBird.MinimumSize = new System.Drawing.Size(200, 30);
            this.SubSpeciesBird.Name = "SubSpeciesBird";
            this.SubSpeciesBird.Padding = new System.Windows.Forms.Padding(1);
            this.SubSpeciesBird.Size = new System.Drawing.Size(200, 30);
            this.SubSpeciesBird.TabIndex = 21;
            this.SubSpeciesBird.Texts = "תת זן";
            // 
            // SpeciesBird
            // 
            this.SpeciesBird.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeciesBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.SpeciesBird.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.SpeciesBird.BorderSize = 1;
            this.SpeciesBird.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SpeciesBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SpeciesBird.ForeColor = System.Drawing.Color.Silver;
            this.SpeciesBird.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.SpeciesBird.Items.AddRange(new object[] {
            "גולדיאן אוסטרלי",
            "גולדיאן אירופאי",
            "גולדיאן אמריקאי"});
            this.SpeciesBird.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.SpeciesBird.ListTextColor = System.Drawing.Color.DimGray;
            this.SpeciesBird.Location = new System.Drawing.Point(305, 117);
            this.SpeciesBird.MinimumSize = new System.Drawing.Size(200, 30);
            this.SpeciesBird.Name = "SpeciesBird";
            this.SpeciesBird.Padding = new System.Windows.Forms.Padding(1);
            this.SpeciesBird.Size = new System.Drawing.Size(200, 30);
            this.SpeciesBird.TabIndex = 20;
            this.SpeciesBird.Texts = "זן הציפור";
            this.SpeciesBird.OnSelectedIndexChanged += new System.EventHandler(this.SpeciesBird_OnSelectedIndexChanged);
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
            this.Search.Location = new System.Drawing.Point(305, 341);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 40);
            this.Search.TabIndex = 18;
            this.Search.Text = "חפש";
            this.Search.TextColor = System.Drawing.Color.White;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
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
            "זכר",
            "נקבה"});
            this.sexBirdBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.sexBirdBox.ListTextColor = System.Drawing.Color.DimGray;
            this.sexBirdBox.Location = new System.Drawing.Point(305, 237);
            this.sexBirdBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sexBirdBox.Name = "sexBirdBox";
            this.sexBirdBox.Padding = new System.Windows.Forms.Padding(1);
            this.sexBirdBox.Size = new System.Drawing.Size(200, 30);
            this.sexBirdBox.TabIndex = 17;
            this.sexBirdBox.Texts = "             מין הציפור";
            // 
            // BirdSearchFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(794, 481);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.DateBirthBox);
            this.Controls.Add(this.dynamic_serial_number);
            this.Controls.Add(this.SubSpeciesBird);
            this.Controls.Add(this.SpeciesBird);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.sexBirdBox);
            this.Name = "BirdSearchFrom";
            this.Text = "חיפוש ציפור";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI.UIComboBox sexBirdBox;
        private UI.UIBtu Search;
        private UI.UIComboBox SpeciesBird;
        private UI.UIComboBox SubSpeciesBird;
        private UI.UItextbox dynamic_serial_number;
        private System.Windows.Forms.DateTimePicker DateBirthBox;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}