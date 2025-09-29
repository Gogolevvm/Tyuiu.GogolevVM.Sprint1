using Tyuiu.GogolevVM.Sprint1.Task6.V3.Lib;
namespace Tyuiu.GogolevVM.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strlest = "Привет Сева";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strlest);
            string wait = "та";
            Assert.AreEqual(wait, res);
        }
    }
}
