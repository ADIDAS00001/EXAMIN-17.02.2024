
int e=0,o=0,d=0,s=0;
int EvenCount(int n)
{
    for (int i = n; i >0; i/=10)
    {
        if(i%10%2==0)
        {
            e++;
        }
    }

    System.Console.Write($"Even:");
    return e;
}
System.Console.WriteLine(EvenCount(12345));
int OddCount(int n)
{
    for (int i = n; i >0; i/=10)
    {
        if(i%10%2!=0)
        {
            o++;
        }
    }
    System.Console.Write($"Odd:");
    return o;
}
System.Console.WriteLine(OddCount(12345));


int DigitCount(int n)
{
    for (int i = n; i >0; i/=10)
    {
        d++;
    }
    System.Console.Write($"DigitCount:");
    return d;
}
System.Console.WriteLine(DigitCount(12345));

int SumCount(int n)
{
    for (int i = n; i >0; i/=10)
    {
        s+=i%10;
    }
    System.Console.Write($"SumCount:");
    return s;
}
System.Console.WriteLine(SumCount(12345));
