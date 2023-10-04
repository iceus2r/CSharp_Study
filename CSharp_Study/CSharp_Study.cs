using System;
using System.IO;

class Deque
{
    int[] array;
    int indFront;
    int indRear;

    public Deque (int N)
    {
        array = new int[N * 2 + 1];
        indFront = N;
        indRear = N;
    }

    public void InsertFront(int e)
    {
        indFront--;
        array[indFront] = e;
    }
    public void InsertRear(int e)
    {
        array[indRear] = e;
        indRear++;
    }
    public int DeleteFront()
    {
        int e = array[indFront];
        array[indFront] = default;
        indFront++;
        return e;
    }
    public int DeleteRear()
    {
        indRear--;
        int e = array[indRear];
        array[indRear] = default;
        return e;
    }
    public int Count()
    {
        return indRear - indFront;
    }
    public bool isEmpty()
    {
        if (indFront == indRear) return true;
        else return false;
    }
    public int GetFront()
    {
        return array[indFront];
    }
    public int GetRear()
    {
        return array[indRear - 1];
    }
}

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        int[] number = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        Deque deque = new Deque(N * N);

        for (int i = 0; i < N; i++)
        {
            deque.InsertRear(number[i]);
        }

        int a = deque.DeleteFront();
        sw.Write(1);
        while (!deque.isEmpty())
        {
            sw.Write(" ");

            if (a > 0)
            {
                for (int i = 1; i < a; i++) deque.InsertRear(deque.DeleteFront());
                a = deque.DeleteFront();
                sw.Write(a);
            }
            else
            {
                for (int i = -a; i > 1; i--) deque.InsertFront(deque.DeleteRear());
                a = deque.DeleteRear();
                sw.Write(a);
            }
        }
        sw.Close();
    }
}