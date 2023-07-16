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
        // Fields
        private Button currentButton;
        private Random random;
        private Form activeForm;

        // Constructor
        public MianFrom()
        {
            InitializeComponent();

            // Initialize fields
            random = new Random();
            btnClose.Visible = false;
            smallLogo.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Import external functions from user32 DLL for capturing mouse movement and sending messages
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Method to activate the selected button
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

        // Method to open a new form within the containing panel
        private void OpenContainingForm(Form ONForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            OpenAdd(ONForm);
        }

        // Method to disable the previously activated button
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

        // Event handler for the btnClose (close button) click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        // Method to reset the form's state
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

        // Method to open a form within the containing panel
        public void OpenAdd(Form BridAdd)
        {
            activeForm = BridAdd;
            BridAdd.TopLevel = false;
            BridAdd.FormBorderStyle = FormBorderStyle.None;
            BridAdd.Dock = DockStyle.Fill;
            this.panelContaining.Controls.Add(BridAdd);
            this.panelContaining.Tag = BridAdd;
            BridAdd.BringToFront();
            BridAdd.Show();
            siteLOGO.Text = BridAdd.Text;
        }

        // Method to activate the "Add Bird" button
        public void ActivaAddBird()
        {
            ActivateButton(this.BTNaddBird);
        }

        // Event handler for the BTNaddBird (Add Bird button) click event
        private void BTNaddBird_Click(object sender, EventArgs e)
        {
            OpenContainingForm(new forms.AddBirdFrom(), sender);
        }

        // Event handler for the BirdSearchBTU (Bird Search button) click event
        private void BirdSearchBTU_Click(object sender, EventArgs e)
        {
            OpenContainingForm(new forms.BirdSearchFrom(this), sender);
        }

        // Event handler for the BTNaddCage (Add Cage button) click event
        private void BTNaddCage_Click(object sender, EventArgs e)
        {
            OpenContainingForm(new forms.AddCageFrom(), sender);
        }

        // Event handler for the cageSearchBTU (Cage Search button) click event
        private void cageSearchBTU_Click(object sender, EventArgs e)
        {
            OpenContainingForm(new forms.CageSearchFrom(this), sender);
        }

        // Event handler for the panelTitleBar (title bar panel) mouse down event
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Event handler for the panelLogo (logo panel) mouse down event
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Event handler for the exitBTN (exit button) click event
        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the BTNmaxsize (maximize button) click event
        private void BTNmaxsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Event handler for the BTNminisize (minimize button) click event
        private void BTNminisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
