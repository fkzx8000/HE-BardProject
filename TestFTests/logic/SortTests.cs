using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestF.logic.DataAndFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.DataAndFile.Tests
{
    [TestClass()]
    public class SortTests
    {
        [TestMethod()]
        public void ConvertToArrTest()
        {
            // Arrange
            List<BirdData> data = new List<BirdData>
            {
                new BirdData { Serial = "2" },
                new BirdData { Serial = "1" },
                new BirdData { Serial = "3" }
            };

            // Act
            BirdData[] result = Sort.ConvertToArr(data);

            // Assert
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("2", result[0].Serial);
            Assert.AreEqual("1", result[1].Serial);
            Assert.AreEqual("3", result[2].Serial);
        }

        [TestMethod()]
        public void RegularSortTest()
        {
            // Arrange
            BirdData[] array = new BirdData[]
            {
                new BirdData { Serial = "2" },
                new BirdData { Serial = "1" },
                new BirdData { Serial = "3" }
            };

            // Act
            BirdData[] result = Sort.RegularSort(array);

            // Assert
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("1", result[0].Serial);
            Assert.AreEqual("2", result[1].Serial);
            Assert.AreEqual("3", result[2].Serial);
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            // Arrange
            BirdData[] array = new BirdData[]
            {
                new BirdData { Serial = "2" },
                new BirdData { Serial = "1" },
                new BirdData { Serial = "3" }
            };

            // Act
            BirdData[] result = Sort.QuickSort(array, 0, array.Length - 1);

            // Assert
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("1", result[0].Serial);
            Assert.AreEqual("2", result[1].Serial);
            Assert.AreEqual("3", result[2].Serial);
        }


        [TestMethod()]
        public void RegularSortTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QuickSortTest1()
        {
            Assert.Fail();
        }
    }
}