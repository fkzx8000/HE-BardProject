using System;
using System.Linq;
using System.Text.RegularExpressions;
using TestF.logic;
using TestF.logic.Exceptions;

namespace TestF.files
{
    public class ArgumentTest
    {

       
        public static void TestUserName(string userName)
        {
            bool flag = Regex.IsMatch(userName, @"^(?=[a-zA-Z0-9]{6,8}$)((\D*\d\D*){0,2}|([a-zA-z]*))$");
            if (!flag)
                throw new UserNameException();
        }

        public static void TestPassword(string password)
        {
            bool flag = Regex.IsMatch(
                password,
                @"^(?=.{8,10}$)(((\W*\w\W*\D*\d\D*\w*\W\w*){1,})|((\W*\w\W*\w*\W\w*\D*\d\D*){1,})|((\D*\d\D*\W*\w\W*\w*\W\w*){1,})|((\D*\d\D*\w*\W\w*\W*\w\W*){1,})|((\w*\W\w*\W*\w\W*\D*\d\D*){1,})|((\w*\W\w*\D*\d\D*\W*\w\W*){1,}))$");
            if (!flag)
                throw new PasswordException();
        }

        public static void TestId(string id)
        {
            bool flag = Regex.IsMatch(id, @"^(?=.{9}$)\d*$");
            if (!flag)
                throw new IDException();
        }

        public static void TestCageSerial(string serial)
        {
            bool flag = Regex.IsMatch(serial, @"^(?=\w+)(([^a-zA-Z]*[a-zA-Z][^a-zA-Z]*\D*\d\D*){1,}||(\D*\d\D*[^a-zA-Z]*[a-zA-Z][^a-zA-Z]*){1,})$");
            if (!flag)
                throw new SerialException();
        }

        public static void TestCageDimensions(string with, string length, string hight)
        {
            bool withFlag = Regex.IsMatch(with, @"^\d+$");
            bool lengthFlag = Regex.IsMatch(length, @"^\d+$");
            bool hightFlag = Regex.IsMatch(hight, @"^\d+$");
            if (!withFlag || !lengthFlag || !hightFlag)
                throw new DimensionsException();
        }

        public static void TestBirdId(string id)
        {
            bool flag = Regex.IsMatch(id, @"^\d+$");
            if (!flag)
                throw new BirdIDException(id);
        }
    }
}
