using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class Translate_Numbers_Into_Roman_Numerals
    {
        [Fact] // denotes that this method is a test
        public void Translate_1_to_I() // must be public, return void, and take no parameters
        {
            // Arrange
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "I";

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Translate_5_to_V()
        {
            // Arrange
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "V";

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Translate_9_to_IV()
        {
            // Arrange
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "IX";


            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
