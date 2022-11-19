class Ejercicio10
{
    static void Main(string[] args)
    {
        int fac=1;
        Console.WriteLine("Ingrese el número entero del cual quiere calcular su factorial :");
        int n=Convert.ToInt32(Console.ReadLine());
        int n2=n;
        for(int x=1;x<=n;x++)
        {
            fac=x*fac;
        }
        Console.WriteLine("El factorial de "+n+" es igual a :"+fac);
    }
}