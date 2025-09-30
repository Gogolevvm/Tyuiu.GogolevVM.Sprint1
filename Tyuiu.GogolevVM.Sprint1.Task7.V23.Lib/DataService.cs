﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GogolevVM.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double primer = x - Math.Pow(10, Math.Sin(x)) + ((20 * Math.Pow(x,2)) / (3 * Math.Pow(x,3))) + Math.Cos(Math.Pow(x,2) - y) ;
            var z = Math.Round(primer,3);
            return z;
            
        }
    }
}
