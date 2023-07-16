using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestF.files;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF.forms
{
    public partial class InfoBirdFrom : Form
    {



        //TODO:עמוס!!!!  מידע על ציפור ספציפית
        //  ניתן לערוך ולשמור כל פרט

        /*

        // 1.  אם זה מספר סידורי על המספר לא לחזור על עצמו אצל אפ ציפור אחרת, ולתעדכן אצל ההורים והילדים
        
        // 2. אם מדובר בזן אזיש חובה לשנות תת זן לפני שהשינוי ישמר
        
        // 3. אם זה מספר סידורי של אב או אם אז זה ציפורים מבוגרות יותר וקיימיות
        
        // 4.  בהוספת גוזל חייבים לבדוק שהציפור הנוספת קיימת ומהמין השונה****


        /*
         *  ----- הוראות ישר מעבודה----
         *מסך שמציג את פרטי הציפור,
         *בנוסף לפרטים יהיה כפתור שמאפשר להוסיף גוזלים לציפור 
         *.(יש צורך לבקש את המספר של ההורה השני)
         ***כל גוזל מקבל את כל הפרטים כמו בהוספת ציפור חדשה כאשר הפרטים הידועים צרכים להתווסף ***באופן אוטומטי
         *למשל, הגוזל נמצא באותו הכלוב כמו ההורה שלו, זן הציפור והתת זן הם כמו של ההורה וכו
         * 
         */


        //----- ירושמה מחלונות קודמים----
        //----- לצורך נראות פתחת חלונית הוספת ציפור (גוזל)--
        private MianFrom grandfather;
        private BirdSearchFrom fatherFrom;
        private BirdData MyBird;
        //Ctor
        public InfoBirdFrom(MianFrom a, BirdSearchFrom f, BirdData bird)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            grandfather = a;
            fatherFrom = f;
            MyBird=bird;

        }

        private static string GetRandomString(string str1, string str2)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            if (rand.Next(0, 1) == 0)
                return str1;
            return str2;
        }


        // כפתור הוסף גוזל
        private void Add_Btu_Click(object sender, EventArgs e)
        {
            try
            {
                var rand = new Random(DateTime.Now.Millisecond);

                var secondParent = FileControl.GetBird().Where(b => b.Serial == serial_number_other.Texts).ToList();
                var time = DateTime.Now.ToString("dd/MM/yyyy");
                string serial = rand.Next(1000, 10000).ToString();
                while (FileControl.GetBird().Any(b => b.Serial == serial))
                {
                    serial = rand.Next(1000, 10000).ToString();
                }

                if (MyBird.Sex == "זכר")
                {
                    FileControl.AddBird(
                        serial,
                        GetRandomString(secondParent[0].SpeciesBird, MyBird.SpeciesBird),
                        GetRandomString(secondParent[0].SubSpeciesBird, MyBird.SubSpeciesBird),
                        GetRandomString(secondParent[0].Sex, MyBird.Sex),
                        MyBird.Serial, secondParent[0].Serial,
                        GetRandomString(secondParent[0].CageNumber, MyBird.CageNumber), time);
                }
                else
                {
                    FileControl.AddBird(
                          serial,
                          GetRandomString(secondParent[0].SpeciesBird, MyBird.SpeciesBird),
                          GetRandomString(secondParent[0].SubSpeciesBird, MyBird.SubSpeciesBird),
                          GetRandomString(secondParent[0].Sex, MyBird.Sex),
                          secondParent[0].Serial, MyBird.Serial,
                          GetRandomString(secondParent[0].CageNumber, MyBird.CageNumber), time);
                }

                MessageBoxClass.BirdSuccessfullyAdded(serial);
                this.Close();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Pleas select second parent", "Error");
            }
        }

        //ניקוי תבות לצוריכי נראות


        private void dynamic_cage_number_Click(object sender, EventArgs e)
        {
            if (dynamic_cage_number.Texts == "מספר הכלוב")
                dynamic_cage_number.Texts = String.Empty;
        }

        private void dynamic_cage_number_Leave(object sender, EventArgs e)
        {
            if (dynamic_cage_number.Texts == "")
                dynamic_cage_number.Texts = "מספר הכלוב";
        }


        private void serial_number_other_Click(object sender, EventArgs e)
        {
            if (serial_number_other.Texts == "מספר סידורי של ההורה האחר")
                serial_number_other.Texts = String.Empty;
        }

        private void serial_number_other_Leave(object sender, EventArgs e)
        {
            if (serial_number_other.Texts == "")
                serial_number_other.Texts = "מספר סידורי של ההורה האחר";
        }

        private void subspecies_dynamic_Click(object sender, EventArgs e)
        {
            if (subspeciess_dynamic.Texts == "תת זן")
                subspeciess_dynamic.Texts = String.Empty;
        }

        private void subspecies_dynamic_Leave(object sender, EventArgs e)
        {
            if (subspeciess_dynamic.Texts == "")
                subspeciess_dynamic.Texts = "תת זן";
        }
        //מסווג לפי מינים
        private void species_bird_dynamic_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            subspeciess_dynamic.Texts = "             תת זן";
            subspeciess_dynamic.Items.Clear();

            if (species_bird_dynamicc.Texts == "גולדיאן אוסטרלי")
                subspeciess_dynamic.Items.AddRange(new object[] { "מרכז אוסטרליה", "ערי חוף" });

            if (species_bird_dynamicc.Texts == "גולדיאן אירופאי")
                subspeciess_dynamic.Items.AddRange(new object[] { "מזרח אירופה", "מערב אירופה" });

            if (species_bird_dynamicc.Texts == "גולדיאן אמריקאי")
                subspeciess_dynamic.Items.AddRange(new object[] { "צפון אמריקה", "מרכז אמריקה", "דרום אמריקה" });

        }

        //-------------system Do not touch --------------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void exitBTN_Click(object sender, EventArgs e)
        {
            //Ityan.Close();
            this.Close();

        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OnlyNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        private void dynamic_cage_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
            
        }

        private void InfoBirdFrom_Load(object sender, EventArgs e)
        {
            S_num.Text= MyBird.Serial;
            species_bird_dynamicc.Texts= MyBird.SpeciesBird;
            subspeciess_dynamic.Texts = MyBird.SubSpeciesBird;
            dynamic_date.Text = MyBird.ExpirationDate;
            dynamic_sex_bird.Texts= MyBird.Sex;
            dynamic_cage_number.Texts = MyBird.CageNumber;
            dynamic_F_serial_number.Text = MyBird.F_Serial;
            dynamic_M_serial_number.Text=MyBird.M_Serial;

            try
            {
                string sex = "";
                if (MyBird.Sex == "זכר")
                    sex = "נקבה";
                else
                    sex = "זכר";

                var birdList = FileControl.GetBird().Where(birds => birds.Sex == sex).ToList();
                foreach (BirdData b in birdList)
                {
                    serial_number_other.Items.Add(b.Serial);
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No gender found");
            }

        }

        private void Save_Btu_Click(object sender, EventArgs e)
        {
            try
            {
                ArgumentTest.TestCageSerial(dynamic_cage_number.Texts);
                FileControl.EditBirdRecord(S_num.Text, species_bird_dynamicc.Texts, subspeciess_dynamic.Texts, dynamic_sex_bird.Texts, dynamic_F_serial_number.Text, dynamic_M_serial_number.Text, dynamic_cage_number.Texts, dynamic_date.Text);
                MessageBoxClass.BirdSuccessfullyAdded(S_num.Text);

                this.Close();
            }
            catch (CageMissingException)
            {
                MessageBoxClass.CageSerialMissingError();
            }
            catch (SerialException)
            {
                MessageBoxClass.CageSerialError();
                dynamic_cage_number.Texts = String.Empty;
            }
            
        }
        //-------------system Do not touch --------------

    }
}
