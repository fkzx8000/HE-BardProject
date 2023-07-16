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
        //TODO: זה דף הרשמה + הוראות
        /*
         * !!!!!!!   המשתמשים חייבים להשמר בקובץ אקסל !!!!!!!
         *  1.       שם משתמש - מכיל בין 6 ל 8 תווים. מתוך התווים, לכל היותר 2 *ספרות* וכל השאר אותיות,  האותיות חייבות להיות באנגלית  
         *  
         *  2.        סיסמה – בין 8 ל 10 תווים. מכיל לפחות אות אחת, סיפרה אחת ותו מיוחד אחד 
         *    תוו מיוחד (!,#,$,....)
         *    
         *  3. מספר ת"ז חייב להיות רק ממספרים
         *  
         *  4. שגיאה באחד הפרטים צריכה להוביל להצגת הודעת שגיאה מתאימה
         * 
         */


        //ctor
        public RegistrarFrom()
        {
            InitializeComponent();
            // העלת הפנאל הרגיל
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // הזזת החלון דרך הפנאל
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


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


        // -------------------- user boxs--------------------------
        //---------------------- events ---------------------------

        //--- password ---
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            // תזכורת
            //its not "Text" its "Texts"
            if (UserNameBox.Texts == "Password")
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
        //--- UserName ---
        private void UserNameBox_Click(object sender, EventArgs e)
        {
            //TODO: its not "Text" its "Texts"
            if (UserNameBox.Texts == "username")
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
        //--- ID_box ---
        private void ID_Box_Click(object sender, EventArgs e)
        {
            //TODO: its not "Text" its "Texts"
            if (ID_Box.Texts == "ID")
                ID_Box.Texts = String.Empty;
            ID_Box.ForeColor = System.Drawing.SystemColors.Window;
        }
        private void ID_Box_Leave(object sender, EventArgs e)
        {
            // מצב עזיבה ללא כתיבת כלום
            if (ID_Box.Texts == "")
            {
                ID_Box.Texts = "ID";
                ID_Box.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        //---------- כפתור חזרה אחורה---------------
        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom from = new LoginFrom();
            from.ShowDialog();
            this.Close();
        }

        private void loginBtu_Click(object sender, EventArgs e)
        {
            try
            {
                ArgumentTest.TestUserName(UserNameBox.Texts);
                ArgumentTest.TestPassword(PasswordBox.Texts);
                ArgumentTest.TestId(ID_Box.Texts);

                FileControl.RegisterUser(UserNameBox.Texts, PasswordBox.Texts, ID_Box.Texts);
                MessageBoxClass.UserSuccessfullyRegisters(UserNameBox.Texts);

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
