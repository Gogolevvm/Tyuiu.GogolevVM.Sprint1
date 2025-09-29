using Tyuiu.GogolevVM.Sprint1.Task6.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strlest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strlest);
            string wait = "123";
            Assert.AreEqual(wait, res);

        }
    }
}
