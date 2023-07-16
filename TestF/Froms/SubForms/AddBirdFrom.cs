using System;
using System.Linq;
using System.Windows.Forms;
using TestF.files;
using TestF.logic;
using TestF.logic.DataAndFile;
using TestF.logic.Exceptions;

namespace TestF.forms
{

    public partial class AddBirdFrom : Form
    {

        //TODO: זה תת מסך להוספת ציפור
        /*
         * 1. המספר הסידורי חייב להיות רק מספרים בלבד
         * 
         * 2. זן הציפור – אותיות. בונוס מצורף לעבודה
         * 
         * 3. תת זן – אותיות
         * 
         * 4. תאריך בקיעה
         * 
         * 5. מין הציפור
         * 
         * 6. מספר כלוב – אותיות וספרות
         * 
         * 7. מספר סידורי אב -ספרות בלבד
         * 
         * 8. מספר סידורי אם - ספרות בלבד
         * 
         * 9. הציפור מתווספת לקובץ
         * 
         */


        //ctor
        public AddBirdFrom()
        {
            InitializeComponent();
        }

        //----- ניקוי תבות-----
        private void cageNumber_Click(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "מספר כלוב")
                cageNumber.Texts = String.Empty;
        }

        private void cageNumber_Leave(object sender, EventArgs e)
        {
            if (cageNumber.Texts == "")
                cageNumber.Texts = "מספר כלוב";

        }

        private void FSerialNumber_Click(object sender, EventArgs e)
        {
            if (FSerialNumber.Texts == "מספר סידורי אב")
                FSerialNumber.Texts = String.Empty;
        }

        private void FSerialNumber_Leave(object sender, EventArgs e)
        {
            if (FSerialNumber.Texts == "")
            {
                FSerialNumber.Texts = "מספר סידורי אב";
            }
        }


        private void MSerialNumber_Click(object sender, EventArgs e)
        {
            if (MSerialNumber.Texts == "מספר סידורי אם")
                MSerialNumber.Texts = String.Empty;
        }

        private void MSerialNumber_Leave(object sender, EventArgs e)
        {
            if (MSerialNumber.Texts == "")
                MSerialNumber.Texts = "מספר סידורי אם";
            
        }

        private void SerialBox_Click(object sender, EventArgs e)
        {
            if (SerialBox.Texts == "מספר סידורי")
                SerialBox.Texts = String.Empty;
        }

        private void SerialBox_Leave(object sender, EventArgs e)
        {
            if (SerialBox.Texts == "")
                SerialBox.Texts = "מספר סידורי";  
        }
        //--------- תלות תת זן בזן---------------
        private void zan_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ttzan.Texts = "             תת זן";
            ttzan.Items.Clear();
            if (zan.Texts == "גולדיאן אוסטרלי")
                ttzan.Items.AddRange(new object[] { "מרכז אוסטרליה", "ערי חוף" });

            if (zan.Texts == "גולדיאן אירופאי")
                ttzan.Items.AddRange(new object[] { "מזרח אירופה", "מערב אירופה" });

            if (zan.Texts == "גולדיאן אמריקאי")
                ttzan.Items.AddRange(new object[] { "צפון אמריקה", "מרכז אמריקה", "דרום אמריקה" });
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                ArgumentTest.TestBirdId(SerialBox.Texts);
                ArgumentTest.TestBirdId(FSerialNumber.Texts);
                ArgumentTest.TestBirdId(MSerialNumber.Texts);
                ArgumentTest.TestCageSerial(cageNumber.Texts);
                FileControl.AddBird(SerialBox.Texts, zan.Texts, ttzan.Texts, sexBirdBox.Texts, FSerialNumber.Texts, MSerialNumber.Texts, cageNumber.Texts, DateBirthBox.Value.ToString("dd/MM/yyyy"));

                MessageBoxClass.BirdSuccessfullyAdded(SerialBox.Texts);

