using System;

namespace TestF.logic.DataAndFile
{
    [Serializable]
    public class CageData : IEquatable<CageData>, IComparable<CageData>
    {
        public string CageNumber { get; set; }
        public string With { get; set; }
        public string Length { get; set; }
        public string Hight { get; set; }
        public string Material { get; set; }

        public override int GetHashCode() => CageNumber.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            CageData objAsPart = obj as CageData;

            if (objAsPart == null) 
                return false;
            else return Equals(objAsPart);
        }

        public bool Equals(CageData other)
        {
            if (other == null) 
                return false;
            return (this.CageNumber.Equals(other.CageNumber));
        }

        public int CompareTo(CageData compareCage)
        {
            // A null value means that this object is greater.
            if (compareCage == null)
                return 1;

            else
                return this.CageNumber.CompareTo(compareCage.CageNumber);
        }

        public int SortByCageNumberAscending(string number1, string number2) => number1.CompareTo(number2);
    }
}
