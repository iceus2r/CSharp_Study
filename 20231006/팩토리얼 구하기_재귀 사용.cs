using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sw.WriteLine(Factorial(long.Parse(sr.ReadLine())));
        sw.Close();
    }

    static long Factorial(long N)
    {
        if (N == 0 || N == 1) return 1;
        else return N * Factorial(N - 1);
    }
}