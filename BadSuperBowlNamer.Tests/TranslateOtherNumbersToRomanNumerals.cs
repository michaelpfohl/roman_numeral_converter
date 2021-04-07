using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BadSuperBowlNamer
{
    public class TranslateOtherNumbersToRomanNumerals
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2, "II")]
        [InlineData(14,"XIV")]
        [InlineData(73, "LXXIII")]
        [InlineData(49, "XLIX")]
        [InlineData(99, "XCIX")]
        [InlineData(345, "CCCXLV")]
        [InlineData(499, "CDXCIX")]
        [InlineData(874, "DCCCLXXIV")]
        [InlineData(915, "CMXV")]
        [InlineData(999, "CMXCIX")]
        [InlineData(3999, "MMMCMXCIX")]
        public void number_successfully_converted_to_numeral(int numberToConvert, string expectedNumeral)
        {
            // Arrange
            var translator = new RomanNumeralTranslator();

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedNumeral, result);
        }
    }
}
