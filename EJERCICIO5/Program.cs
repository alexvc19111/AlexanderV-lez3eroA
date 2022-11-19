class Program
{
    static void Main(string[] args)
    {
        double n=0,x=0;
        for(int i=1;i<=8;i++)
        {
            Console.WriteLine("Ingrese un número");
            n=Convert.ToDouble(Console.ReadLine());
            x=n+x;
        }
        Console.WriteLine("La suma entra de los 8 números es :"+x);
    }
}