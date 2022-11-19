class Program
{
    static void Main(string[] args)
    {
        string resp="S";
        double ladoa=0,ladob=0,ladoc=0;
        while(resp=="S"||resp=="s")
        {
        Console.WriteLine("Ingrese el primer lado");
        ladoa=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado");
        ladob=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer lado");
        ladoc=Convert.ToDouble(Console.ReadLine());
        if(ladoa==ladoc && ladoa==ladob)
        {
            Console.WriteLine("Los datos que ingresó pertenecen a un triangulo Equilátero");

        }
        if(ladoa==ladob && ladoa!=ladoc)
        {
            Console.WriteLine("Los datos que ingresó pertencen a un triangulo Isósceles");
        }
        if(ladoa!=ladob && ladoa!=ladoc)
        {
            Console.WriteLine("Los datos que ingresó pertencen a un triangulo Escaleno");
        }
        
        Console.WriteLine("¿Quiere continuar? S/N");
            string? v = Console.ReadLine();
            resp = v;
        }
    }
}