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
using TestF.forms;

namespace TestF
{
    public partial class MianFrom : Form
    {
        // TODO: העמוד הראשי עם כל הפניות תכלס אין מה לגעת


        //Fields
        private Button currentButton;
        private Random random;
        private Form activeForm;
        //ctor
        public MianFrom()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
            smallLogo.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //-------  ------- system 32 -------  -------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        //----------------------------- פונקציות פנימיות------------------------

        //  הפונקציה שמראה איזה כפתור פעיל עכשיו אם יש כפתור פעיל בכלל.
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#B71C46");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial Rounded", 12F);
                    panelTitleBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    btnClose.Visible = true;
                    smallLogo.Visible = true;
                }
            }
        }


        // פותח חלונית משנה למסך הראשי
        private void OpenContainingForm(Form ONForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            OpenAdd(ONForm);
        }

        // משבית את הכפתור הפעיל
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro; 
                    previousBtn.Font = new System.Drawing.Font("Arial Rounded", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // פוקצית כפתור האקס
        private void btnClose_Click(object sender, EventArgs e) { if (activeForm != null) activeForm.Close(); Reset(); }

        private void Reset()
        {
            DisableButton();
            siteLOGO.Text = "מסך בית";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnClose.Visible = false;
            smallLogo.Visible = false;
        }


        // --------------פונקציות חיצוניות--------------

        public void OpenAdd(Form BridAdd) {
            activeForm = BridAdd;
            BridAdd.TopLevel = false;
            BridAdd.FormBorderStyle = FormBorderStyle.None;
            BridAdd.Dock = DockStyle.Fill;
            this.panelContaining.Controls.Add(BridAdd);
            this.panelContaining.Tag = BridAdd;
            BridAdd.BringToFront();
            BridAdd.Show();
            siteLOGO.Text = BridAdd.Text;
            //ActivateButton(this.BTNaddBird);
        }
        
        public void ActivaAddBird() { ActivateButton(this.BTNaddBird); }

        //************--- כפתורי מעבר ---*********

        private void BTNaddBird_Click(object sender, EventArgs e)
        {OpenContainingForm(new forms.AddBirdFrom(), sender);}

        private void BirdSearchBTU_Click(object sender, EventArgs e)
        {OpenContainingForm(new forms.BirdSearchFrom(this), sender);}

        private void BTNaddCage_Click(object sender, EventArgs e)
        {OpenContainingForm(new forms.AddCageFrom(), sender);}

        private void cageSearchBTU_Click(object sender, EventArgs e)
        {OpenContainingForm(new forms.CageSearchFrom(this), sender);}


        //************--- panel system ---*********

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // שלושת כפתורי השליטה,סגור,הגדל,מזער
        private void exitBTN_Click(object sender, EventArgs e) { Application.Exit(); }

        private void BTNmaxsize_Click(object sender, EventArgs e) { if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized; else this.WindowState = FormWindowState.Normal; }

        private void BTNminisize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

    }
}
