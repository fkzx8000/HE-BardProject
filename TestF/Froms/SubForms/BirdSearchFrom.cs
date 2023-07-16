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
        private MianFrom fatherFrom;

        // Constructor
        public BirdSearchFrom(MianFrom a)
        {
            InitializeComponent();
            fatherFrom = a;
        }

        // Event handler for the "Search" button click event
        private void Search_Click(object sender, EventArgs e)
        {
            // Get bird data based on search criteria
            var data = Getlist(dynamic_serial_number.Texts, SpeciesBird.Texts, SubSpeciesBird.Texts, sexBirdBox.Texts, DateBirthBox.Value.ToString());

            if (data.Count == 1)
            {
                // If only one bird is found, open the bird information form
                InfoBirdFrom from = new InfoBirdFrom(fatherFrom, this, data[0]);
                from.ShowDialog();
            }
            else
            {
                // If multiple birds are found or no search criteria is specified, open the bird dataset form
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

        // Event handler for the "SerialBox" click event
        private void SerialBox_Click(object sender, EventArgs e)
        {
            // Clear the text if it is set to "מספר סידורי"
            if (dynamic_serial_number.Texts == "מספר סידורי")
                dynamic_serial_number.Texts = String.Empty;
        }

        // Event handler for the "SerialBox" leave event
        private void SerialBox_Leave(object sender, EventArgs e)
        {
            // Restore the default text if the field is empty
            if (dynamic_serial_number.Texts == "")
                dynamic_serial_number.Texts = "מספר סידורי";
        }

        // Event handler for the "SpeciesBird" selected index changed event
        private void SpeciesBird_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the default text and populate the sub-species list based on the selected species
            SubSpeciesBird.Texts = "תת זן";
            SubSpeciesBird.Items.Clear();

            if (SpeciesBird.Texts == "גולדיאן אוסטרלי")
                SubSpeciesBird.Items.AddRange(new object[] { "מרכז אוסטרליה", "ערי חוף" });

            if (SpeciesBird.Texts == "גולדיאן אירופאי")
                SubSpeciesBird.Items.AddRange(new object[] { "מזרח אירופה", "מערב אירופה" });

            if (SpeciesBird.Texts == "גולדיאן אמריקאי")
                SubSpeciesBird.Items.AddRange(new object[] { "צפון אמריקה", "מרכז אמריקה", "דרום אמריקה" });
        }

        // Event handler for the "SerialBox" key press event
        private void SerialBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters, display an error message for other characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        // Helper method to filter bird data based on search criteria
        private static List<BirdData> Getlist(string serialNumber, string species, string subSpecies, string sex, string date)
        {
            return FileControl.GetBird().Where(b => b.Serial == serialNumber || b.SpeciesBird == species || b.SubSpeciesBird == subSpecies || b.Sex == sex || b.ExpirationDate == date).ToList();
        }
    }
}
