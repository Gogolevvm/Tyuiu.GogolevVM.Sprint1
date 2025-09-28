﻿using Tyuiu.GogolevVM.Sprint1.Task1.V4;
using Tyuiu.GogolevVM.Sprint1.Task1.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #4                                                                *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать консольную программу на C#, которая вычисляет выражение (x+y)/x*y*");
        Console.WriteLine("* и печатает результат на экране                                            *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");
       

        double x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}