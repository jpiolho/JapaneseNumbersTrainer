using JapaneseNumbersTrainer.Services;

namespace JapaneseNumberTrainer.Tests
{
    public class JapaneseServiceTests
    {
        [Test]
        [TestCase(1,"ichi")]
        [TestCase(2,"ni")]
        [TestCase(4,"yon")]
        [TestCase(8,"hachi")]
        [TestCase(16,"juu roku")]
        [TestCase(24,"ni juu yon")]
        [TestCase(32,"san juu ni")]
        [TestCase(48,"yon juu hachi")]
        [TestCase(64,"roku juu yon")]
        [TestCase(128,"hyaku ni juu hachi")]
        [TestCase(256,"ni hyaku go juu roku")]
        [TestCase(512,"go hyaku juu ni")]
        [TestCase(1_024,"sen ni juu yon")]
        [TestCase(2_048,"ni sen yon juu hachi")]
        [TestCase(4_096,"yon sen kyuu juu roku")]
        [TestCase(8_192,"hassen hyaku kyuu juu ni")]
        [TestCase(16_384,"ichi man roku sen sambyaku hachi juu yon")]
        [TestCase(32_768,"samman ni sen nana hyaku roku juu hachi")]
        [TestCase(65_536, "roku man go sen go hyaku san juu roku")]
        [TestCase(131_072, "juu san man sen nana juu ni")]
        [TestCase(262_144, "ni juu roku man ni sen hyaku yon juu yon")]
        [TestCase(524_288, "go juu ni man yon sen ni hyaku hachi juu hachi")]
        [TestCase(1_048_576, "hyaku yon man hassen go hyaku nana juu roku")]
        [TestCase(2_097_152, "ni hyaku kyuu man nana sen hyaku go juu ni")]
        [TestCase(4_194_304, "yon hyaku juu kyuu man yon sen sambyaku yon")]
        [TestCase(8_388_608, "happyaku san juu hachi man hassen roppyaku hachi")]
        [TestCase(16_777_216, "sen roppyaku nana juu nana man nana sen ni hyaku juu roku")]
        [TestCase(33_554_432, "sanzen sambyaku go juu go man yon sen yon hyaku san juu ni")]
        [TestCase(1_000, "sen")]
        [TestCase(10_000, "ichi man")]
        [TestCase(100_000, "juu man")]
        [TestCase(1000_000, "hyaku man")]
        [TestCase(9999_999, "kyuu hyaku kyuu juu kyuu man kyuu sen kyuu hyaku kyuu juu kyuu")]
        [TestCase(10_000_000, "sen man")]
        [TestCase(100_000_000, "ichi oku")]
        [TestCase(1_000_000_000, "juu oku")]
        [TestCase(10_000_000_000, "hyaku oku")]
        [TestCase(100_000_000_000, "sen oku")]
        [TestCase(770_752_025_379, "nana sen nana hyaku nana oku go sen ni hyaku ni man go sen sambyaku nana juu kyuu")]
        [TestCase(2_222_222_222_222, "ni cho ni sen ni hyaku ni juu ni oku ni sen ni hyaku ni juu ni man ni sen ni hyaku ni juu ni")]
        public void TestConvertToJapaneseRomaji_ValidNumbers(long number, string expected)
        {
            var service = new JapaneseService();

            var result = service.ConvertToJapaneseRomaji(number);

            Assert.That(result,Is.EqualTo(expected));
        }
    }
}