


void Repetition(string s, int a)
{
    if(a==0)
    {
        return ;
    }
    else
    {
        System.Console.Write(s);
        Repetition(s,a-1);
    }
}
string s=Console.ReadLine();
int a=Convert.ToInt32(Console.ReadLine());
Repetition(s,a);