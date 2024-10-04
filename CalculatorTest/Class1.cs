using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        public Calculation c1;

        // SetUp is run before each test method is executed.
        [SetUp]
        public void Setup()
        {
            c1 = new Calculation();
        }

        [TestCase(40,50,90)]
        [TestCase(90,45,135)]
        public void Add_WhenCalled_ReturnsSum(int a , int b , int expected)
        {
            int result = c1.Addition(a, b);

            Assert.AreEqual(expected, result);
        }

        // A test for subtraction
        [TestCase(60,50,10)]
        [TestCase(50,60,-10)]
        public void Subtract_WhenCalled_ReturnsDifference(int a, int b, int expected)
        {
            int result = c1.Subtraction(a, b);

            Assert.AreEqual(expected, result);
        }

        // A test for multiplication
        [TestCase(20,10,200)]
        [TestCase(20,20,400)]
        public void Multiply_WhenCalled_ReturnsProduct(int a, int b, int expected)
        {
            int result = c1.Multiplication(a, b);

            Assert.AreEqual(expected, result);
        }

        // A test for division
        [TestCase(50,10,5)]
        [TestCase(50,25,2)]
        public void Divide_WhenCalledWithNonZeroDenominator_ReturnsQuotient(int a, int b, int expected)
        {
            int result = c1.Division(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}
