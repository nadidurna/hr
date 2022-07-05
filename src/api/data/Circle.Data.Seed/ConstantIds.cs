namespace Circle.Data.Seed
{
    public static class ConstantIds
    {
        public class User
        {
            public static Guid AdminId = new Guid("EBA9A89F-3E0C-474E-BEC6-273599A30214");
        }

        public class LookupType
        {
            public static Guid CountryId = new Guid("B9013C54-A5D8-4E7D-B71B-751C41771AD1");
            public static Guid CityId = new Guid("CEFA04AF-1431-4C7B-9C27-D58FD69238C1");
        }

        public class Lookup
        {
            public static Guid TurkiyeId = new Guid("A4DC8602-2BA4-41BF-9C0C-66B4A18C8756");
            public static Guid IstanbulId = new Guid("B78ACC2E-C096-4764-BBF4-FAB76C71F12F");
        }
    }
}