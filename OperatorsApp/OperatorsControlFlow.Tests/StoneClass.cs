using OperatorsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace OperatorsControlFlow.Tests
{
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
