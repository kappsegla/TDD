using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    /*
    enum RomanNumeralsType
    {
        M = 1000,
        D = 500,
        C = 100,
        L = 50,
        X = 10,
        V = 5,
        I = 1
    }*/
    //https://en.wikipedia.org/wiki/Roman_numerals
    //All values are written in additive form.
    //Example: Number 4 is converted into IIII instead of IV.

    [TestClass]
    public class RomanNumeralConverterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Number_Equal_Zero_Expected_ArgumentOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(0);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void Number_Equal_One_Expected_Result_I_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(1);

                Assert.AreEqual(result, "I");
            }

        [TestMethod]
        public void Number_Equal_Eleven_Expected_Result_XI_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(11);

            Assert.AreEqual(result, "XI");
        }

        [TestMethod]
        public void Number_Equal_ThreeThousand_Expected_Result_MMM_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(3000);

                Assert.AreEqual(result, "MMM");
            }

        [TestMethod]
        public void Number_Equal_55_Expected_Result_LV_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(55);

                Assert.AreEqual(result, "LV");
            }

        [TestMethod]
        public void Number_Equal_100_Expected_Result_C_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(100);

                Assert.AreEqual(result, "C");
            }

        [TestMethod]
        public void Number_Equal_500_Expected_Result_D_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(500);

                Assert.AreEqual(result, "D");
            }

        [TestMethod]
        public void Number_Equal_599_Expected_Result_DLXXXXVIIII_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(599);

                Assert.AreEqual(result, "DLXXXXVIIII");
            }

        [TestMethod]
        public void Number_Equal_2015_Expected_Result_MMXIII_TestMethod()
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ConvertRomanNumeral(2015);

                Assert.AreEqual(result, "MMXV");
            }
    }
}
