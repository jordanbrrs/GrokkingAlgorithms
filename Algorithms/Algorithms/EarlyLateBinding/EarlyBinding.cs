namespace Algorithms.EarlyLateBinding
{
    internal class EarlyBinding
    {
        const string s = "teste";
        readonly SelectionSort teste2 = new SelectionSort();

        public string Name { get; set; }
        public string Subject { get; set; }

        public EarlyBinding()
        {
            //teste2 = new SelectionSort();
        }

        public void Details(string name, string subject)
        {
            Name = name;
            Subject = subject;
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}
