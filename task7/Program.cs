
int sum=0;
int SumDigit(int a)
{
    if(a==0)
    {
        return 0;
    }
    else
    {
        SumDigit(a/10);
        sum+=a%10;
        return sum;
    }
}
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigit(a));