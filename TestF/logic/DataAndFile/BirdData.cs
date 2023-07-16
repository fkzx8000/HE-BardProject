using System;

namespace TestF.logic.DataAndFile
{
    [Serializable]

    public class BirdData : IEquatable<BirdData>, IComparable<BirdData>
    {
        public string Serial { get; set; }
        public string SpeciesBird { get; set; }
        public string SubSpeciesBird { get; set; }
        public string Sex { get; set; }
        public string ExpirationDate { get; set; }
        public string F_Serial { get; set; }
        public string M_Serial { get; set; }
        public string CageNumber { get; set; }

        public override int GetHashCode() => int.Parse(Serial);

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            BirdData objAsPart = obj as BirdData;

            if (objAsPart == null)
                return false;
            else return Equals(objAsPart);
        }

        public bool Equals(BirdData other)
        {
            if (other == null)
                return false;
            return (int.Parse(this.Serial).Equals(int.Parse(other.Serial)));
        }

        public int CompareTo(BirdData compareBird)
        {
            // A null value means that this object is greater.
            if (compareBird == null) return 1;

            else return (int.Parse(this.Serial).CompareTo(int.Parse(compareBird.Serial)));
        }

        public int SortBySerialAscending(string number1, string number2) => number1.CompareTo(number2);

    }

}
