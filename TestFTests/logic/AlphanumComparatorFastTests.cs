using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestF.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestF.logic.DataAndFile;

namespace TestF.logic.Tests
{
    [TestClass()]
    public class AlphanumComparatorFastTests
    {
        [TestMethod()]
        public void CompareTest()
        {
            // Arrange
            AlphanumComparatorFast comparator = new AlphanumComparatorFast();
            CageData cageData1 = new CageData { CageNumber = "Cage10" };
            CageData cageData2 = new CageData { CageNumber = "Cage2" };
            CageData cageData3 = new CageData { CageNumber = "Cage5" };
            CageData cageData4 = new CageData { CageNumber = "Cage3" };

            List<CageData> cageDataList = new List<CageData> { cageData1, cageData2, cageData3, cageData4 };

            // Act
            cageDataList.Sort(comparator);

            // Assert
            Assert.AreEqual("Cage2", cageDataList[0].CageNumber);
            Assert.AreEqual("Cage3", cageDataList[1].CageNumber);
            Assert.AreEqual("Cage5", cageDataList[2].CageNumber);
            Assert.AreEqual("Cage10", cageDataList[3].CageNumber);
        }
    }
}
