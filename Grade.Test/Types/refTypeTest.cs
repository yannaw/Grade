using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Test.Types
{
    [TestClass]
         public class refTypeTest
    {
        [TestMethod]
        public void MyTestMethod()
        {


        }
        [TestMethod]
        public void VariablesHoldRef()
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "vvvv";
            Assert.AreEqual(g1.Name, g2.Name);

        }
    }
}
