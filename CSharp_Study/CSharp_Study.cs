using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        HashSet<string> hashSet = new HashSet<string>();
        int isAppeared = 0;
        //input[0] input[1] 나눠서 따로 계산
        //총총이 제외 겹치는 사람 계산
        for (int i = 0; i < N; i++)
        {
            string[] input = sr.ReadLine().Split();
            if (input[0] == "ChongChong" || input[1] == "ChongChong")
            {
                if (hashSet.Add(input[0]) || hashSet.Add(input[1])) isAppeared = 1;
            }
            else
            {
                if (hashSet.Contains(input[0])) hashSet.Add(input[1]);
                else if (hashSet.Contains(input[1])) hashSet.Add(input[0]);
            }
        }
        sw.WriteLine(hashSet.Count + isAppeared);

        sw.Close();
    }
}