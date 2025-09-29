using Tyuiu.GogolevVM.Sprint1.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("Введите X ");
        double x = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = Convert.ToInt32(ds.Calculate(x));
        Console.WriteLine(res);

        Console.ReadKey();
    }
}