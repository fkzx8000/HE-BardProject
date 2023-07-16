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

        //TODO: זה דף מידע על כלוב
        /* 1. בטבלה שהדף כולל על הטבלה להכיל את כל הציפורים שהם בתוך הכלוב הזה
         * 
         * 2. יש אפשרות לערוך את הפרטים של כלובים 
         * 
         * 3. !!! כאשר משנים מספר סידורי של כלוב על כל הציפורים שבכלוב גם לשתנות!!!!
         * 
         * 4.הצגת הכלוב יופיעו פרטי הכלוב ורשימה של הציפורים שנמצאים בו לפי מספר סידורי
         * 
         */
        private MianFrom grandfather;
        private CageSearchFrom fatherFrom;
        private CageData Cage;

        //ctor
        public InfoCageFrom(MianFrom main, CageSearchFrom searchForm,CageData data)
        {
            InitializeComponent();
            grandfather = main;
            fatherFrom = searchForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Cage = data; 
        }

        //ניקוי תבות לצוריכי נראות


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

        private void width_box_Click(object sender, EventArgs e)
        {
            if (width_box.Texts == "רוחב")
                width_box.Texts = String.Empty;
        }

        private void width_box_Leave(object sender, EventArgs e)
        {
            if (width_box.Texts == "")
                width_box.Texts = "רוחב";
        }

        private void height_box_Click(object sender, EventArgs e)
        {
            if (height_box.Texts == "גובה")
                height_box.Texts = String.Empty;
        }

        private void height_box_Leave(object sender, EventArgs e)
        {
            if (height_box.Texts == "")
                height_box.Texts = "גובה";
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

        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void OnlyNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        private void InfoCageFrom_Load(object sender, EventArgs e)
        {
            var birdList = FileControl.GetBird().Where(bird => bird.CageNumber == Cage.CageNumber).ToList();

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
            S_num.Text = Cage.CageNumber;
            sexBirdBox.Texts = Cage.Material;
            Length_box.Texts = Cage.Length;
            height_box.Texts = Cage.Hight;
            width_box.Texts = Cage.With;
        }

        private void Save_BTU_Click(object sender, EventArgs e)
        {
            try
            {
                ArgumentTest.TestCageDimensions(width_box.Texts, Length_box.Texts, height_box.Texts);

                FileControl.EditCageRecord(S_num.Text, width_box.Texts, Length_box.Texts, height_box.Texts, sexBirdBox.Texts);

                MessageBoxClass.CageSuccessfullyAdded(S_num.Text);
                this.Close();
            }
            catch (DimensionsException)
            {
                MessageBoxClass.CageDimensionsError();
            }
        }


        //-------------system Do not touch --------------

    }
}
