class Program
{
    static void Main(string[] args)
    {
        double n1=0,n2=0,n3=0;
        Console.WriteLine("Ingrese el primer número");
        n1= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        n2= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número");
        n3= Convert.ToDouble(Console.ReadLine());
        if (n1>n2 & n1>n3)
        {
            Console.WriteLine("El número mayor es el número "+n1);
        }
        else
        {
            if(n2>n1 & n2>n3)
            {
                Console.WriteLine("El número mayor es el número "+n2);
            }
            else
            {
                Console.WriteLine("El número mayor es el número "+n3);
            }
        }
    }
}