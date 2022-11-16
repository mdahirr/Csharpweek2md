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

        public void GradeMarkTest(int mark)
        {
            string expectedResult = "Pass";

            string result = OperatorsApp.Program.GradeMethod(mark);

            Assert.That(expectedResult, Is.Equalto(result));

        }
    }
}
