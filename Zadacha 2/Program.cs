using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }       


    }
}