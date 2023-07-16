using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestF.files;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF.forms
{
    public partial class InfoBirdFrom : Form
    {
        // Reference to the grandparent form (MianFrom), parent form (BirdSearchFrom), and BirdData object
        private MianFrom grandfather;
        private BirdSearchFrom fatherFrom;
        private BirdData MyBird;

        // Constructor to initialize the form and set references to the grandparent, parent, and BirdData object
        public InfoBirdFrom(MianFrom a, BirdSearchFrom f, BirdData bird)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            grandfather = a;
            fatherFrom = f;
            MyBird = bird;
        }

        // Utility method to get a random string from two input strings
        private static string GetRandomString(string str1, string str2)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            if (rand.Next(0, 1) == 0)
                return str1;
            return str2;
        }

        // Event handler for the Add_Btu (Add button) click event
        private void Add_Btu_Click(object sender, EventArgs e)
        {
            try
            {
                var rand = new Random(DateTime.Now.Millisecond);

                // Retrieve the second parent bird based on the provided serial number
                var secondParent = FileControl.GetBird().Where(b => b.Serial == serial_number_other.Texts).ToList();

                // Generate a random serial number for the new bird
                string serial = rand.Next(1000, 10000).ToString();
                while (FileControl.GetBird().Any(b => b.Serial == serial))
                {
                    serial = rand.Next(1000, 10000).ToString();
                }

                // Add the new bird to the file based on the parent's and current bird's data
                if (MyBird.Sex == "זכר")
                {
                    FileControl.AddBird(
                        serial,
                        GetRandomString(secondParent[0].SpeciesBird, MyBird.SpeciesBird),
                        GetRandomString(secondParent[0].SubSpeciesBird, MyBird.SubSpeciesBird),
                        GetRandomString(secondParent[0].Sex, MyBird.Sex),
                        MyBird.Serial, secondParent[0].Serial,
                        GetRandomString(secondParent[0].CageNumber, MyBird.CageNumber), DateTime.Now.ToString("dd/MM/yyyy"));
                }
                else
                {
                    FileControl.AddBird(
                          serial,
                          GetRandomString(secondParent[0].SpeciesBird, MyBird.SpeciesBird),
                          GetRandomString(secondParent[0].SubSpeciesBird, MyBird.SubSpeciesBird),
                          GetRandomString(secondParent[0].Sex, MyBird.Sex),
                          secondParent[0].Serial, MyBird.Serial,
                          GetRandomString(secondParent[0].CageNumber, MyBird.CageNumber), DateTime.Now.ToString("dd/MM/yyyy"));
                }

                MessageBoxClass.BirdSuccessfullyAdded(serial);
                this.Close();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Pleas select second parent", "Error");
            }
        }

        // Event handlers for various text boxes and combo boxes to handle placeholder text and dynamic behavior

        private void dynamic_cage_number_Click(object sender, EventArgs e)
        {
            if (dynamic_cage_number.Texts == "מספר הכלוב")
                dynamic_cage_number.Texts = String.Empty;
        }

        private void dynamic_cage_number_Leave(object sender, EventArgs e)
        {
            if (dynamic_cage_number.Texts == "")
                dynamic_cage_number.Texts = "מספר הכלוב";
        }

        // Similar event handlers for other text boxes and combo boxes...

        // Event handler for the Save_Btu (Save button) click event
        private void Save_Btu_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the cage serial number
                ArgumentTest.TestCageSerial(dynamic_cage_number.Texts);

                // Update the bird's record with the new data
                FileControl.EditBirdRecord(S_num.Text, species_bird_dynamicc.Texts, subspeciess_dynamic.Texts, dynamic_sex_bird.Texts, dynamic_F_serial_number.Text, dynamic_M_serial_number.Text, dynamic_cage_number.Texts, dynamic_date.Text);
                MessageBoxClass.BirdSuccessfullyAdded(S_num.Text);

                this.Close();
            }
            catch (CageMissingException)
            {
                MessageBoxClass.CageSerialMissingError();
            }
            catch (SerialException)
            {
                MessageBoxClass.CageSerialError();
                dynamic_cage_number.Texts = String.Empty;
            }
        }

        // Other event handlers for form loading, button clicks, mouse events, etc.

    }
}
