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