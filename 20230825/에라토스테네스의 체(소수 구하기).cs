using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = Console.ReadLine().Split();
        int M = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        bool[] array = new bool[N + 1];
        array[0] = true;
        array[1] = true;

        for (int i = 2; i <= N; i++)
        {
            if (array[i]) continue;
            for (int j = i * 2; j <= N; j += i)
            {
                array[j] = true;
            }
        }

        for (int i = M; i <= N; i++)
        {
            if (!array[i]) sw.WriteLine(i);
        }

        sw.Close();
    }
}