using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestF.Forms.MineForms;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF
{
    public partial class LoginFrom : Form
    {
        // Constructor
        public LoginFrom()
        {
            InitializeComponent();

            // Set the title bar properties
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Import external functions from user32 DLL for capturing mouse movement and sending messages
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Event handler for mouse down event on the panelTitleBar
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Capture the mouse movement
            ReleaseCapture();
            // Send a system message to move the window
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Event handlers for the UserNameBox (text box for entering username)
        private void UserNameBox_Click(object sender, EventArgs e)
        {
            // If the default text "username" is present, clear the box
            if (UserNameBox.Texts == "username")
                UserNameBox.Texts = String.Empty;
            UserNameBox.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void UserNameBox_Leave(object sender, EventArgs e)
        {
            // If the username box is empty, set the default text "username" and change the color to gray
            if (UserNameBox.Texts == "")
            {
                UserNameBox.Texts = "username";
                UserNameBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        // Event handlers for the PasswordBox (text box for entering password)
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            // If the default text "password" is present, clear the box
            if (PasswordBox.Texts == "password")
                PasswordBox.Texts = String.Empty;
            PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            // If the password box is empty, set the default text "Password" and change the color to gray
            if (PasswordBox.Texts == "")
            {
                PasswordBox.Texts = "Password";
                PasswordBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        // Event handler for the exitBtu (exit button) click event
        private void exitBtu_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler for the BtuMaxSize (maximize button) click event
        private void BtuMaxSize_Click(object sender, EventArgs e)
        {
            // Maximize or restore the window based on its current state
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Event handler for the BtuMiniSize (minimize button) click event
        private void BtuMiniSize_Click(object sender, EventArgs e)
        {
            // Minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        // Event handler for the loginBtu (login button) click event
        private void loginBtu_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the entered username and password match any user in the user list
                if (!FileControl.GetUserList().Any(user => user.userName == UserNameBox.Texts) || !FileControl.GetUserList().Any(user => user.password == PasswordBox.Texts))
                    throw new UserPasswordExceptions();

                // Hide the current login form
                this.Hide();

                // Show the main form
                MianFrom from = new MianFrom();
                from.ShowDialog();

                // Close the login form
                this.Close();
            }
            catch (UserPasswordExceptions)
            {
                // Display an error message if the username or password is incorrect
                MessageBoxClass.UserOrPasswordError();

                // Clear the password box and change the color to white
                PasswordBox.Texts = String.Empty;
                PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
            }
        }

        // Event handler for the BtuRegistrar (register button) click event
        private void BtuRegistrar_Click(object sender, EventArgs e)
        {
            // Hide the current login form
            this.Hide();

            // Show the registration form
            RegistrarFrom from = new RegistrarFrom();
            from.ShowDialog();

            // Close the login form
            this.Close();
        }
    }
}
