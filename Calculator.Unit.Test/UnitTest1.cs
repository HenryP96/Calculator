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
        public void AddZeroTest()
        {
            double result = uut.Add(5, 0);
            Assert.That(result,Is.EqualTo(5));
        }
        public void AddMinusTest()
        {
            double result = uut.Add(5, -7);
            Assert.That(result, Is.EqualTo(-2));
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
        public void PowerZeroFirstTest()
        {
            double result = uut.Power(0, 5);
            Assert.That(result, Is.EqualTo(0));
        }
        public void PowerZeroSecondTest()
        {
            double result = uut.Power(5, 0);
            Assert.That(result, Is.EqualTo(1));
        }
        public void PowerMinusFirstTest()
        {
            double result = uut.Power(-2, 5);
            Assert.That(result, Is.EqualTo(32));
        }
        public void PowerMinusSecondTest()
        {
            double result = uut.Power(5, -2);
            Assert.That(result, Is.EqualTo(0.04));
        }

        [Test]
        public void AccumulatorTest()
        {
            double result = uut.Accumulator;
            result = 6;
            Assert.That(result,Is.EqualTo(6));
        }


    }
}