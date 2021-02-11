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
            //Act
            double result = uut.Add(2, 5);
            //Assert
            Assert.That(result, Is.EqualTo(7));
        }
        [Test]
        public void AddZeroTest()
        {
            //Act
            double result = uut.Add(5, 0);
            //Assert
            Assert.That(result,Is.EqualTo(5));
        }
        [Test]
        public void AddMinusTest()
        {
            //Act
            double result = uut.Add(5, -7);
            //Assert
            Assert.That(result, Is.EqualTo(-2));
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
            //Act
            double result = uut.Multiply(8, 5);
            //Assert
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void MultiplyZeroTest()
        {
            //Act
            double result = uut.Multiply(8, 0);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MultiplyMinusFirstTest()
        {
            //Act
            double result = uut.Multiply(8, -5);
            //Assert
            Assert.That(result, Is.EqualTo(-40));
        }

        [Test]
        public void MultiplyMinusSecondTest()
        {
            //Act
            double result = uut.Multiply(-5, -5);
            //Assert
            Assert.That(result, Is.EqualTo(25));
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
            //Act
            double result = uut.Power(5, 3);
            //Assert
            Assert.That(result, Is.EqualTo(125));
        }
        [Test]
        public void PowerZeroFirstTest()
        {
            //Act
            double result = uut.Power(0, 5);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void PowerZeroSecondTest()
        {
            //Act
            double result = uut.Power(5, 0);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void PowerMinusFirstTest()
        {
            //Act
            double result = uut.Power(-2, 5);
            //Assert
            Assert.That(result, Is.EqualTo(-32));
        }
        [Test]
        public void PowerMinusSecondTest()
        {
            //Act
            double result = uut.Power(5, -2);
            //Assert
            Assert.That(result, Is.EqualTo(0.04));
        }

        [Test]
        public void AccumulatorAddTest()
        {
            //Act
            double result = uut.Add(5, 5);
            //Assert
            Assert.That(result,Is.EqualTo(uut.Accumulator));
        }

        [Test]
        public void AccumulatorSubtractTest()
        {
            //Act
            double result = uut.Subtract(20, 5);
            //Assert
            Assert.That(result, Is.EqualTo(uut.Accumulator));
        }

        [Test]
        public void AccumulatorMultiplyTest()
        {
            //Act
            double result = uut.Multiply(5, 5);
            //Assert
            Assert.That(result, Is.EqualTo(uut.Accumulator));
        }

        [Test]
        public void AccumulatorPowerTest()
        {
            //Act
            double result = uut.Power(5, 5);
            //Assert
            Assert.That(result, Is.EqualTo(uut.Accumulator));
        }

        [Test]
        public void AccumulatorDivideTest()
        {
            //Act
            double result = uut.Divide(20, 5);
            //Assert
            Assert.That(result, Is.EqualTo(uut.Accumulator));
        }

        [Test]
        public void ClearTest()
        {
            uut.Add(20, 5);
            Assert.That(uut.Accumulator, Is.EqualTo(25));
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void OverloadedAddTest()
        {
            double result = uut.Add(2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void OverloadedAddZeroTest()
        {
            double result = uut.Add(5);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void OverloadedAddMinusTest()
        {
            double result = uut.Add(-7);
            Assert.That(result, Is.EqualTo(-7));
        }

        [Test]
        public void OverloadedSubtractTest()
        {
            double result = uut.Subtract(2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void OverloadedSubtractZeroTest()
        {
            double result = uut.Add(5);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void OverloadedSubtractMinusTest()
        {
            double result = uut.Add(-7);
            Assert.That(result, Is.EqualTo(-7));
        }

        [Test]
        public void OverloadedMultiplyTest()
        {
            //Arrange
            uut.Add(10);
            //Act
            double result = uut.Multiply(4);
            //Assert
            Assert.That(result, Is.EqualTo(40));
        }
        [Test]
        public void OverloadedMultiplyZeroTest()
        {
            //Act
            double result = uut.Multiply(8);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void OverloadedMultiplyMinusFirstTest()
        {
            //Arrange
            uut.Add(10);
            //Act
            double result = uut.Multiply(-8);
            //Assert
            Assert.That(result, Is.EqualTo(-80));
        }

    }
}