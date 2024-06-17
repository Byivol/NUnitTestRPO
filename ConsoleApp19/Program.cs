using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ConsoleApp19
{
    internal class Program
    {
        [TestFixture]
        public class StringCalculatorTests
        {
            [TestCase(0, "123", ExpectedResult = 0)]
            [TestCase(1, 1, ExpectedResult = 2)]
            [TestCase(-1, -1, ExpectedResult = -2)]
            public int AddNumbers(int a, int b)
            {
                return a + b;
            }

            [TestCase("Hello", "World", ExpectedResult = "HelloWorld")]
            [TestCase(" Foo", " Bar", ExpectedResult = " Foo Bar")]
            [TestCase("", "", ExpectedResult = "")]
            static public string AddStrings(string a, string b)
            {
                return a + b;
            }

            [TestCase("Hello", 1, ExpectedResult = "Hello")]
            [TestCase(" Foo", 2, ExpectedResult = " Foo Foo")]
            [TestCase("", 5, ExpectedResult = "")]
            static public string MultiplyString(string str, int count)
            {
                return string.Concat(Enumerable.Repeat(str, count));
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
