using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
      
        
        
            Color c1 = Color.Black;

        [TestMethod]
        public void TestMethod1()
        {
            var t = new Final.Triangle();
            int x=20, y=80, width = 50, height= 90;
            t.set(c1, x, y, width, height);
            Assert.AreEqual(20, t.x);
        }

    }
}
