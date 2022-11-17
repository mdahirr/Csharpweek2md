using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperatorsControlFlow.Tests
{
    public class ControlFlowTests
    {
        [TestCase(90, "Pass")]

        public void GradeMarkTest(int mark, string expectedGrade)
        {
            string expectedResult = "Pass";

            string result = Program.GradeMethod(mark);

            Assert.That(expectedResult, Is.Equalto(result));

            Assert.That(Program.Grade(mark) Is.Equalto(expectedResult));

        }
    }
}
