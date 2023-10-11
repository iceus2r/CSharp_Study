using System;
using System.IO;

class Program
{
    static StreamWriter sw;

    static int N;
    static int M;
    static int[] order;
    static bool[] check;

    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = sr.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        order = new int[M];
        check = new bool[N];

        DFS(0);

        sw.Close();
    }

    static void DFS(int digit)
    {
        if (digit == M)
        {
            foreach (int num in order) sw.Write($"{num} ");
            sw.WriteLine();
            return;
        }
        //if (order[digit] > order[digit - 1])
        for (int i = 0; i < N; i++)
        {
            if (!check[i])
            {
                check[i] = true;
                order[digit] = i + 1;
                DFS(digit + 1);
                check[i] = false;
            }
        }
    }
}