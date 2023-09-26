using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int a = N;
        int count = 0;
        
        while (true)
        {
            int result = (((a % 10) * 10) + (((a / 10) + (a % 10)) % 10));
            count++;
            if (result == N)
            {
                Console.WriteLine(count);
                break;
            }
            else
            {
                a = result;
            }
        }
    }
}