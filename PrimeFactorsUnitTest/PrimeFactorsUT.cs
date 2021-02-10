using System;
using Xunit;
using System.Text;
using PrimeFactors;
using static System.Console;

namespace PrimeFactorsUnitTest
{
    public class PrimeFactorsUT
    {
        [Fact]
        public void TestInput30Result2x3x5()
        {
            //Arrange
            int input30 = 30;
            //Act
            var primeFact = new PrimeFactor();
            string actual = primeFact.GetPrimeFactor(input30);
            string expected = "2x3x5x";
            //Asser
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInput50Result2x5x5()
        {
            //Arrange
            int input30 = 50;
            //Act
            var primeFact = new PrimeFactor();
            string actual = primeFact.GetPrimeFactor(input30);
            string expected = "2x5x5x";
            //Asser
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestInput40Result2x2x2x5()
        {
            //Arrange
            int input30 = 40;
            //Act
            var primeFact = new PrimeFactor();
            string actual = primeFact.GetPrimeFactor(input30);
            string expected = "2x2x2x5x";
            //Asser
            Assert.Equal(expected, actual);
        }
    }
}
