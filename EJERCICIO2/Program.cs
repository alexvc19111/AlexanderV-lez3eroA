class Program
{
    static void Main(string[] args)
    {
        double n1=0;
        Console.WriteLine("Ingrese un número");
        n1= Convert.ToDouble(Console.ReadLine());
        double nn=n1%2;
        if (nn==0)
        {
            Console.WriteLine("Es número par");
        }
        else 
        {
            Console.WriteLine("No es número par");
        }
    }
}