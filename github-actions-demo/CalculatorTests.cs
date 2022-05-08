using NUnit.Framework;
using System;
using github_actions_demo;

namespace github_actions_demo
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Calculate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string input = "2 5 *";

            // Act
            var result = Calculator.Calculate(
                input);

            // Assert
            Assert.True(result == 10);
        }

        [Test]
        public void IsOperator_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string op = "*";

            // Act
            var result = Calculator.IsOperator(
                op);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsOperator_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            string op = "2";

            // Act
            var result = Calculator.IsOperator(
                op);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
