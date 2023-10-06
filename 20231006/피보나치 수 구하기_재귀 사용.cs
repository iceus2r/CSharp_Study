using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sw.WriteLine(Fibonacci(int.Parse(sr.ReadLine())));
        sw.Close();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}