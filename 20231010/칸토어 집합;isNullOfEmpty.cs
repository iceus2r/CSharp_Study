using System;
using System.IO;

class Program
{
    //ArgumentNull 오류가 계속 출력됨
    //마지막 입력 확인할 때 string.IsNullOrEmpty로 확인했더니 성공

    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            string input = sr.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            int N = int.Parse(input);
            int powered = (int)Math.Pow(3, N);
            bool[] cantorSet = new bool[powered];
            Cantor(cantorSet, 0, powered - 1);

            foreach (bool e in cantorSet)
            {
                if (!e) sw.Write('-');
                else sw.Write(' ');
            }
            sw.WriteLine();
        }

        sw.Close();
    }

    static void Cantor(bool[] cantorSet, int start, int end)
    {
        int divide3 = (end + 1 - start) / 3;

        if (end - start == 0) return;
        else
        {
            Cantor(cantorSet, start, start + divide3 - 1);
            for (int i = 0; i < divide3; i++)
            {
                cantorSet[start + divide3 + i] = true;
            }
            Cantor(cantorSet, end - divide3 + 1, end);
        }
    }
}