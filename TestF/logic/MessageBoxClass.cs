using System.Windows.Forms;

namespace TestF.logic
{
    public class MessageBoxClass
    {
        public static void writing_lettersError() { MessageBox.Show("לא ניתן לרשום בתיבה זו אותיות", "שגיאה"); }

        public static void UserNameError() { MessageBox.Show("User name must be 6-8 characters long and max 2 digits", "Error"); }
        public static void PasswordError() { MessageBox.Show("Password must be 8-10 characters long and mast contain at least one digit character and speshal character", "Error"); }
        public static void IdError() { MessageBox.Show("ID must be 9 digits long", "Error"); }

        public static void UserSuccessfullyRegisters(string user) { MessageBox.Show( user + " was successfully added", "Success"); }

        public static void UserExistsError(string userName) { MessageBox.Show(userName + " already exists", "Error"); }
        public static void IDExistsError(string ID) { MessageBox.Show(ID + " already exists", "Error"); }

        public static void UserOrPasswordError() { MessageBox.Show("User name or password is incorrect", "Error"); }

        public static void CageSerialError() { MessageBox.Show("Serial have at least on digit and one character", "Error"); }
        public static void BirdSerialError(string id) { MessageBox.Show( id + " must be at lest one digit", "Error"); }
        public static void CageDimensionsError() { MessageBox.Show("Cage Dimensions must be positive integers", "Error"); }
        public static void CageSerialExistsError(string serial) { MessageBox.Show(serial + " already exists", "Error"); }

        public static void CageSuccessfullyAdded(string serial) { MessageBox.Show(serial + " was successfully added", "Success"); }
        public static void BirdSerialMissingError(string id) { MessageBox.Show(id + " is missing", "Error"); }
        public static void CageSerialMissingError() { MessageBox.Show("Cage is missing", "Error"); }

        public static void BirdSuccessfullyAdded(string Bird) { MessageBox.Show(Bird + " was successfully added", "Success"); }
    }
}
