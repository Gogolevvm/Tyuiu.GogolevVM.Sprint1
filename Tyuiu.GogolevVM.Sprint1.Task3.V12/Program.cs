using Tyuiu.GogolevVM.Sprint1.Task3.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
       DataService ds = new DataService();
       Console.Title = "Спринт #1 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
       Console.WriteLine("*************************************************************************************************");
       Console.WriteLine("* Спринт #1                                                                                     *");
       Console.WriteLine("* Тема: Базовые навыки работы в C#                                                              *");
       Console.WriteLine("* Задание #3                                                                                    *");
       Console.WriteLine("* Вариант #12                                                                                   *");
       Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                           *");
       Console.WriteLine("*************************************************************************************************");
       Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
       Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника по длинам двух катетов. *");  
       Console.WriteLine("*                                                                                               *");
       Console.WriteLine("*************************************************************************************************");
       Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                               *");
       Console.WriteLine("*************************************************************************************************");

        double a = 12;
        double b = 13;
        Console.WriteLine("* Катет треугольника A =  " + a);
        Console.WriteLine("* Катет треугольника B =  " + b);
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine(" Площадь треугольника = " + ds.TriangleArea(a,b));
        Console.ReadKey();





    }
}