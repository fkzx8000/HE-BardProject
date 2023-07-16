using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestF.files;
using TestF.Forms.SubForms.Info_forms;
using TestF.logic;
using TestF.logic.DataAndFile;

namespace TestF.forms
{
    public partial class BirdSearchFrom : Form
    {
        //TODO: זה דף החיפוש ציפור

        /* ********** אפשרות חיפוש ציפור לפי מספר סידורי / זן / תאריך בקיעה / מין כל מצב בנפרד ***********
         * 
         * 1. במקרה של תוצאה אחת – להציג את הציפור הספציפית
         * 
         * 2. במקרה של מספר תוצאות – להציג רשימה ממוינת לפי מספר ציפור
         * 
         * 3. במקרה של לחיצה על ציפור ספציפית בטבלה נעבור לדף הספציפי שלה
         */

        //filde
        private MianFrom fatherFrom;
        //ctor
        public BirdSearchFrom(MianFrom a)
        {
            InitializeComponent();
            fatherFrom = a;
        }


        //----------------כפתורי חיפוש----------------------------
        private void Search_Click(object sender, EventArgs e)
        {
            var data = Getlist(dynamic_serial_number.Texts, SpeciesBird.Texts, SubSpeciesBird.Texts, sexBirdBox.Texts, DateBirthBox.Value.ToString());
            if (data.Count == 1)
            {
                InfoBirdFrom from = new InfoBirdFrom(fatherFrom, this, data[0]);
                from.ShowDialog();

            }
            else
            {
                data = FileControl.GetBird();


                if ((dynamic_serial_number.Texts == "מספר סידורי") && sexBirdBox.Texts == "             מין הציפור" && !checkBoxDate.Checked && SpeciesBird.Texts == "זן הציפור")
                {
                    BirdsDataSetFrom from = new BirdsDataSetFrom(fatherFrom, this, data);
                    from.ShowDialog();
                }
                else
                {
                    if (checkBoxDate.Checked)
                    {
                        //BirdsDataSetFrom from = new BirdsDataSetFrom(dynamic_serial_number.Texts, ArgumentFix.SpeciesBirdFix(SpeciesBird.Texts), ArgumentFix.SubspeciesBirdFix(SubSpeciesBird.Texts), ArgumentFix.SexFix(sexBirdBox.Texts), ArgumentFix.DateFix(DateBirthBox.Value.ToString()));
                        BirdsDataSetFrom from = new BirdsDataSetFrom(fatherFrom, this, data, dynamic_serial_number.Texts, SpeciesBird.Texts, SubSpeciesBird.Texts, sexBirdBox.Texts, DateBirthBox.Value.ToString("dd/MM/yyyy"));
                        from.ShowDialog();

                    }
                    else
                    {
                        BirdsDataSetFrom from = new BirdsDataSetFrom(fatherFrom, this, data, dynamic_serial_number.Texts, SpeciesBird.Texts, SubSpeciesBird.Texts, sexBirdBox.Texts);
                        from.ShowDialog();

                    }
                }
            }



        }



        //----- ניקוי תבות-----

        private void SerialBox_Click(object sender, EventArgs e)
        {
            if (dynamic_serial_number.Texts == "מספר סידורי")
                dynamic_serial_number.Texts = String.Empty;
        }

        private void SerialBox_Leave(object sender, EventArgs e)
        {
            if (dynamic_serial_number.Texts == "")
                dynamic_serial_number.Texts = "מספר סידורי";
        }





        //--------- תלות תת זן בזן---------------

        private void SpeciesBird_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            SubSpeciesBird.Texts = "תת זן";
            SubSpeciesBird.Items.Clear();
            if (SpeciesBird.Texts == "גולדיאן אוסטרלי")
                SubSpeciesBird.Items.AddRange(new object[] { "מרכז אוסטרליה", "ערי חוף" });

            if (SpeciesBird.Texts == "גולדיאן אירופאי")
                SubSpeciesBird.Items.AddRange(new object[] { "מזרח אירופה", "מערב אירופה" });

            if (SpeciesBird.Texts == "גולדיאן אמריקאי")
                SubSpeciesBird.Items.AddRange(new object[] { "צפון אמריקה", "מרכז אמריקה", "דרום אמריקה" });
        }

        private void SerialBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }


        private static List<BirdData> Getlist(string serialNumber, string species, string subSpecies, string sex, string date)
        {
            return FileControl.GetBird().Where(b => b.Serial == serialNumber || b.SpeciesBird == species || b.SubSpeciesBird == subSpecies || b.Sex == sex || b.ExpirationDate == date).ToList();
        }



    }
}
