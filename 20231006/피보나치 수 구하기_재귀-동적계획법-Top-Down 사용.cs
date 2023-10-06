using System;
using System.IO;

class Program
{
    static int[] table;

    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(sr.ReadLine());
        table = new int[n + 1];
        sw.WriteLine(Fibonacci(n));

        sw.Close();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            table[n] = n;
            return table[n];
        }

        if (table[n] > 0) return table[n];

        table[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        return table[n];
    }
}