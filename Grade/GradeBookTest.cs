using Grade;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    [TestClass]
    class GradeBookTest
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(2);
            book.AddGrade(23.5f);
            book.AddGrade(73);

  
            GradeStats result = book.ComputeStats();
            Assert.AreEqual(73, result.HighGrade);

        }
    }
}
  