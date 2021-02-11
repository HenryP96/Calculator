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
            //Init
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
            double result = uut.Multiply(8, 5);
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void MultiplyZeroTest()
        {
            double result = uut.Multiply(8, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MultiplyMinusFirstTest()
        {
            double result = uut.Multiply(8, -5);
            Assert.That(result, Is.EqualTo(-40));
        }

        [Test]
        public void MultiplyMinusSecondTest()
        {
            double result = uut.Multiply(-5, -5);
            Assert.That(result, Is.EqualTo(25));
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