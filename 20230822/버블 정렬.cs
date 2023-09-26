using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}