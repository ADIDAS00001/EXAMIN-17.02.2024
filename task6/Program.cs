


void Swap(ref int a, ref int b)
{
    int c=0;
    c=a;
    a=b;
    b=c;
    System.Console.Write($"x = {a}\ny = {b}");
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
Swap(ref a,ref b);