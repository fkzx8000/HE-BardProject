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
        //TODO: זה הדף שאמור להראות את המאגר מידע של כלובים
        //!!!!!!!!!! להציג רשימה ממוינת לפי מספר כלוב!!!!!!!!!!!
        // שליפה מקובץ אחרי מיון
        
        private MianFrom grandfather;
        private CageSearchFrom fatherFrom;

        // ctor
        public CageDataSetFrom(MianFrom main, CageSearchFrom searchForm)
        {
            InitializeComponent();
            grandfather = main;
            fatherFrom = searchForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            var arr = FileControl.GetCageList().ToArray();

            Array.Sort(arr, new AlphanumComparatorFast());          

            foreach (var element in arr)
            {
                this.cageDataset.Rows.Add(element.CageNumber, element.With, element.Length, element.Hight, element.Material);
            }
        }

        public CageDataSetFrom(MianFrom main, CageSearchFrom searchForm, string cageNumber, string material)
        {
            InitializeComponent();
            grandfather = main;
            fatherFrom = searchForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            var cages = FileControl.GetCageList();

            if (cageNumber !="מספר כלוב" && material != "             חומר הכלוב")
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

            var arr = cages.ToArray();


            Array.Sort(arr, new AlphanumComparatorFast());

            foreach (var element in arr)
            {
                this.cageDataset.Rows.Add(element.CageNumber, element.With, element.Length, element.Hight, element.Material);
            }
        }

        //-------------system Do not touch --------------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------system Do not touch --------------

        private void CageDataset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = cageDataset.Rows[rowIndex];
            CageData cage = new CageData()
            {
                CageNumber = (string)row.Cells[0].Value,
                With = (string)row.Cells[1].Value,
                Length = (string)row.Cells[2].Value,
                Hight = (string)row.Cells[3].Value,
                Material = (string)row.Cells[4].Value
            };
            this.Hide();
            InfoCageFrom form = new InfoCageFrom(grandfather, fatherFrom, cage);
            form.ShowDialog();
        }
    }
}
