using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OperatorsApp;

namespace OperatorsControlFlow.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [Testcase(100)]
        public class StoneClass
        {
            [TestCase(100)]
            public void CorrectStones(int totalPounds)
            {
                var expectedResult = totalPounds / 14;

                var result = Methods.GetStones(totalPounds);

                Assert.That(result, Is.EqualTo(expectedResult));

            }

            [TestCase(100)]
            public void CorrectPounds(int totalPounds)
            {
                var expectedResult = totalPounds % 14;

                var result = Methods.GetPounds(totalPounds);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
}