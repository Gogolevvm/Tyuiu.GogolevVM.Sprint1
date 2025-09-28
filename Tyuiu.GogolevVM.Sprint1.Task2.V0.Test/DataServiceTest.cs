using Tyuiu.GogolevVM.Sprint1.Task2.V0;
using Tyuiu.GogolevVM.Sprint1.Task2.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            var res = ds.Sqr(a);
            Assert.AreEqual(4, res);
        }
    }
}
