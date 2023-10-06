using System;
using System.IO;

class Program
{
    static int count = 0;
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int T = int.Parse(sr.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string S = sr.ReadLine();
            sw.WriteLine($"{isPalindrome(S, 0, S.Length - 1)} {count}");
            count = 0;
        }

        sw.Close();
    }

    static int isPalindrome(string S, int left, int right)
    {
        count++;
        if (left >= right) return 1;
        else if (S[left] != S[right]) return 0;
        else return isPalindrome(S, left + 1, right - 1);
    }
}