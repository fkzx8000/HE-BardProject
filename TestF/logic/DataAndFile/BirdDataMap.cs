using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.DataAndFile
{
    public sealed class BirdDataMap : ClassMap<BirdData>
    {
        public BirdDataMap()
        {
            Map(m => m.Serial).Name("Serial");
            Map(m => m.SpeciesBird).Name("SpeciesBird");
            Map(m => m.SubSpeciesBird).Name("SubSpeciesBird");
            Map(m => m.ExpirationDate).Name("ExpirationDate");
            Map(m => m.Sex).Name("Sex");
            Map(m => m.F_Serial).Name("F_Serial");
            Map(m => m.M_Serial).Name("M_Serial");
            Map(m => m.CageNumber).Name("CageNumber");
        }
    }
}
