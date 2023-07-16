using CsvHelper.Configuration;

namespace TestF.logic.DataAndFile
{
    public sealed class UserDataMap : ClassMap<UserData>
    {
        public UserDataMap()
        {
            Map(map => map.userName).Name("userName");
            Map(map => map.password).Name("password");
            Map(map => map.id).Name("id");
        }
    }
}
