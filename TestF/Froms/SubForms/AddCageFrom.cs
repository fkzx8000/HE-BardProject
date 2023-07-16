using System;
using System.Windows.Forms;
using TestF.files;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF.forms
{
    public partial class AddCageFrom : Form
    {

        // Constructor
        public AddCageFrom()
        {
            InitializeComponent();
        }

        // Event handler for the "cageNumber" click event
        private void cageNumber_Click(object sender, EventArgs e)
        {
            // Clear the text if it is set to "מספר כלוב"
            if (cageNumber.Texts == "מספר כלוב")
                cageNumber.Texts = String.Empty;
        }

        // Event handler for the "cageNumber" leave event
        private void cageNumber_Leave(object sender, EventArgs e)
        {
            // Restore the default text if the field is empty
            if (cageNumber.Texts == "")
                cageNumber.Texts = "מספר כלוב";
        }

        // Event handler for the "Length_box" click event
        private void Length_box_Click(object sender, EventArgs e)
        {
            // Clear the text if it is set to "אורך"
            if (Length_box.Texts == "אורך")
                Length_box.Texts = String.Empty;
        }

        // Event handler for the "Length_box" leave event
        private void Length_box_Leave(object sender, EventArgs e)
        {
            // Restore the default text if the field is empty
            if (Length_box.Texts == "")
                Length_box.Texts = "אורך";
        }

        // Event handler for the "width_box" leave event
        private void width_box_Leave(object sender, EventArgs e)
        {
            // Restore the default text if the field is empty
            if (width_box.Texts == "")
                width_box.Texts = "רוחב";
        }

        // Event handler for the "width_box" click event
        private void width_box_Click(object sender, EventArgs e)
        {
            // Clear the text if it is set to "רוחב"
            if (width_box.Texts == "רוחב")
                width_box.Texts = String.Empty;
        }

        // Event handler for the "height" click event
        private void height_Click(object sender, EventArgs e)
        {
            // Clear the text if it is set to "גובה"
            if (height.Texts == "גובה")
                height.Texts = String.Empty;
        }

        // Event handler for the "height" leave event
        private void height_Leave(object sender, EventArgs e)
        {
            // Restore the default text if the field is empty
            if (height.Texts == "")
                height.Texts = "גובה";
        }

        // Event handler for allowing only numeric input
        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters, block other input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        // Event handler for the "cageNumber" key press event
        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block input of characters other than letters and digits
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        // Event handler for the "BAddCage" button click event
        private void BAddCage_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the cage serial number
                ArgumentTest.TestCageSerial(cageNumber.Texts);

                // Validate the cage dimensions
                ArgumentTest.TestCageDimensions(width_box.Texts, Length_box.Texts, height.Texts);

                // Add the cage with the provided details
                FileControl.AddCage(cageNumber.Texts, width_box.Texts, Length_box.Texts, height.Texts, sexBirdBox.Texts);

                // Show a success message
                MessageBoxClass.CageSuccessfullyAdded(cageNumber.Texts);

                // Reset the input fields to their default values
                cageNumber.Texts = "מספר כלוב";
                Length_box.Texts = "אורך";
                width_box.Texts = "רוחב";
                height.Texts = "גובה";
                sexBirdBox.Texts = "             חומר הכלוב";
            }
            catch (SerialException)
            {
                // Show an error message for invalid cage serial number
                MessageBoxClass.CageSerialError();
                cageNumber.Texts = String.Empty;
            }
            catch (DimensionsException)
            {
                // Show an error message for invalid cage dimensions
                MessageBoxClass.CageDimensionsError();
            }
            catch (CageNumberTakenException)
            {
                // Show an error message for an already existing cage serial number
                MessageBoxClass.CageSerialExistsError(cageNumber.Texts);
            }
        }
    }
}
