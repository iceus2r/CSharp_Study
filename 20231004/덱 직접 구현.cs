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