


int a=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[a];
for(int i=0;i<a;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int k=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    System.Console.Write(arr[i]+" ");
}
for (int i = k+1; i <a; i++)
{
    System.Console.Write(arr[i]+ " ");
}