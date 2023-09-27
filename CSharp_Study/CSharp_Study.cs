using System;
using System.IO;

class Queue
{
    int[] array;
    int indFront;
    int indBack;

    public Queue (int N)
    {
        array = new int[N];
        indFront = 0;
        indBack = 0;
    }

    public void Push(int e)
    {
        array[indBack] = e;
        indBack++;
    }
    public int Pop()
    {
        int e = array[indFront];
        array[indFront] = default;
        indFront++;
        return e;
    }
    public int Count()
    {
        return indBack - indFront;
    }
    public bool isEmpty()
    {
        if (indFront == indBack) return true;
        else return false;
    }
    public int Front()
    {
        return array[indFront];
    }
    public int Back()
    {
        return array[indBack - 1];
    }
}

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = sr.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        int cntReturn = 1;

        Queue queue = new Queue(N + N * K);
        for (int i = 1; i <= N; i++)
        {
            queue.Push(i);
        }

        sw.Write("<");
        while (queue.Count() > 1)
        {
            if (cntReturn != K)
            {
                queue.Push(queue.Pop());
                cntReturn++;
            }
            else
            {
                sw.Write(queue.Pop());
                sw.Write(", ");
                cntReturn = 1;
            }
        }
        sw.Write(queue.Pop());
        sw.WriteLine(">");
        sw.Close();
    }
}