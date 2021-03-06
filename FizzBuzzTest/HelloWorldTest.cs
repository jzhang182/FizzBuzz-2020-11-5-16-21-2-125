using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        //[Fact]
        //public void Hello_world_test()
        //{
        //    //given
        //    Dependency dependency = new Dependency();
        //    HelloWorld helloWorld = new HelloWorld(dependency);

        //    //when
        //    string actual = helloWorld.BeenCalled();

        //    //then
        //    Assert.Equal("Leave me alone.", actual);
        //}

        //[Fact]
        //public void Should_be_mocked()
        //{
        //    //given
        //    var mockDependencu = new Mock<Dependency>();
        //    mockDependencu.Setup(m => m.Say()).Returns("Hello World");
        //    HelloWorld helloWorld = new HelloWorld(mockDependencu.Object);

        //    //when
        //    string actual = helloWorld.BeenCalled();

        //    //then
        //    Assert.Equal("Hello World", actual);
        //}

        [Fact]
        public void Should_return_1_given_1()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(1);

            //then
            Assert.Equal("1", actual);
        }

        [Fact]
        public void Should_return_2_given_2()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(2);

            //then
            Assert.Equal("2", actual);
        }

        [Fact]
        public void Should_return_Fizz_given_3()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(3);

            //then
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void Should_return_Buzz_given_5()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(5);

            //then
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void Should_return_Whizz_given_7()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(7);

            //then
            Assert.Equal("Whizz", actual);
        }

        [Fact]
        public void Should_return_FizzBuzz_given_3_times_5()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(3 * 5);

            //then
            Assert.Equal("FizzBuzz", actual);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_given_3_5_7()
        {
            //given
            var myCall = new FizzBuzz.FizzBuzz();
            //when
            string actual = myCall.Say(3 * 5 * 7);

            //then
            Assert.Equal("FizzBuzzWhizz", actual);
        }
    }
}