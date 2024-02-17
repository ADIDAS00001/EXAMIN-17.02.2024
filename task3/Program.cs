

int b=0,c=0,d=0,e=0;
string IsPalindrome(int n)
{
    b=n%10;
    c=n/10%10;
    d=n/100%10;
    e=n/1000%10;
    if(b==e && c==d)
    {
        return "YES";
    }
    else
    {
        return "NO";
    }
}
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(IsPalindrome(n));