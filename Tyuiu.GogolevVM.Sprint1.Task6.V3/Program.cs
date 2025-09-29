using Tyuiu.GogolevVM.Sprint1.Task6.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                         *");
        Console.WriteLine("* Задание #6                                                                               *");
        Console.WriteLine("* Вариант #3                                                                               *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                                           *");
        Console.WriteLine("* Напечатать строку, составленную из последних литер всех слов.                            *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Введите строку: ");
        string str = Console.ReadLine();

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.LastLetterWord(str));

        Console.ReadKey();

    }
}