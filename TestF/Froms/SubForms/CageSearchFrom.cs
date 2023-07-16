using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestF.Forms.SubForms.Info_forms;

namespace TestF.forms
{
    public partial class CageSearchFrom : Form
    {
        private MianFrom fatherFrom;

        // Constructor
        public CageSearchFrom(MianFrom main)
        {
            InitializeComponent();
            fatherFrom = main;
        }

        // Event handler for the "Search" button click event
        private void Search_Click(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "מספר כלוב" && sexBirdBox.Texts == "             חומר הכלוב")
            {
                // If no search criteria is specified, open the cage dataset form
                CageDataSetFrom from = new CageDataSetFrom(fatherFrom, this);
                from.ShowDialog();
            }
            else
            {
                // If search criteria is specified, open the cage dataset form with the specified criteria
                CageDataSetFrom from = new CageDataSetFrom(fatherFrom, this, cageNumber.Texts, sexBirdBox.Texts);
                from.ShowDialog();
            }
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

        // Event handler for the "cageNumber" key press event
        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters and digits, block other characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
