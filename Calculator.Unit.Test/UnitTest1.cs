using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        private CalculatorClass uut;

        [SetUp]
        public void Setup()
        {
            uut = new CalculatorClass();
        }

        [Test]
        public void AddTest()
        {
            //Arrange
            //var uut = new CalculatorClass();
            //Act
            double result = uut.Add(2, 5);
            //Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void SubtractionTest()
        {
            //Arrange
            //var uut = new CalculatorClass();
            //Act
            double result = uut.Subtract(10, 5);
            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void MultiplyTest()
        {
            //Arrange
            //var uut = new CalculatorClass();
            //Act
            double result = uut.Multiply(8, 5);
            //Assert
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void PowerTest()
        {
            //Arrange
            //var uut = new CalculatorClass();
            //Act
            double result = uut.Power(5, 3);
            //Assert
            Assert.That(result, Is.EqualTo(125));
        }
    }
}