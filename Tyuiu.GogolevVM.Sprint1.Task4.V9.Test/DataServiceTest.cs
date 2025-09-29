using Tyuiu.GogolevVM.Sprint1.Task4.V9.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 120;
            double y = 30;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.091, res);

        }
    }
}
