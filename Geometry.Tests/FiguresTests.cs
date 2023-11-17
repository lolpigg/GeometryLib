using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Geometry;
namespace Geometry.Tests
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void FindCircleArea_9dot5sended_283dot38withdelta0dot01returned()
        {
            double radius = 9.5;
            double expected = 283.38;
            double result = Figures.FindCircleArea(radius);
            double delta = 0.01; //Для округления
            Assert.AreEqual(expected, result, delta);
        }
        [TestMethod]
        public void FindTriangleArea_3dot3and3dot3and3dot3sended_4dot71withdelta0dot01returned()
        {
            double a = 3.3;
            double b = 3.3;
            double c = 3.3;
            double expected = 4.71;
            double result = Figures.FindTriangleArea(a,b,c);
            double delta = 0.01; //Для округления
            Assert.AreEqual(expected, result, delta);
        }
        [TestMethod]
        public void IsTriangleRectangular_9dot5sended_283dot38withdelta0dot01returned()
        {
            double a = 8;
            double b = 6;
            double c = 10;
            Assert.IsTrue(Figures.IsTriangleRectangular(a,b,c));
        }
    }
}
