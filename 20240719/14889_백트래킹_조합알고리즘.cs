using System;
using System.IO;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int N = int.Parse(sr.ReadLine());
int[][] S = new int[N][];

int half = N / 2;
int[] order = new int[N];
bool[] check = new bool[N];
int result = int.MaxValue;

for (int i = 0; i < N; i++)
{
    S[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
}

DFS(0);

sw.WriteLine(result);

sw.Close();

void DFS(int depth)
{
    if (depth == half)
    {
        Calculate();
        return;
    }

    for (int i = 0; i < N; i++)
    {
        if (depth > 0 && order[depth - 1] > i + 1) continue;
        if (!check[i])
        {
            check[i] = true;
            order[depth] = i + 1;
            DFS(depth + 1);
            order[depth] = 0;
            check[i] = false;
        }
    }
}

void Calculate()
{
    int teamA = 0;
    int teamB = 0;

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (check[i] == true && check[j] == true) teamA += S[i][j];
            if (check[i] == false && check[j] == false) teamB += S[i][j];
        }
    }

    int diff = teamA - teamB;
    if (diff < 0) diff *= -1;

    if (diff < result) result = diff;
}