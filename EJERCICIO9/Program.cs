class Program
{
    static void Main(string[] args)
    {
        float suma=0;
        float x2=5;
        for(int x=0;x<=5;x++)
        {
            float x3=x2-x;
            suma=suma+x3;
        }
        float media=suma/x2;
        Console.WriteLine("Media aritmetica es igual a :"+media);
    }
}