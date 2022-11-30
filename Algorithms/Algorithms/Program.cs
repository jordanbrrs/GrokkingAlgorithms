// See https://aka.ms/new-console-template for more information
using Algorithms;
using Algorithms.EarlyLateBinding;

int[] array = new int[5] { 5, 3, 6, 2, 10 };

//Console.WriteLine(String.Join(",", new SelectionSort().Sort(array)));

//decimal profitMargin = Math.Round((1 - 76.2355000M / 125) * 100, 2);
//decimal profitMargin2 = (1 - 76.2355000M / 125) * 100;
//Console.WriteLine($"ProfitMargin: {profitMargin}, ProfitMargin2: {profitMargin2}");

//Example of early binding
//EarlyBinding eb = new EarlyBinding();
//eb.Details("Jordan", "Guerra");
//eb.MyMethod();

//Example of late binding
dynamic obj = 4;
dynamic obj1 = 5.678;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj1.GetType());