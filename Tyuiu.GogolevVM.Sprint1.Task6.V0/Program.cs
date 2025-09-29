using Tyuiu.GogolevVM.Sprint1.Task6.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.WorkWithText(str));

        Console.ReadKey();


    }
}