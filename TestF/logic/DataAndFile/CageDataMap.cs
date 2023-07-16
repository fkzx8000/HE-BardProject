using CsvHelper.Configuration;

namespace TestF.logic.DataAndFile
{
    public sealed class CageDataMap : ClassMap<CageData>
    {
        public CageDataMap()
        {
            Map(map => map.CageNumber).Name("CageNumber");
            Map(map => map.With).Name("With");
            Map(map => map.Length).Name("Length");
            Map(map => map.Hight).Name("Hight");
            Map(map => map.Material).Name("Material");
        }
    }
}
