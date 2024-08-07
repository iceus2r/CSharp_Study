using System;
using System.IO;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int N = int.Parse(sr.ReadLine());
int[] col = new int[N + 1];

int result = 0;

N_Queens(0);

sw.WriteLine(result);

sw.Close();

void N_Queens(int depth)
{
    if (Check(depth))
    {
        if (depth == N) //depth가 끝까지 갔을 때
        {
            result++;
        }
        else //depth가 끝까지 가지 않았을 때
        {
            for (int i = 1; i <= N; i++)
            {
                col[depth + 1] = i;
                N_Queens(depth + 1);
            }
        }
    }
}

bool Check(int depth)
{
    for (int i = 1; i < depth; i++)
    {
        if (col[depth] == col[i] || Math.Abs(col[depth] - col[i]) == depth - i)
        {
            return false;
        }
    }

    return true;
}