                cageNumber.Texts = "מספר כלוב";
                FSerialNumber.Texts = "מספר סידורי אב";
                MSerialNumber.Texts = "מספר סידורי אם";
                SerialBox.Texts = "מספר סידורי";
                sexBirdBox.Texts = "             מין הציפור";
                zan.Texts = "             זן הציפור";
                ttzan.Texts = "             תת זן";
            }
            catch (CageMissingException)
            {
                MessageBoxClass.CageSerialMissingError();
            }
            catch (IDTakenException)
            {
                MessageBoxClass.IDExistsError(SerialBox.Texts);
            }
            catch (SerialException)
            {
                MessageBoxClass.CageSerialError();
                cageNumber.Texts = String.Empty;
            }
            catch (IDException ex)
            {
                MessageBoxClass.BirdSerialMissingError(ex.Message);
            }
            catch (BirdIDException ex)
            {
                MessageBoxClass.BirdSerialError(ex.Message);
            }

        }

        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBoxClass.writing_lettersError();
                e.Handled = true;
            }
        }

        private void cageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void FSerialNumber__TextChanged(object sender, EventArgs e)
        {

        }

        private void MSerialNumber__TextChanged(object sender, EventArgs e)
        {

        }

        private static string GetRandomSpecies()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var number = rand.Next(0, 2);
            if (number == 0)
                return "גולדיאן אמריקאי";
            else if (number == 1)
            {
                return "גולדיאן אירופאי";
            }
            return "גולדיאן אוסטרלי";
        }

        private static string GetRandomSubSpecies(string specises)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            if (specises == "גולדיאן אוסטרלי")
            {
                if (rand.Next(0, 1) == 0)
                    return "מרכז אוסטרליה";
                return "ערי חוף";
            }

            if (specises == "גולדיאן אירופאי")
            {
                if (rand.Next(0, 1) == 0)
                    return "מזרח אירופה";
                return "מערב אירופה";
            }
            if (specises == "גולדיאן אמריקאי")
            {
                var r = rand.Next(0, 2);
                if (r == 0)
                    return "צפון אמריקה";
                else if (r == 1)
                    return "מרכז אמריקה";

            }
            return "דרום אמריקה";
        }

        private void AddBirdFrom_Load(object sender, EventArgs e)
        {
            var birdListMale = FileControl.GetBird().Where(birds => birds.Sex == "זכר").ToList();

            if (birdListMale.Count == 0)
            {
                var rand = new Random(DateTime.Now.Millisecond);

                var spiecise = GetRandomSpecies();
                var subSpiecise = GetRandomSubSpecies(spiecise);
                var randomCage = FileControl.GetCageList()[0];

                var time = DateTime.Now.ToString("dd/MM/yyyy");
                string serial = rand.Next(1000, 10000).ToString();
                while (FileControl.GetBird().Any(b => b.Serial == serial))
                {
                    serial = rand.Next(1000, 10000).ToString();
                }


                FileControl.AddBird(serial, spiecise, subSpiecise, "זכר", "0", "1", randomCage.CageNumber, time);
            }
            foreach (BirdData b in birdListMale)
            {
                MSerialNumber.Items.Add(b.Serial);
            }

            var birdListFemail = FileControl.GetBird().Where(birds => birds.Sex == "נקבה").ToList();
            if (birdListMale.Count == 0)
            {
                var rand = new Random(DateTime.Now.Millisecond);

                var spiecise = GetRandomSpecies();
                var subSpiecise = GetRandomSubSpecies(spiecise);
                var randomCage = FileControl.GetCageList()[0];

                var time = DateTime.Now.ToString("dd/MM/yyyy");
                string serial = rand.Next(1000, 10000).ToString();
                while (FileControl.GetBird().Any(b => b.Serial == serial))
                {
                    serial = rand.Next(1000, 10000).ToString();
                }


                FileControl.AddBird(serial, spiecise, subSpiecise, "נקבה", "2", "3", randomCage.CageNumber, time);
            }
            foreach (BirdData b in birdListFemail)
            {
                FSerialNumber.Items.Add(b.Serial);
            }

            var cages = FileControl.GetCageList().ToList();
            foreach (CageData cage in cages)
            {
                cageNumber.Items.Add(cage.CageNumber);
            }
        }

        private void uiComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
