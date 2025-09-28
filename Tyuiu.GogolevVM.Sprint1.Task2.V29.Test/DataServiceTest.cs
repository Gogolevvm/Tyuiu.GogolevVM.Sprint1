using Tyuiu.GogolevVM.Sprint1.Task2.V29.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            int a = 180;
            var res = ds.ConvertSecondsToHours(a);
            Assert.AreEqual(3, res);
        }
    }
}
