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
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);

        }
    }
}
