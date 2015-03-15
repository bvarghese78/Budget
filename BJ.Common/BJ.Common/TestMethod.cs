using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BJ.Common
{
    [TestClass]
    public class TestMethod
    {
        [TestMethod]
        public void test()
        {
            DateTimeMethods time = new DateTimeMethods();
            //var testValue = time.fullDateTime(2014, 12, 20, 13, 50, 12);
            var testValue = time.currentMonth();
            Assert.IsNotNull(testValue);
        }
    }
}
