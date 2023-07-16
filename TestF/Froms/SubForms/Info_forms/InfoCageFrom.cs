using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestF.files;
using TestF.forms;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF.Forms.SubForms.Info_forms
{
    public partial class InfoCageFrom : Form
    {
        // Reference to the grandparent form (MianFrom), parent form (CageSearchFrom), and CageData object
        private MianFrom grandfather;
        private CageSearchFrom fatherFrom;
        private CageData Cage;

        // Constructor to initialize the form and set references to the grandparent, parent, and CageData object
        public InfoCageFrom(MianFrom main, CageSearchFrom searchForm, CageData data)
        {
            InitializeComponent();
            grandfather = main;
            fatherFrom = searchForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Cage = data;
        }

        // Event handlers for text boxes to handle placeholder text behavior

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

        // Similar event handlers for other text boxes...

        // External function imports for capturing mouse events and moving the form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Event handler for mouse down event on the panelTitleBar to enable moving the form

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Event handlers for button clicks and form loading

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters and digits for the cage number
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void OnlyNum(object sender, KeyPressEventArgs e)
        {
            // Allow only digits for certain input fields, display an error message for letters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        // Event handler for form loading

        private void InfoCageFrom_Load(object sender, EventArgs e)
        {
            // Retrieve a list of birds associated with the cage
            var birdList = FileControl.GetBird().Where(bird => bird.CageNumber == Cage.CageNumber).ToList();

            // Sort the bird list and populate the DataGridView with bird data
            birdList.Sort();
            foreach (var bird in birdList)
            {
                this.BirdDataset.Rows.Add(
                    bird.Serial,
                    bird.SpeciesBird,
                    bird.SubSpeciesBird,
                    bird.ExpirationDate,
                    bird.Sex,
                    bird.CageNumber,
                    bird.F_Serial,
                    bird.M_Serial
                );
            }

            // Display the cage number and other details in the corresponding text boxes
            S_num.Text = Cage.CageNumber;
            sexBirdBox.Texts = Cage.Material;
            Length_box.Texts = Cage.Length;
            height_box.Texts = Cage.Hight;
            width_box.Texts = Cage.With;
        }

        // Event handler for the Save button click event

        private void Save_BTU_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the cage dimensions
                ArgumentTest.TestCageDimensions(width_box.Texts, Length_box.Texts, height_box.Texts);

                // Update the cage record with the new dimensions and material
                FileControl.EditCageRecord(S_num.Text, width_box.Texts, Length_box.Texts, height_box.Texts, sexBirdBox.Texts);

                MessageBoxClass.CageSuccessfullyAdded(S_num.Text);
                this.Close();
            }
            catch (DimensionsException)
            {
                MessageBoxClass.CageDimensionsError();
            }
        }
    }
}
