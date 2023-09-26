class Stack
{
    int[] array = new int[1000001];
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