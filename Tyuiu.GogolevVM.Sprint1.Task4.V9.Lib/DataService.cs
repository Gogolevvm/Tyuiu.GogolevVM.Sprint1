using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GogolevVM.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {
            var primer = Math.Log(x*y, 2.71828) / (x - Math.Sqrt(1 + Math.Pow(y,2)));
            var res = Math.Round(primer,3);
            return res;
        }
    }
}
