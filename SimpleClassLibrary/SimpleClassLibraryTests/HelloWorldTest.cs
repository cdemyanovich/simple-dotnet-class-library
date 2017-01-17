using SimpleClassLibrary;
using Xunit;

namespace SimpleClassLibraryTests
{
    public class HelloWorldTest
    {
        [Fact]
        public void Greets()
        {
            Assert.Equal("Hello, world!", new HelloWorld().Greet());
        }
    }
}
