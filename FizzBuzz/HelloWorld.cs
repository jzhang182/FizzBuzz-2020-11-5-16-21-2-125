using System;

namespace FizzBuzz
{
    public class HelloWorld
    {
        private readonly Dependency dependency;

        public HelloWorld(Dependency dependency)
        {
            this.dependency = dependency;
        }

        public string BeenCalled()
        {
            return dependency.Say();
        }
    }

    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Say(int count)
        {
            string word = string.Empty;
            if (count % 3 == 0)
            {
                word += "Fizz";
            }

            if (count % 5 == 0)
            {
                word += "Buzz";
            }

            if (count % 7 == 0)
            {
                word += "Whizz";
            }

            return string.IsNullOrEmpty(word) ? count.ToString() : word;
        }
    }
}
