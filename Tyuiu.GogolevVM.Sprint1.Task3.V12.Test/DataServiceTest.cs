using Tyuiu.GogolevVM.Sprint1.Task3.V12.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 12;
            double y = 2;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(12, res);
        }
    }
}
