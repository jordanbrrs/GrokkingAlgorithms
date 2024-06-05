namespace NetResources
{
    internal class Yield
    {
        internal List<int> GenerateSequence(int n) {
            var list = new List<int>();
            for (int i = 0; i < n; i++) { 
                list.Add(i);
            }
            return list;
        }

        internal IEnumerable<int> GenerateSequenceYield(int n)
        {            
            for (int i = 0; i < n; i++)
            {
                yield return i;
            }         
        }
    }
}
