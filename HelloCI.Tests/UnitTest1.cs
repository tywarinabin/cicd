using Xunit;
using HelloCI;

namespace HelloCI.Tests
{
    public class GreetTests
    {
        [Fact]
        public void Greet_ValidName_ReturnsHelloName()
        {
            string result = Program.Greet("World");
            Assert.Equal("Hello, World!", result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Greet_InvalidName_Throws(string name)
        {
            Assert.Throws<ArgumentException>(() => Program.Greet(name));
        }
    }
}
