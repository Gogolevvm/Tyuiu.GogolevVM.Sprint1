using Tyuiu.GogolevVM.Sprint1.Task5.V1.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double y1 = 3;
            double x2 = 2;
            double y2 = 1;
            
            double res = ds.DistanceBetweenDots(x1,y1,x2,y2);
            int result = Convert.ToInt32(res);
            double wait = 4;
            Assert.AreEqual(wait,result);

        }
    }
}
