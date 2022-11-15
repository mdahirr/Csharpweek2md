using Microsoft.VisualStudio.TestPlatform.TestHost;
using CodeToTest;

namespace UnitTests
{
    public class GreetingTests
    {
        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good evening!";
            var result = CodeToTest.Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}