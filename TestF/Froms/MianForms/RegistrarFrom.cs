using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestF.files;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF.Forms.MineForms
{
    public partial class RegistrarFrom : Form
    {
        // Constructor
        public RegistrarFrom()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Import external functions from user32 DLL for capturing mouse movement and sending messages
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Event handler for the panelTitleBar (title bar panel) mouse down event
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Event handler for the exitBtu (exit button) click event
        private void exitBtu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the BtuMaxSize (maximize button) click event
        private void BtuMaxSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Event handler for the BtuMiniSize (minimize button) click event
        private void BtuMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Event handler for the PasswordBox (password textbox) click event
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Texts == "Password")
                PasswordBox.Texts = String.Empty;
            PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
        }

        // Event handler for the PasswordBox (password textbox) leave event
        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Texts == "")
            {
                PasswordBox.Texts = "Password";
                PasswordBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        // Event handler for the UserNameBox (username textbox) click event
        private void UserNameBox_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Texts == "username")
                UserNameBox.Texts = String.Empty;
            UserNameBox.ForeColor = System.Drawing.SystemColors.Window;
        }

        // Event handler for the UserNameBox (username textbox) leave event
        private void UserNameBox_Leave(object sender, EventArgs e)
        {
            if (UserNameBox.Texts == "")
            {
                UserNameBox.Texts = "username";
                UserNameBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        // Event handler for the ID_Box (ID textbox) click event
        private void ID_Box_Click(object sender, EventArgs e)
        {
            if (ID_Box.Texts == "ID")
                ID_Box.Texts = String.Empty;
            ID_Box.ForeColor = System.Drawing.SystemColors.Window;
        }

        // Event handler for the ID_Box (ID textbox) leave event
        private void ID_Box_Leave(object sender, EventArgs e)
        {
            if (ID_Box.Texts == "")
            {
                ID_Box.Texts = "ID";
                ID_Box.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        // Event handler for the GoBack button click event
        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom from = new LoginFrom();
            from.ShowDialog();
            this.Close();
        }

        // Event handler for the loginBtu (login button) click event
        private void loginBtu_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the entered username, password, and ID
                ArgumentTest.TestUserName(UserNameBox.Texts);
                ArgumentTest.TestPassword(PasswordBox.Texts);
                ArgumentTest.TestId(ID_Box.Texts);

                // Register the user with the entered details
                FileControl.RegisterUser(UserNameBox.Texts, PasswordBox.Texts, ID_Box.Texts);
                MessageBoxClass.UserSuccessfullyRegisters(UserNameBox.Texts);

                // Close the current form and show the login form
                this.Hide();
                LoginFrom from = new LoginFrom();
                from.ShowDialog();
                this.Close();
            }
            catch (UserNameException)
            {
                MessageBoxClass.UserNameError();
                UserNameBox.Texts = String.Empty;
                UserNameBox.ForeColor = System.Drawing.SystemColors.Window;
            }
            catch (PasswordException)
            {
                MessageBoxClass.PasswordError();
                PasswordBox.Texts = String.Empty;
                PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
            }
            catch (IDException)
            {
                MessageBoxClass.IdError();
                ID_Box.Texts = String.Empty;
                ID_Box.ForeColor = System.Drawing.SystemColors.Window;
            }
            catch (UserNameTakenException)
            {
                MessageBoxClass.UserExistsError(UserNameBox.Texts);
                UserNameBox.Texts = String.Empty;
                UserNameBox.ForeColor = System.Drawing.SystemColors.Window;
            }
            catch (IDTakenException)
            {
                MessageBoxClass.IDExistsError(ID_Box.Texts);
                ID_Box.Texts = String.Empty;
                ID_Box.ForeColor = System.Drawing.SystemColors.Window;
            }
        }
    }
}
