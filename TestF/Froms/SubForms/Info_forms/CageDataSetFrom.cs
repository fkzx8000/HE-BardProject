using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestF.forms;
using TestF.logic;
using TestF.logic.DataAndFile;

namespace TestF.Forms.SubForms.Info_forms
{
    public partial class CageDataSetFrom : Form
    {
        // Reference to the grandparent form (MianFrom) and parent form (CageSearchFrom)
        private MianFrom grandfather;
        private CageSearchFrom fatherFrom;

        // Constructor without filters
        public CageDataSetFrom(MianFrom main, CageSearchFrom searchForm)
        {
            InitializeComponent();
            grandfather = main;
            fatherFrom = searchForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Retrieve the list of cages using FileControl.GetCageList() and convert it to an array
            var arr = FileControl.GetCageList().ToArray();

            // Sort the array using the AlphanumComparatorFast class to ensure alphanumeric sorting
            Array.Sort(arr, new AlphanumComparatorFast());

            // Add each cage's data to the DataGridView
            foreach (var element in arr)
            {
                this.cageDataset.Rows.Add(element.CageNumber, element.With, element.Length, element.Hight, element.Material);
            }
        }

        // Constructor with filters
        public CageDataSetFrom(MianFrom main, CageSearchFrom searchForm, string cageNumber, string material)
        {
            InitializeComponent();
            grandfather = main;
            fatherFrom = searchForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Retrieve the list of cages using FileControl.GetCageList()
            var cages = FileControl.GetCageList();

            // Apply filters based on the provided cageNumber and material parameters
            if (cageNumber != "מספר כלוב" && material != "             חומר הכלוב")
            {
                // Filter by both cageNumber and material
                cages = cages.Where(cage => cage.CageNumber == cageNumber && cage.Material == material).ToList();
            }
            else if (cageNumber != "מספר כלוב")
            {
                // Filter by cageNumber only
                cages = cages.Where(cage => cage.CageNumber == cageNumber).ToList();
            }
            else if (material != "             חומר הכלוב")
            {
                // Filter by material only
                cages = cages.Where(cage => cage.Material == material).ToList();
            }

            // Convert the filtered cages list to an array
            var arr = cages.ToArray();

            // Sort the array using the AlphanumComparatorFast class to ensure alphanumeric sorting
            Array.Sort(arr, new AlphanumComparatorFast());

            // Add each cage's data to the DataGridView
            foreach (var element in arr)
            {
                this.cageDataset.Rows.Add(element.CageNumber, element.With, element.Length, element.Hight, element.Material);
            }
        }

        // Import external functions from user32 DLL for capturing mouse movement and sending messages
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Event handler for the panelTitleBar (title bar panel) mouse down event
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Capture mouse movement
            ReleaseCapture();

            // Send a message to the form to indicate that the left mouse button is being held down and dragged
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Event handler for the exitBTN (exit button) click event
        private void exitBTN_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        // Event handler for the CageDataset (DataGridView) cell double-click event
        private void CageDataset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = cageDataset.Rows[rowIndex];

            // Create a CageData object with the selected cage's data
            CageData cage = new CageData()
            {
                CageNumber = (string)row.Cells[0].Value,
                With = (string)row.Cells[1].Value,
                Length = (string)row.Cells[2].Value,
                Hight = (string)row.Cells[3].Value,
                Material = (string)row.Cells[4].Value
            };

            // Hide the current form and show the InfoCageFrom form to display detailed information about the selected cage
            this.Hide();
            InfoCageFrom form = new InfoCageFrom(grandfather, fatherFrom, cage);
            form.ShowDialog();
        }
    }
}
