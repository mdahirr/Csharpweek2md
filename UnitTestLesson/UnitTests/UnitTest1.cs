using Microsoft.VisualStudio.TestPlatform.TestHost;
using CodeToTest;

namespace UnitTests
{
    public class GreetingTests
    {
        [TestCase(16)]
        [TestCase(22)]
        [TestCase(23)]
        [TestCase(24)]

        public void GivenATimeBetween19and24GreetingReturnsGoodEvening(int time)
        {
            // Arrange
            //var time = 21;
            //var expectedGreeting = "Good evening!";

            // Act
            //var result = CodeToTest.Program.Greeting(time);

            // Assert
            //Assert.That(result, Is.EqualTo(expectedGreeting));

            /*
            Assert.That("Good evening!", Is.EqualTo(CodeToTest.Program.Greeting(21)));
            Assert.That("Good morning!", Is.EqualTo(CodeToTest.Program.Greeting(12)));
            Assert.That("Good afternoon!", Is.EqualTo(CodeToTest.Program.Greeting(14)));
            Assert.That("Good morning!", Is.EqualTo(CodeToTest.Program.Greeting(7)));
            */
        }
    }
    public class Classification_Tests
    { 
            [TestCase(15)]
            public void GivenATimeOf15_Greeting_ReturnsGoodAfternoon(int time)
            {
                //var time = 15
                var expectedGreeting = "Good afternoon!";

                // act
                var result = CodeToTest.Program.Greeting(time);

                //Assert
                Assert.That(result, Is.EqualTo(expectedGreeting));
            }

        [TestCase(12)]
        [TestCase(10)]
        [TestCase(5)]

        public void GivenAgeIsLessThan12(int ageOfViewer)
            {
                var expectedResult = "U, PG & 12 films are available.";

                // Act
                var result = CodeToTest.Program.AvailableClassifications(ageOfViewer);

                Assert.That(result, Is.EqualTo(expectedResult));
            }

        [TestCase(13)]
        [TestCase(15)]
        public void GivenAgeIsLessThan15(int ageOfViewer)
            {
                var expectedResult = "U, PG, 12 & 15 films are available.";

                // Act
                var result = CodeToTest.Program.AvailableClassifications(ageOfViewer);

                //Assert
                Assert.That(result, Is.EqualTo(expectedResult));

            }

        [TestCase(18)]
        [TestCase(19)]
        [TestCase(20)]

        public void GivenAgeIsMoreThan18(int ageOfViewer)
            {
                var expectedResult = "All films are available.";

                //Act
                var result = CodeToTest.Program.AvailableClassifications(ageOfViewer);

                //Assert
                Assert.That(result, Is.EqualTo(expectedResult));

            }
    }
    
}