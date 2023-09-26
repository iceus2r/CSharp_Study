using System;

class Program
{
    static void Main()
    {
        string numstr1 = Console.ReadLine();
        string numstr2 = Console.ReadLine();

        int num1 = int.Parse(numstr1);
        int num2 = int.Parse(numstr2);

        Console.WriteLine(num1 * ((num2 % 10) / 1));
        Console.WriteLine(num1 * ((num2 % 100) / 10));
        Console.WriteLine(num1 * ((num2 % 1000) / 100));
        Console.WriteLine(num1 * num2);
    }
}