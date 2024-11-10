using Newtonsoft.Json.Linq;
using Tyuiu.PopovaAA.Sprint3.Task3.V9.Lib;
namespace Tyuiu.PopovaAA.Sprint3.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplace()
        {
            DataService ds = new DataService();
            string str = "56hy vfe4r4 vf45b";
            char chr = 'c';
            string res = ds.ReplaceNumOnChar(str, chr);
            string wait = "wwhy vfewrw vfwwb";

            Assert.AreEqual(wait, res);
        }
    }
}