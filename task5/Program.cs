


void IncrementArrayElements(ref int[] arr, ref int n)
{
    for (int i = 0; i < n; i++)
    {
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        arr[i]+=n;   
        Console.Write(arr[i]+" ");
    }
}
int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
IncrementArrayElements(ref arr,ref n);
