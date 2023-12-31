using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = sr.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        int[,] table = new int[N + 1, K + 1];
        
        for (int i = 0; i <= N; i++)
        {
            for (int j = 0; j <= Math.Min(i, K); j++)
            {
                if (j == 0 || j == i) table[i, j] = 1;
                else table[i, j] = table[i - 1, j - 1] + table[i - 1, j];
            }
        }
        sw.WriteLine(table[N, K]);
        sw.Close();
    }
}


//             _1
//           _1  _1
//         _1  _2  _1
//       _1  _3  _3  _1
//     _1  _4  _6  _4  _1
//   _1  _5  10  10  _5  _1
// _1  _6  15  20  15  _6  _1