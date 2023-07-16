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

        /* TODO: דף התחברות + הוראות
         * 
         *      שגיאה באחד הפרטים צריכה להוביל להצגת הודעת שגיאה מתאימה
         *     (אם הסיסמה לא נכונה אז המערכת תזרוק הראות)
         * 
         * 
         */


        //ctor
        public LoginFrom()
        {
           InitializeComponent();
           this.Text = string.Empty;
           this.ControlBox = false;
           this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        ///מאפשר לעכבר להזיז את החלונית
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //------------- panal event-----------
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ///מאפשר לעכבר להזיז את החלונית
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        // -----------------------מצבי התבות-----------------------

        private void UserNameBox_Click(object sender, EventArgs e)
        {
            //TODO: its not "Text" its "Texts"
            if(UserNameBox.Texts == "username")
                UserNameBox.Texts = String.Empty;
            UserNameBox.ForeColor = System.Drawing.SystemColors.Window;
        }
        private void UserNameBox_Leave(object sender, EventArgs e)
        {
            // מצב עזיבה ללא כתיבת כלום
            if (UserNameBox.Texts == "")
            {
                UserNameBox.Texts = "username";
                UserNameBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            //TODO: its not "Text" its "Texts"
            if (PasswordBox.Texts == "password")
                PasswordBox.Texts = String.Empty;
            PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
            
        }
        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            // מצב עזיבה ללא כתיבת כלום
            if (PasswordBox.Texts == "")
            {
                PasswordBox.Texts = "Password";
                PasswordBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        //------------------------כפתורים-----------------------

        // שלושת כפתורי השליטה,סגור,הגדל,מזער
        private void exitBtu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtuMaxSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtuMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        //כפתור התחבר
        private void loginBtu_Click(object sender, EventArgs e)
        {
            //TODO: זה הכפתור התחבר
            ///תנאים
            ///שם משתמש וסיסמה – ששמורים בקובץ אקסל
            //PasswordBox-> text box for password
            //UserNameBox-> text box for user name
            try
            {
                if (!FileControl.GetUserList().Any(user => user.userName == UserNameBox.Texts) || !FileControl.GetUserList().Any(user => user.password == PasswordBox.Texts))
                    throw new UserPasswordExceptions();

                this.Hide();
                MianFrom from = new MianFrom();
                from.ShowDialog();
                this.Close();
            }
            catch (UserPasswordExceptions)
            {
                MessageBoxClass.UserOrPasswordError();
                PasswordBox.Texts = String.Empty;
                PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
            }
        }

        //כפתור מעבר להרשמה
        private void BtuRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarFrom from = new RegistrarFrom();
            from.ShowDialog();
            this.Close();
        }

        private void UserNameBox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
