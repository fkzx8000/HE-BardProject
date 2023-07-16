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

        public AddBirdFrom()
        {
            InitializeComponent();
        }

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
            else
                ttzan.Items.AddRange(new object[] { "             תת זן" });


        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input values
                ArgumentTest.TestBirdId(SerialBox.Texts);
                ArgumentTest.TestBirdId(FSerialNumber.Texts);
                ArgumentTest.TestBirdId(MSerialNumber.Texts);
                ArgumentTest.TestCageSerial(cageNumber.Texts);

                // Add bird to the file using the input values
                FileControl.AddBird(SerialBox.Texts, zan.Texts, ttzan.Texts, sexBirdBox.Texts, FSerialNumber.Texts, MSerialNumber.Texts, cageNumber.Texts, DateBirthBox.Value.ToString("dd/MM/yyyy"));

                // Show success message box with the added bird's serial number
                MessageBoxClass.BirdSuccessfullyAdded(SerialBox.Texts);

                // Reset input fields to their default values
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
                // Show error message box for missing cage serial number
                MessageBoxClass.CageSerialMissingError();
            }
            catch (IDTakenException)
            {
                // Show error message box for duplicate bird ID
                MessageBoxClass.IDExistsError(SerialBox.Texts);
            }
            catch (SerialException)
            {
                // Show error message box for invalid cage serial number
                MessageBoxClass.CageSerialError();
                cageNumber.Texts = String.Empty;
            }
            catch (IDException ex)
            {
                // Show error message box for missing bird ID
                MessageBoxClass.BirdSerialMissingError(ex.Message);
            }
            catch (BirdIDException ex)
            {
                // Show error message box for invalid bird ID
                MessageBoxClass.BirdSerialError(ex.Message);
            }
        }

        //---Checking the correctness of the keys
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




        private static string GetRandomSpecies()
        {
            // Create a new random number generator based on the current time in milliseconds
            var rand = new Random(DateTime.Now.Millisecond);

            // Generate a random number between 0 and 2
            var number = rand.Next(0, 2);

            // Check the generated number and return the corresponding species
            if (number == 0)
                return "גולדיאן אמריקאי";
            else if (number == 1)
                return "גולדיאן אירופאי";

            // If the generated number is not 0 or 1, return "גולדיאן אוסטרלי" as the default species
            return "גולדיאן אוסטרלי";
        }

        private static string GetRandomSubSpecies(string specises)
        {
            // Create a new random number generator based on the current time in milliseconds
            var rand = new Random(DateTime.Now.Millisecond);

            // Check the provided species and generate a random subspecies accordingly
            if (specises == "גולדיאן אוסטרלי")
            {
                // Generate a random number between 0 and 1
                if (rand.Next(0, 1) == 0)
                    return "מרכז אוסטרליה";

                // If the generated number is not 0, return "ערי חוף" as the default subspecies
                return "ערי חוף";
            }

            if (specises == "גולדיאן אירופאי")
            {
                // Generate a random number between 0 and 1
                if (rand.Next(0, 1) == 0)
                    return "מזרח אירופה";

                // If the generated number is not 0, return "מערב אירופה" as the default subspecies
                return "מערב אירופה";
            }

            if (specises == "גולדיאן אמריקאי")
            {
                // Generate a random number between 0 and 2
                var r = rand.Next(0, 2);

                // Check the generated number and return the corresponding subspecies
                if (r == 0)
                    return "צפון אמריקה";
                else if (r == 1)
                    return "מרכז אמריקה";
            }

            // If none of the specified species matched, return "דרום אמריקה" as the default subspecies
            return "דרום אמריקה";
        }


        private void AddBirdFrom_Load(object sender, EventArgs e)
        {
            // Get a list of male birds from the file using FileControl.GetBird() method
            // and filter the list to contain only birds with sex "זכר"
            var birdListMale = FileControl.GetBird().Where(birds => birds.Sex == "זכר").ToList();

            // Check if there are no male birds in the list
            if (birdListMale.Count == 0)
            {
                // Create a new random number generator based on the current time in milliseconds
                var rand = new Random(DateTime.Now.Millisecond);

                // Generate a random species and subspecies for the new bird
                var species = GetRandomSpecies();
                var subSpecies = GetRandomSubSpecies(species);

                // Get the first cage from the cage list using FileControl.GetCageList()[0]
                var randomCage = FileControl.GetCageList()[0];

                // Get the current date and time as a string in the format "dd/MM/yyyy"
                var time = DateTime.Now.ToString("dd/MM/yyyy");

                // Generate a random serial number for the new bird
                string serial = rand.Next(1000, 10000).ToString();

                // Check if the generated serial number is already used by any existing bird
                while (FileControl.GetBird().Any(b => b.Serial == serial))
                {
                    // If the serial number is already used, generate a new one
                    serial = rand.Next(1000, 10000).ToString();
                }

                // Add the new bird to the file using FileControl.AddBird() method
                FileControl.AddBird(serial, species, subSpecies, "זכר", "0", "1", randomCage.CageNumber, time);
            }

            // Iterate over the male bird list and add their serial numbers to the MSerialNumber.Items collection
            foreach (BirdData b in birdListMale)
            {
                MSerialNumber.Items.Add(b.Serial);
            }

            // Get a list of female birds from the file using FileControl.GetBird() method
            // and filter the list to contain only birds with sex "נקבה"
            var birdListFemale = FileControl.GetBird().Where(birds => birds.Sex == "נקבה").ToList();

            // Check if there are no female birds in the list
            if (birdListFemale.Count == 0)
            {
                // Create a new random number generator based on the current time in milliseconds
                var rand = new Random(DateTime.Now.Millisecond);

                // Generate a random species and subspecies for the new bird
                var species = GetRandomSpecies();
                var subSpecies = GetRandomSubSpecies(species);

                // Get the first cage from the cage list using FileControl.GetCageList()[0]
                var randomCage = FileControl.GetCageList()[0];

                // Get the current date and time as a string in the format "dd/MM/yyyy"
                var time = DateTime.Now.ToString("dd/MM/yyyy");

                // Generate a random serial number for the new bird
                string serial = rand.Next(1000, 10000).ToString();

                // Check if the generated serial number is already used by any existing bird
                while (FileControl.GetBird().Any(b => b.Serial == serial))
                {
                    // If the serial number is already used, generate a new one
                    serial = rand.Next(1000, 10000).ToString();
                }

                // Add the new bird to the file using FileControl.AddBird() method
                FileControl.AddBird(serial, species, subSpecies, "נקבה", "2", "3", randomCage.CageNumber, time);
            }

            // Iterate over the female bird list and add their serial numbers to the FSerialNumber.Items collection
            foreach (BirdData b in birdListFemale)
            {
                FSerialNumber.Items.Add(b.Serial);
            }

            // Get a list of all cages from the file using FileControl.GetCageList() method
            var cages = FileControl.GetCageList().ToList();

            // Iterate over the cage list and add the cage numbers to the cageNumber.Items collection
            foreach (CageData cage in cages)
            {
                cageNumber.Items.Add(cage.CageNumber);
            }
        }


    }
}
