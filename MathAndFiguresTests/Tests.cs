using MathFigures;
using NUnit.Framework;
using System;

namespace MathAndFiguresTests
{
    public class Tests
    {

        [TestCase(5, 78.5, 1)]
        [TestCase(5, 78.54, 2)]
        public void CircleAreaTest(double radius, double expectedResult, int round)
        {
            var currentResult = Math.Round(MathAndFigures.CircleArea(radius), round);
            Assert.That(expectedResult == currentResult, "Current result is: " + currentResult);
        }

        [TestCase(0)]
        public void CircleAreaTestNegative(double radius)
        {
            Assert.Throws<Exception>(() => MathAndFigures.CircleArea(radius));
        }

        [TestCase(5, 4, 3, 6, 1)]
        [TestCase(5, 6, 7, 14.7, 2)]
        public void TriangleAreaTest(double a, double b, double c, double expectedResult, int round)
        {
            var currentResult = Math.Round(MathAndFigures.TriangleArea(a, b, c), round);
            Assert.That(expectedResult == currentResult, "Current result is: " + currentResult);
        }
        [TestCase(0, 1, 2)]
        public void TriangleAreaTestNegative(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => MathAndFigures.TriangleArea(a,b,c));
        }

        [TestCase(5, 4, 3, true)]
        [TestCase(5, 6, 7, false)]
        public void IsRightTriangleTest(double a, double b, double c, bool expectedResult)
        {
            var currentResult = MathAndFigures.IsRightTriangle(a, b, c);
            Assert.That(expectedResult == currentResult, "Current result is: " + currentResult);
        }
        [TestCase(0, 1, 2)]
        public void IsRightTriangleTestNegative(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => MathAndFigures.IsRightTriangle(a, b, c));
        }
    }
}