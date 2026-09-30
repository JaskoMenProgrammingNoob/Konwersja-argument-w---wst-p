class Program
{


    static void Main(string[] args)
    {
        int zmienna1 = 0;
        int zmienna2 = 0;
        Console.WriteLine("Liczba wprowadzonych argumentów: {0}", args.Length);
        if (args.Length < 2)
        {
            Console.WriteLine("Należy podać dwa argumenty w wierszu poleceń!");
            return;
        }
        try
        {
            zmienna1 = int.Parse(args[0]);
            zmienna2 = int.Parse(args[1]);
        }
        catch(Exception)
        {
            Console.WriteLine("Jeden z argumentów nie jest liczbą!");
            return;
        }
        Console.Write("Wynik działania {0} + {1} = ", args);
        Console.Write($"{zmienna1 + zmienna2}");
    }
}