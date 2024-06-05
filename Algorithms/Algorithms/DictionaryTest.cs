namespace Algorithms
{
    internal class DictionaryTest
    {
        internal void Test()
        {
            Dictionary<Guid, string> dicCompanies = new Dictionary<Guid, string>();
            dicCompanies.Add(new Guid("455F067B-89C7-4AB9-A0A6-117EBD5A76EA"), "47063128000168");
            var foo = dicCompanies.Keys.ToList();
            var goo = dicCompanies.Values.ToList();
        }
    }
}
