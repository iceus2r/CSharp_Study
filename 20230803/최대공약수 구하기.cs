static int GetGCD(int a, int b)
{
    if (a % b == 0) return b;
    else return GetGCD(b, a % b);
}