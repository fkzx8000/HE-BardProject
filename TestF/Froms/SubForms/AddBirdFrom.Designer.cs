namespace TestF.forms
{
    partial class AddBirdFrom
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
            this.FSerialNumber = new TestF.UI.UIComboBox();
            this.MSerialNumber = new TestF.UI.UIComboBox();
            this.ttzan = new TestF.UI.UIComboBox();
            this.zan = new TestF.UI.UIComboBox();
            this.Search = new TestF.UI.UIBtu();
            this.sexBirdBox = new TestF.UI.UIComboBox();
            this.SerialBox = new TestF.UI.UItextbox();
            this.cageNumber = new TestF.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // DateBirthBox
            // 
            this.DateBirthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateBirthBox.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.DateBirthBox.Location = new System.Drawing.Point(215, 235);
            this.DateBirthBox.Name = "DateBirthBox";
            this.DateBirthBox.Size = new System.Drawing.Size(200, 20);
            this.DateBirthBox.TabIndex = 15;
            this.DateBirthBox.Value = new System.DateTime(2023, 5, 10, 23, 2, 9, 0);
            // 
            // FSerialNumber
            // 
            this.FSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.FSerialNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.FSerialNumber.BorderSize = 1;
            this.FSerialNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.FSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FSerialNumber.ForeColor = System.Drawing.Color.Silver;
            this.FSerialNumber.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.FSerialNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.FSerialNumber.ListTextColor = System.Drawing.Color.DimGray;
            this.FSerialNumber.Location = new System.Drawing.Point(326, 73);
            this.FSerialNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.FSerialNumber.Name = "FSerialNumber";
            this.FSerialNumber.Padding = new System.Windows.Forms.Padding(1);
            this.FSerialNumber.Size = new System.Drawing.Size(200, 30);
            this.FSerialNumber.TabIndex = 23;
            this.FSerialNumber.Texts = "מספר סידורי אם";
            // 
            // MSerialNumber
            // 
            this.MSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.MSerialNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.MSerialNumber.BorderSize = 1;
            this.MSerialNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.MSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MSerialNumber.ForeColor = System.Drawing.Color.Silver;
            this.MSerialNumber.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.MSerialNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.MSerialNumber.ListTextColor = System.Drawing.Color.DimGray;
            this.MSerialNumber.Location = new System.Drawing.Point(326, 134);
            this.MSerialNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.MSerialNumber.Name = "MSerialNumber";
            this.MSerialNumber.Padding = new System.Windows.Forms.Padding(1);
            this.MSerialNumber.Size = new System.Drawing.Size(200, 30);
            this.MSerialNumber.TabIndex = 22;
            this.MSerialNumber.Texts = "מספר סידורי אב";
            // 
            // ttzan
            // 
            this.ttzan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ttzan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ttzan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.ttzan.BorderSize = 1;
            this.ttzan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ttzan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ttzan.ForeColor = System.Drawing.Color.Silver;
            this.ttzan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.ttzan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ttzan.ListTextColor = System.Drawing.Color.DimGray;
            this.ttzan.Location = new System.Drawing.Point(101, 134);
            this.ttzan.MinimumSize = new System.Drawing.Size(200, 30);
            this.ttzan.Name = "ttzan";
            this.ttzan.Padding = new System.Windows.Forms.Padding(1);
            this.ttzan.Size = new System.Drawing.Size(200, 30);
            this.ttzan.TabIndex = 21;
            this.ttzan.Texts = "             תת זן";
            // 
            // zan
            // 
            this.zan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.zan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.zan.BorderSize = 1;
            this.zan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.zan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zan.ForeColor = System.Drawing.Color.Silver;
            this.zan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.zan.Items.AddRange(new object[] {
            "גולדיאן אמריקאי",
            "גולדיאן אירופאי",
            "גולדיאן אוסטרלי"});
            this.zan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.zan.ListTextColor = System.Drawing.Color.DimGray;
            this.zan.Location = new System.Drawing.Point(101, 73);
            this.zan.MinimumSize = new System.Drawing.Size(200, 30);
            this.zan.Name = "zan";
            this.zan.Padding = new System.Windows.Forms.Padding(1);
            this.zan.Size = new System.Drawing.Size(200, 30);
            this.zan.TabIndex = 20;
            this.zan.Texts = "             זן הציפור";
            this.zan.OnSelectedIndexChanged += new System.EventHandler(this.zan_OnSelectedIndexChanged);
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
            this.Search.Location = new System.Drawing.Point(215, 279);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 40);
            this.Search.TabIndex = 19;
            this.Search.Text = "הוסף ציפור";
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
            this.sexBirdBox.Location = new System.Drawing.Point(215, 186);
            this.sexBirdBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sexBirdBox.Name = "sexBirdBox";
            this.sexBirdBox.Padding = new System.Windows.Forms.Padding(1);
            this.sexBirdBox.Size = new System.Drawing.Size(200, 30);
            this.sexBirdBox.TabIndex = 9;
            this.sexBirdBox.Texts = "             מין הציפור";
            // 
            // SerialBox
            // 
            this.SerialBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.SerialBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.SerialBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.SerialBox.BorderSize = 2;
            this.SerialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SerialBox.ForeColor = System.Drawing.Color.Silver;
            this.SerialBox.Location = new System.Drawing.Point(101, 13);
            this.SerialBox.Margin = new System.Windows.Forms.Padding(4);
            this.SerialBox.Multiline = false;
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Padding = new System.Windows.Forms.Padding(7);
            this.SerialBox.PasswordChar = false;
            this.SerialBox.Size = new System.Drawing.Size(194, 31);
            this.SerialBox.TabIndex = 4;
            this.SerialBox.Texts = "מספר סידורי";
            this.SerialBox.UnderlinedStyle = true;
            this.SerialBox.Click += new System.EventHandler(this.SerialBox_Click);
            this.SerialBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly);
            this.SerialBox.Leave += new System.EventHandler(this.SerialBox_Leave);
            // 
            // cageNumber
            // 
            this.cageNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cageNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.cageNumber.BorderSize = 1;
            this.cageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cageNumber.ForeColor = System.Drawing.Color.Silver;
            this.cageNumber.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.cageNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cageNumber.ListTextColor = System.Drawing.Color.DimGray;
            this.cageNumber.Location = new System.Drawing.Point(326, 14);
            this.cageNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.cageNumber.Name = "cageNumber";
            this.cageNumber.Padding = new System.Windows.Forms.Padding(1);
            this.cageNumber.Size = new System.Drawing.Size(200, 30);
            this.cageNumber.TabIndex = 24;
            this.cageNumber.Texts = "מספר כלוב";
            // 
            // AddBirdFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(639, 361);
            this.Controls.Add(this.cageNumber);
            this.Controls.Add(this.FSerialNumber);
            this.Controls.Add(this.MSerialNumber);
            this.Controls.Add(this.ttzan);
            this.Controls.Add(this.zan);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DateBirthBox);
            this.Controls.Add(this.sexBirdBox);
            this.Controls.Add(this.SerialBox);
            this.Name = "AddBirdFrom";
            this.Text = "הוספת ציפור";
            this.Load += new System.EventHandler(this.AddBirdFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UI.UItextbox SerialBox;
        private UI.UIComboBox sexBirdBox;
        private System.Windows.Forms.DateTimePicker DateBirthBox;
        private UI.UIBtu Search;
        private UI.UIComboBox zan;
        private UI.UIComboBox ttzan;
        private UI.UIComboBox MSerialNumber;
        private UI.UIComboBox FSerialNumber;
        private UI.UIComboBox cageNumber;
    }
}