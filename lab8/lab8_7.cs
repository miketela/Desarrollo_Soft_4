internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrió la aplicación");
    }
}

sealed class ClaseBase
{
    public void test()
    {
    }

    public void moreTesting()
    {
    }
}

class ClaseHijo : ClaseBase
{
}