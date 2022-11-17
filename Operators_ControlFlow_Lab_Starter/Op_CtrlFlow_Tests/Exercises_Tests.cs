using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(1,1)]
        public void MyMethodTestsWhenNumIsTheSame(int num1, int num2)
        {
            bool expectedResult = false;
            bool result = Exercises.MyMethod(num1, num2);

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [TestCase(4,2)]
        [TestCase(8,4)]
        public void MyMethodTestsWhenNumsAreDifferent(int num1, int num2)
        {
            bool expectedResult = true;
            bool result = Exercises.MyMethod(num1, num2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 50)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]

        public void CovidWeddingTest(int covidLevel, int expected) 
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(result, Is.EqualTo(expected));
        }
    }   
}
