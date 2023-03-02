namespace Tests
{
    using RomanNumerals;

    [TestClass]
    public class ConvertToIntegerTests
    {
        [TestMethod()]
        [DataRow("I", 1)]
        [DataRow("V", 5)]
        [DataRow("X", 10)]
        [DataRow("L", 50)]
        [DataRow("C", 100)]
        [DataRow("D", 500)]
        [DataRow("M", 1000)]
        [DataRow("IV", 4)]
        [DataRow("IX", 9)]
        [DataRow("XIV", 14)]
        [DataRow("XLIX", 49)]
        [DataRow("XCIX", 99)]
        [DataRow("CDXCIX", 499)]
        [DataRow("DCCCLXXXVIII", 888)]
        [DataRow("CMXCIX", 999)]
        [DataRow("MMXXII", 2022)]
        [DataRow("MMMCMXCIX", 3999)]
        public void ConvertToIntegerTest(string numeral, int value)
        {
            var rnc = new RomanNumeralConverter();
            var answer = rnc.ConvertFromRomanNumerals(numeral);
            Assert.AreEqual(answer, value);
        }
    }
}