using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestF.forms;
using TestF.logic.DataAndFile;

namespace TestF.Forms.SubForms.Info_forms
{
    public partial class BirdsDataSetFrom : Form
    {

        //TODO: זה הדף שאמור להראות את המאגר מידע של הציפורים
        //!!!!!!!!!! להציג רשימה ממוינת לפי מספר ציפור!!!!!!!!!!!
        // שליפה מקובץ אחרי מיון

        private MianFrom grandfather;
        private BirdSearchFrom fatherFrom;


        // ctor
        public BirdsDataSetFrom(MianFrom a, BirdSearchFrom bi, List<BirdData> data, string serialNumber, string species, string subSpecies, string sex, string date = "")
        {
            InitializeComponent();
            grandfather = a;
            fatherFrom = bi;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            if (serialNumber != "מספר סידורי")
                data = data.Where(b => b.Serial == serialNumber).ToList();

            if (!species.Equals("זן הציפור"))
                data = data.Where(b => b.SpeciesBird == species).ToList();


            if (subSpecies != "תת זן")
                data = data.Where(b => b.SubSpeciesBird == subSpecies).ToList();

            if (sex != "             מין הציפור")
                data = data.Where(b => b.Sex == sex).ToList();

            if (!string.IsNullOrEmpty(date))
                data = data.Where(b => b.ExpirationDate == date).ToList();

            
            data.Sort();
            foreach (var bird in data)
            {
                Console.WriteLine(bird.Serial);
                this.BirdDataset.Rows.Add(
                    bird.Serial,
                    bird.SpeciesBird,
                    bird.SubSpeciesBird,
                    bird.ExpirationDate,
                    bird.Sex,
                    bird.CageNumber,
                    bird.F_Serial,
                    bird.M_Serial);
            }

        }

        public BirdsDataSetFrom(MianFrom a, BirdSearchFrom b, List<BirdData> data)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            data.Sort();
            foreach (var bird in data)
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

        private void BirdDataset_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = BirdDataset.Rows[rowIndex];
            BirdData bird = new BirdData()
            {
                Serial = (string)row.Cells[0].Value,
                SpeciesBird = (string)row.Cells[1].Value,
                SubSpeciesBird = (string)row.Cells[2].Value,
                ExpirationDate = (string)row.Cells[3].Value,
                Sex = (string)row.Cells[4].Value,
                CageNumber = (string)row.Cells[5].Value,
                F_Serial = (string)row.Cells[6].Value,
                M_Serial = (string)row.Cells[7].Value

            };
            this.Hide();
            InfoBirdFrom from = new InfoBirdFrom(grandfather, fatherFrom, bird);
            from.ShowDialog();
        }
    }

        //-----------system Do not touch------------------


    
}
