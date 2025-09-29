using Tyuiu.GogolevVM.Sprint1.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                         *");
        Console.WriteLine("* Задание #4                                                                               *");
        Console.WriteLine("* Вариант #9                                                                               *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).                    *");
        Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                                        *");
        Console.WriteLine("Введите координату X1 : ");

        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату Y1 : ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату X2 : ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Y2 : ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = Convert.ToInt32(ds.DistanceBetweenDots(x1,y1,x2,y2));
        Console.WriteLine(res);
        Console.ReadKey();


    }
}