using Tyuiu.GogolevVM.Sprint1.Task3.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        double a = 12;
        double b = 17;

        Console.WriteLine(ds.Calculate(a, b));

    }
}