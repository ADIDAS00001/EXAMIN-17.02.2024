


int SumOfDigits(int n)
{
    int sum=0;
    for (int i = n; i > 0; i/=10)
    {
        sum+=i%10;
    }
    System.Console.Write($"The sum of the digits of the number {n} is : ");
    return sum;
}
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine( SumOfDigits(n));