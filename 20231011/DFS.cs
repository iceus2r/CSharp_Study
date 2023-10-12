using System;
using System.IO;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int N;
int M;
int[] order;
bool[] check;

string[] input = sr.ReadLine().Split();
N = int.Parse(input[0]);
M = int.Parse(input[1]);
order = new int[M];
check = new bool[N];

DFS(0);

sw.Close();

void DFS(int digit)
{
    if (digit == M)
    {
        foreach (int num in order) sw.Write($"{num} ");
        sw.WriteLine();
        return;
    }

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