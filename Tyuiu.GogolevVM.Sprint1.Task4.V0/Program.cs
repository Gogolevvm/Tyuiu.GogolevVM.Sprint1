using Tyuiu.GogolevVM.Sprint1.Task4.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x,y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(ds.Calculate(x,y));
        Console.ReadKey();
    }
}