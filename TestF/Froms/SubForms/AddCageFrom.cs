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
        //TODO: דף להוספת כלובים
        /*-----אפשרות להוסיף כלוב חדש---------
         * 
         * 
         * 1. מספר סידורי – אותיות וספרות
         * 
         * 2.אורך, רוחב וגובה- רק מספרים
         * 
         * 3. חומר – ברזל / עץ / פלסטיק
         *     _____
         * 4. -= - =- מוסיף לקובץ
         * 
         * 
         */
        //ctor
        public AddCageFrom()            {InitializeComponent();}

        //----- שינוים בתיבות כתיבה-----

        private void cageNumber_Click(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "מספר כלוב")
                cageNumber.Texts = String.Empty;
        }

        private void cageNumber_Leave(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "")
                cageNumber.Texts = "מספר כלוב";
        }

        private void Length_box_Click(object sender, EventArgs e)
        {
            if (Length_box.Texts == "אורך")
                Length_box.Texts = String.Empty;
        }

        private void Length_box_Leave(object sender, EventArgs e)
        {
            if (Length_box.Texts == "")
                Length_box.Texts = "אורך";
        }

        private void width_box_Leave(object sender, EventArgs e)
        {
            if (width_box.Texts == "")
                width_box.Texts = "רוחב";
        }

        private void width_box_Click(object sender, EventArgs e)
        {
            if (width_box.Texts == "רוחב")
                width_box.Texts = String.Empty;
        }

        private void height_Click(object sender, EventArgs e)
        {
            if (height.Texts == "גובה")
                height.Texts = String.Empty;
        }

        private void height_Leave(object sender, EventArgs e)
        {
            if (height.Texts == "")
                height.Texts = "גובה";
        }

        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void BAddCage_Click(object sender, EventArgs e)
        {
            try
            {
                ArgumentTest.TestCageSerial(cageNumber.Texts);
                ArgumentTest.TestCageDimensions(width_box.Texts, Length_box.Texts, height.Texts);

                FileControl.AddCage(cageNumber.Texts, width_box.Texts, Length_box.Texts, height.Texts, sexBirdBox.Texts);

                MessageBoxClass.CageSuccessfullyAdded(cageNumber.Texts);

                cageNumber.Texts = "מספר כלוב";
                Length_box.Texts = "אורך";
                width_box.Texts = "רוחב";
                height.Texts = "גובה";
                sexBirdBox.Texts = "             חומר הכלוב";
            }
            catch (SerialException)
            {
                MessageBoxClass.CageSerialError();
                cageNumber.Texts = String.Empty;
            }
            catch (DimensionsException)
            {
                MessageBoxClass.CageDimensionsError();
            }
            catch (CageNumberTakenException)
            {
                MessageBoxClass.CageSerialExistsError(cageNumber.Texts);
            }
        }
    }
}
