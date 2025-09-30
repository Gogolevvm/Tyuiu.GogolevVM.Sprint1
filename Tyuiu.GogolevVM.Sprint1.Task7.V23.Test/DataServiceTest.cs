using Tyuiu.GogolevVM.Sprint1.Task7.V23.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var result = ds.Calculate(x, y);
            var wait = 1.265;
            Assert.AreEqual(wait, result);
        }
    }
}
