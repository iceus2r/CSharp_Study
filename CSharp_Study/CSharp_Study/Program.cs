using System;
using System.IO;

class Stack
{
    int[] array = new int[1001];
    int size = 0;

    public void Push(int e)
    {
        size++;
        array[size] = e;
    }
    public int Pop()
    {
        int e = array[size];
        array[size] = default;
        size--;
        return e;
    }
    public int Count()
    {
        return size;
    }
    public bool isEmpty()
    {
        if (size == 0) return true;
        else return false;
    }
    public int Peek()
    {
        return array[size];
    }
}

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            string input = sr.ReadLine();
            if (input == ".") break;

            Stack stack = new Stack();

            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == '(' || input[j] == '[') stack.Push(input[j]);
                else if (input[j] == ')')
                {
                    if (stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(input[j]);
                        break;
                    }
                }
                else if (input[j] == ']')
                {
                    if (stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(input[j]);
                        break;
                    }
                }
            }

            if (stack.isEmpty()) sw.WriteLine("yes");
            else sw.WriteLine("no");
        }
        sw.Close();
    }
}