﻿using System;

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
            return count.ToString();
        }
    }
}
