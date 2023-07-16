using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TestF.logic.Exceptions;

namespace TestF.logic.DataAndFile
{
    internal class FileControl
    {
        // Bird File controls
        public static List<BirdData> GetBird()
        {
            string fileName = System.Environment.CurrentDirectory + "/BirdData.csv";

            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<BirdDataMap>();
                var records = csv.GetRecords<BirdData>().ToList();
                return records;
            }
        }

        public static void AddBird(string serial, string speciesBird, string subSpeciesBird, string sex, string F_serial, string M_serial, string cageNumber, string expirationDate)
        {
            string fileName = Path.Combine(Environment.CurrentDirectory, "BirdData.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };

            // Check if the file exists and if the given serial number already exists in the file.
            var data = new List<BirdData>
                {
                    new BirdData
                    {
                    Serial = serial,
                    SpeciesBird = speciesBird,
                    Sex = sex,
                    SubSpeciesBird = subSpeciesBird,
                    F_Serial = F_serial,
                    M_Serial = M_serial,
                    CageNumber = cageNumber,
                    ExpirationDate = expirationDate,
                    }
                };


            try
            {
                if (!FileControl.GetCageList().Any(number => number.CageNumber == cageNumber))
                    throw new CageMissingException();
                if (FileControl.GetBird().Any(number => number.CageNumber == serial))
                    throw new IDTakenException();
                if (!FileControl.GetBird().Any(b => b.Serial == F_serial))
                    throw new IDException(F_serial);
                if (!FileControl.GetBird().Any(b => b.Serial == M_serial))
                    throw new IDException(M_serial);

                if (!File.Exists(fileName))
                {
                    using (var writer = new StreamWriter(fileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(data);
                    }
                }
                using (var stream = File.Open(fileName, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(data);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public static List<UserData> GetUserList()
        {
            string fileName = System.Environment.CurrentDirectory + "/UserData.csv";

            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<UserDataMap>();
                var records = csv.GetRecords<UserData>().ToList();
                return records;
            }
        }

        public static void RegisterUser(string UserName, string Password, string Id)
        {

            string fileName = Path.Combine(Environment.CurrentDirectory, "UserData.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };

            var User = new List<UserData>
            {
                new UserData
                {
                    userName = UserName,
                    password = Password,
                    id = Id
                }
            };

            try
            {
                if (File.Exists(fileName) && GetUserList().Any(user => user.userName == UserName))
                {
                    throw new UserNameTakenException();
                }
                if (File.Exists(fileName) && GetUserList().Any(user => user.id == Id))
                {
                    throw new IDTakenException();
                }
                using (var stream = File.Open(fileName, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(User);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public static List<CageData> GetCageList()
        {
            string fileName = System.Environment.CurrentDirectory + "/CageData.csv";

            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<CageDataMap>();
                var records = csv.GetRecords<CageData>().ToList();
                return records;
            }
        }

        public static void AddCage(string cageNumber, string with, string Length, string hight, string material)
        {
            if (string.IsNullOrEmpty(cageNumber))
            {
                throw new ArgumentException($"'{nameof(cageNumber)}' cannot be null or empty.", nameof(cageNumber));
            }

            if (string.IsNullOrEmpty(with))
            {
                throw new ArgumentException($"'{nameof(with)}' cannot be null or empty.", nameof(with));
            }

            if (string.IsNullOrEmpty(Length))
            {
                throw new ArgumentException($"'{nameof(Length)}' cannot be null or empty.", nameof(Length));
            }

            if (string.IsNullOrEmpty(hight))
            {
                throw new ArgumentException($"'{nameof(hight)}' cannot be null or empty.", nameof(hight));
            }

            if (string.IsNullOrEmpty(material))
            {
                throw new ArgumentException($"'{nameof(material)}' cannot be null or empty.", nameof(material));
            }

            string fileName = Path.Combine(Environment.CurrentDirectory, "CageData.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };

            var Cage = new List<CageData>
            {
                new CageData
                {
                    CageNumber = cageNumber,
                    With = with,
                    Length = Length,
                    Hight = hight,
                    Material = material
                }
            };

            try
            {
                if (File.Exists(fileName) && GetCageList().Any(number => number.CageNumber == cageNumber))
                {
                    throw new CageNumberTakenException();
                }
                if (!File.Exists(fileName))
                {
                    using (var writer = new StreamWriter(fileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(Cage);
                    }
                }
                else
                {
                    using (var stream = File.Open(fileName, FileMode.Append))
                    using (var writer = new StreamWriter(stream))
                    using (var csv = new CsvWriter(writer, config))
                    {
                        csv.WriteRecords(Cage);
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }

        }

        public static void EditCageRecord(string cageNumber, string with, string length, string hight, string material)
        {
            string fileName = Path.Combine(Environment.CurrentDirectory, "CageData.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };

            CageData newRecord = new CageData
            {
                CageNumber = cageNumber,
                With = with,
                Length = length,
                Hight = hight,
                Material = material
            };
            List<CageData> data = GetCageList();
            data.RemoveAll(cage => cage.CageNumber == cageNumber);
            data.Add(newRecord);

            try
            {
                using (var writer = new StreamWriter(fileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(data);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public static void EditBirdRecord(string serial, string speciesBird, string subSpeciesBird, string sex, string F_serial, string M_serial, string cageNumber, string expirationDate)
        {
            string fileName = Path.Combine(Environment.CurrentDirectory, "BirdData.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };

            BirdData newRecord = new BirdData
            {  
                Serial = serial,
                SpeciesBird = speciesBird,
                Sex = sex,
                SubSpeciesBird = subSpeciesBird,
                F_Serial = F_serial,
                M_Serial = M_serial,
                CageNumber = cageNumber,
                ExpirationDate = expirationDate
            };

            List<BirdData> data = GetBird();
            data.RemoveAll(si => si.Serial == serial);
            data.Add(newRecord);

            try
            {
                if (!GetCageList().Any(number => number.CageNumber == cageNumber))
                    throw new CageMissingException();
                using (var writer = new StreamWriter(fileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(data);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
