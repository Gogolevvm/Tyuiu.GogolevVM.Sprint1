using Tyuiu.GogolevVM.Sprint1.Task3.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
