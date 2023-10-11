using System;
using System.IO;

class Program
{
    static StreamWriter sw;

    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        
        sw.WriteLine(Math.Pow(2, N) - 1);
        Hanoi(N, 1, 2, 3);

        sw.Close();
    }

    static void Hanoi(int N, int start, int via, int dest)
    {
        if (N == 1) sw.WriteLine($"{start} {dest}");
        else
        {
            Hanoi(N - 1, start, dest, via);
            sw.WriteLine($"{start} {dest}");
            Hanoi(N - 1, via, start, dest);
        }
    }
}