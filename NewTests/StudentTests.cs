using Microsoft.VisualStudio.TestTools.UnitTesting;
using New;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New.Tests
{
    [TestClass()]
    public class StudentTests
    {
        public Student _student;

        [TestInitialize]
        public void Setup()
        {
            _student = new Student();
            _student.FirstName = "Jhon";
            _student.LastName = "Ben";
            _student.Grade = 20;
        }

        [TestMethod()]
        public void AdjustedGradeByPercentageTest()
        {
            double val = _student.AdjustedGradeByPercentage();
            Assert.IsTrue(_student.AdjustedGrade < 100);
        }

        [TestMethod()]
        public void LogClassAverageTest()
        {
            //_student.Grade = 20;
            Assert.AreEqual(20, _student.Grade);
        }
    }
}