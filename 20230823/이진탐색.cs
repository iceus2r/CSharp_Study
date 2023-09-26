using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        int N = int.Parse(Console.ReadLine());
        int[] arrayN = new int[N];
        string[] inputN = Console.ReadLine().Split();
        for (int i = 0; i < N; i++)
        {
            arrayN[i] = int.Parse(inputN[i]);
        }
        Array.Sort(arrayN);

        int M = int.Parse(Console.ReadLine());
        int[] arrayM = new int[M];
        string[] inputM = Console.ReadLine().Split();
        for (int i = 0; i < M; i++)
        {
            arrayM[i] = int.Parse(inputM[i]);
        }

        for (int i = 0; i < M; i++)
        {
            BinarySearch(arrayN, N, arrayM[i], sb);
        }
        Console.WriteLine(sb);
    }

    static void BinarySearch(int[] array, int arrayLength, int number, StringBuilder sb)
    {
        int low = 0;
        int high = arrayLength - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (number < array[mid])
            {
                high = mid - 1;
            }
            else if (number == array[mid])
            {
                sb.Append("1 ");
                return;
            }
            else if (number > array[mid])
            {
                low = mid + 1;
            }
        }
        sb.Append("0 ");
        return;
    }
}