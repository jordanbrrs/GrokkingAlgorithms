// See https://aka.ms/new-console-template for more information
using Algorithms;

int[] array = new int[5] { 5, 3, 6, 2, 10 };

Console.WriteLine(String.Join(",", new SelectionSort().Sort(array)));
