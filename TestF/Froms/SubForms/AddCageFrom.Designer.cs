namespace TestF.forms
{
    partial class AddCageFrom
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
            this.width_box = new TestF.UI.UItextbox();
            this.Length_box = new TestF.UI.UItextbox();
            this.cageNumber = new TestF.UI.UItextbox();
            this.height = new TestF.UI.UItextbox();
            this.sexBirdBox = new TestF.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBtu1 = new TestF.UI.UIBtu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // width_box
            // 
            this.width_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.width_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.width_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.width_box.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.width_box.BorderSize = 2;
            this.width_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width_box.ForeColor = System.Drawing.Color.Silver;
            this.width_box.Location = new System.Drawing.Point(318, 150);
            this.width_box.Margin = new System.Windows.Forms.Padding(4);
            this.width_box.Multiline = false;
            this.width_box.Name = "width_box";
            this.width_box.Padding = new System.Windows.Forms.Padding(7);
            this.width_box.PasswordChar = false;
            this.width_box.Size = new System.Drawing.Size(194, 31);
            this.width_box.TabIndex = 17;
            this.width_box.Texts = "רוחב";
            this.width_box.UnderlinedStyle = true;
            this.width_box.Click += new System.EventHandler(this.width_box_Click);
            this.width_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly);
            this.width_box.Leave += new System.EventHandler(this.width_box_Leave);
            // 
            // Length_box
            // 
            this.Length_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Length_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Length_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.Length_box.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.Length_box.BorderSize = 2;
            this.Length_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Length_box.ForeColor = System.Drawing.Color.Silver;
            this.Length_box.Location = new System.Drawing.Point(508, 150);
            this.Length_box.Margin = new System.Windows.Forms.Padding(4);
            this.Length_box.Multiline = false;
            this.Length_box.Name = "Length_box";
            this.Length_box.Padding = new System.Windows.Forms.Padding(7);
            this.Length_box.PasswordChar = false;
            this.Length_box.Size = new System.Drawing.Size(194, 31);
            this.Length_box.TabIndex = 16;
            this.Length_box.Texts = "אורך";
            this.Length_box.UnderlinedStyle = true;
            this.Length_box.Click += new System.EventHandler(this.Length_box_Click);
            this.Length_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly);
            this.Length_box.Leave += new System.EventHandler(this.Length_box_Leave);
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
            this.cageNumber.Location = new System.Drawing.Point(318, 50);
            this.cageNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cageNumber.Multiline = false;
            this.cageNumber.Name = "cageNumber";
            this.cageNumber.Padding = new System.Windows.Forms.Padding(7);
            this.cageNumber.PasswordChar = false;
            this.cageNumber.Size = new System.Drawing.Size(194, 31);
            this.cageNumber.TabIndex = 15;
            this.cageNumber.Texts = "מספר כלוב";
            this.cageNumber.UnderlinedStyle = true;
            this.cageNumber.Click += new System.EventHandler(this.cageNumber_Click);
            this.cageNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cageNumber_KeyPress);
            this.cageNumber.Leave += new System.EventHandler(this.cageNumber_Leave);
            // 
            // height
            // 
            this.height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.height.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.height.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.height.BorderSize = 2;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.height.ForeColor = System.Drawing.Color.Silver;
            this.height.Location = new System.Drawing.Point(128, 150);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Multiline = false;
            this.height.Name = "height";
            this.height.Padding = new System.Windows.Forms.Padding(7);
            this.height.PasswordChar = false;
            this.height.Size = new System.Drawing.Size(194, 31);
            this.height.TabIndex = 18;
            this.height.Texts = "גובה";
            this.height.UnderlinedStyle = true;
            this.height.Click += new System.EventHandler(this.height_Click);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly);
            this.height.Leave += new System.EventHandler(this.height_Leave);
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
            this.sexBirdBox.Location = new System.Drawing.Point(312, 230);
            this.sexBirdBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sexBirdBox.Name = "sexBirdBox";
            this.sexBirdBox.Padding = new System.Windows.Forms.Padding(1);
            this.sexBirdBox.Size = new System.Drawing.Size(200, 30);
            this.sexBirdBox.TabIndex = 19;
            this.sexBirdBox.Texts = "             חומר הכלוב";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Guttman Haim-Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "גודל הכלוב";
            // 
            // uiBtu1
            // 
            this.uiBtu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiBtu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.uiBtu1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.uiBtu1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.uiBtu1.BorderRadius = 20;
            this.uiBtu1.BorderSize = 0;
            this.uiBtu1.FlatAppearance.BorderSize = 0;
            this.uiBtu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtu1.Font = new System.Drawing.Font("Guttman Haim-Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uiBtu1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiBtu1.Location = new System.Drawing.Point(340, 310);
            this.uiBtu1.Name = "uiBtu1";
            this.uiBtu1.Size = new System.Drawing.Size(150, 40);
            this.uiBtu1.TabIndex = 21;
            this.uiBtu1.Text = "הוסף כלוב";
            this.uiBtu1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiBtu1.UseVisualStyleBackColor = false;
            this.uiBtu1.Click += new System.EventHandler(this.BAddCage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(340, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 43);
            this.panel1.TabIndex = 22;
            // 
            // AddCageFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiBtu1);
            this.Controls.Add(this.sexBirdBox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width_box);
            this.Controls.Add(this.Length_box);
            this.Controls.Add(this.cageNumber);
            this.Controls.Add(this.panel1);
            this.Name = "AddCageFrom";
            this.Text = "הוספת כלוב";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UItextbox width_box;
        private UI.UItextbox Length_box;
        private UI.UItextbox cageNumber;
        private UI.UItextbox height;
        private UI.UIComboBox sexBirdBox;
        private System.Windows.Forms.Label label1;
        private UI.UIBtu uiBtu1;
        private System.Windows.Forms.Panel panel1;
    }
}