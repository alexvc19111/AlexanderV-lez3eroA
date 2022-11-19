class Program
{
    static void Main(string[] args)
    {
        double n=0,x=0,c=0;
        Console.WriteLine("¿Cuantos números desea ingresar? :");
        c=Convert.ToDouble(Console.ReadLine());
        for(int i=0;i!=c;i++)
        {
            Console.WriteLine("Ingrese un número");
            n=Convert.ToDouble(Console.ReadLine());
            x=n+x;
        }
        Console.WriteLine("La suma entra de los "+c+" números es :"+x);
    }
}