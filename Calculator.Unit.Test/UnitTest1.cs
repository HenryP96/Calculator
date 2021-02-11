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
            //Act
            double result = uut.Subtract(10, 5);
            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void SubtractionZeroTest()
        {
            //Act
            double result = uut.Subtract(10, 0);
            //Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void SubtractionMinusTest()
        {
            //Act
            double result = uut.Subtract(20, -5);
            //Assert
            Assert.That(result, Is.EqualTo(25));
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
        public void DivideTest()
        {
            //Act
            double result = uut.Divide(10, 5);
            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void DivideByZeroTest()
        {
            //Act + Assert
            Assert.That(() => uut.Divide(10, 0), Throws.TypeOf<System.DivideByZeroException>());
        }

        [Test]
        public void DivideMinusTest()
        {
            //Act
            double result = uut.Divide(20, -5);
            //Assert
            Assert.That(result, Is.EqualTo(-4));
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