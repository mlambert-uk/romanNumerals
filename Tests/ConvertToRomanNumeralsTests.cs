namespace Tests
{
    using RomanNumerals;

    [TestClass]
    public class ConvertToRomanNumeralsTests
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(5, "V")]
        [DataRow(10, "X")]
        [DataRow(50, "L")]
        [DataRow(100, "C")]
        [DataRow(500, "D")]
        [DataRow(1000, "M")]
        [DataRow(2,"II")]
        [DataRow(3,"III")]
        [DataRow(4,"IV")]
        [DataRow(6,"VI")]
        [DataRow(7,"VII")]
        [DataRow(8,"VIII")]
        [DataRow(9,"IX")]
        [DataRow(14,"XIV")]
        [DataRow(49, "XLIX")]
        [DataRow(99, "XCIX")]
        [DataRow(499, "CDXCIX")]
        [DataRow(888, "DCCCLXXXVIII")]
        [DataRow(999, "CMXCIX")]
        [DataRow(2022, "MMXXII")]
        [DataRow(3999, "MMMCMXCIX")]
        public void ConvertToRomanNumerals(int value, string numeral)
        {
            var rnc = new RomanNumeralConverter();
            var answer = rnc.ConvertToRomanNumerals(value);
            Assert.AreEqual(numeral, answer);
        }

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