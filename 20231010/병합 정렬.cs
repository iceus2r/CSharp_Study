using System;
using System.IO;

class Program
{
    //saveList를 사용하여 끝까지 계산한 후 index로 출력하였으나 시간초과됨
    //saveList를 count로 변경하고 K에 도달하면 return하게 하였으나 시간초과됨
    //Merge에서 temp를 계속 생성하는데 시간이 걸릴거라 추측하여 temp를 static으로 변경 후 성공

    static int K;
    static int[] temp;
    static int count = 0;
    static int saved;
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = sr.ReadLine().Split();
        int N = int.Parse(input[0]);
        K = int.Parse(input[1]);
        int[] array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        temp = new int[N];

        Merge_Sort(array, 0, N - 1);
        if (count == K) sw.WriteLine(saved);
        else sw.WriteLine(-1);

        sw.Close();
    }

    static void Merge_Sort(int[] array, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;
            Merge_Sort(array, start, mid);
            Merge_Sort(array, mid + 1, end);
            Merge(array, start, mid, end);
        }
    }
    static void Merge(int[] array, int start, int mid, int end)
    {
        if (count == K) return;

        int i = start;
        int j = mid + 1;
        int t = 0;

        while (i <= mid && j <= end)
        {
            if (array[i] <= array[j])
            {
                temp[t] = array[i];
                t++;
                i++;
            }
            else
            {
                temp[t] = array[j];
                t++;
                j++;
            }
        }
        while (i <= mid)
        {
            temp[t] = array[i];
            t++;
            i++;
        }
        while (j <= end)
        {
            temp[t] = array[j];
            t++;
            j++;
        }

        i = start;
        t = 0;
        while (i <= end)
        {
            count++;
            saved = temp[t];
            if (count == K) return;
            array[i] = temp[t];
            i++;
            t++;
        }
    }
}