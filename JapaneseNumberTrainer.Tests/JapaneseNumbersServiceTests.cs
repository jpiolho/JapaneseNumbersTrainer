using JapaneseNumbersTrainer.Services.Japanese;

namespace JapaneseNumberTrainer.Tests
{
    public class JapaneseNumbersServiceTests
    {
        private JapaneseNumbersService _service;

        [SetUp]
        public void Setup()
        {
            _service = new JapaneseNumbersService(new JapaneseRomajiService());
        }

        [Test]
        [TestCase(1, "ichi")]
        [TestCase(2, "ni")]
        [TestCase(4, "yon")]
        [TestCase(8, "hachi")]
        [TestCase(16, "juu roku")]
        [TestCase(24, "ni juu yon")]
        [TestCase(32, "san juu ni")]
        [TestCase(48, "yon juu hachi")]
        [TestCase(64, "roku juu yon")]
        [TestCase(128, "hyaku ni juu hachi")]
        [TestCase(256, "ni hyaku go juu roku")]
        [TestCase(512, "go hyaku juu ni")]
        [TestCase(1_024, "sen ni juu yon")]
        [TestCase(2_048, "ni sen yon juu hachi")]
        [TestCase(4_096, "yon sen kyuu juu roku")]
        [TestCase(8_192, "hassen hyaku kyuu juu ni")]
        [TestCase(16_384, "ichi man roku sen sambyaku hachi juu yon")]
        [TestCase(32_768, "samman ni sen nana hyaku roku juu hachi")]
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
        public void TestConvertToJapaneseRomaji_NoChoonpuOrSpaces_Correctly(long number, string expected)
        {
            var result = _service.ConvertToJapaneseRomaji(number, false, true);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, "ichi")]
        [TestCase(2, "ni")]
        [TestCase(4, "yon")]
        [TestCase(8, "hachi")]
        [TestCase(16, "jū roku")]
        [TestCase(24, "ni jū yon")]
        [TestCase(32, "san jū ni")]
        [TestCase(48, "yon jū hachi")]
        [TestCase(64, "roku jū yon")]
        [TestCase(128, "hyaku ni jū hachi")]
        [TestCase(256, "ni hyaku go jū roku")]
        [TestCase(512, "go hyaku jū ni")]
        [TestCase(1_024, "sen ni jū yon")]
        [TestCase(2_048, "ni sen yon jū hachi")]
        [TestCase(4_096, "yon sen kyū jū roku")]
        [TestCase(8_192, "hassen hyaku kyū jū ni")]
        [TestCase(16_384, "ichi man roku sen sambyaku hachi jū yon")]
        [TestCase(32_768, "samman ni sen nana hyaku roku jū hachi")]
        [TestCase(65_536, "roku man go sen go hyaku san jū roku")]
        [TestCase(131_072, "jū san man sen nana jū ni")]
        [TestCase(262_144, "ni jū roku man ni sen hyaku yon jū yon")]
        [TestCase(524_288, "go jū ni man yon sen ni hyaku hachi jū hachi")]
        [TestCase(1_048_576, "hyaku yon man hassen go hyaku nana jū roku")]
        [TestCase(2_097_152, "ni hyaku kyū man nana sen hyaku go jū ni")]
        [TestCase(4_194_304, "yon hyaku jū kyū man yon sen sambyaku yon")]
        [TestCase(8_388_608, "happyaku san jū hachi man hassen roppyaku hachi")]
        [TestCase(16_777_216, "sen roppyaku nana jū nana man nana sen ni hyaku jū roku")]
        [TestCase(33_554_432, "sanzen sambyaku go jū go man yon sen yon hyaku san jū ni")]
        [TestCase(1_000, "sen")]
        [TestCase(10_000, "ichi man")]
        [TestCase(100_000, "jū man")]
        [TestCase(1000_000, "hyaku man")]
        [TestCase(9999_999, "kyū hyaku kyū jū kyū man kyū sen kyū hyaku kyū jū kyū")]
        [TestCase(10_000_000, "sen man")]
        [TestCase(100_000_000, "ichi oku")]
        [TestCase(1_000_000_000, "jū oku")]
        [TestCase(10_000_000_000, "hyaku oku")]
        [TestCase(100_000_000_000, "sen oku")]
        [TestCase(770_752_025_379, "nana sen nana hyaku nana oku go sen ni hyaku ni man go sen sambyaku nana jū kyū")]
        [TestCase(2_222_222_222_222, "ni cho ni sen ni hyaku ni jū ni oku ni sen ni hyaku ni jū ni man ni sen ni hyaku ni jū ni")]
        public void TestConvertToJapaneseRomaji_ChoonpuAndSpaces_Correctly(long number, string expected)
        {
            var result = _service.ConvertToJapaneseRomaji(number, true, true);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, "ichi")]
        [TestCase(2, "ni")]
        [TestCase(4, "yon")]
        [TestCase(8, "hachi")]
        [TestCase(16, "jūroku")]
        [TestCase(24, "nijūyon")]
        [TestCase(32, "sanjūni")]
        [TestCase(48, "yonjūhachi")]
        [TestCase(64, "rokujūyon")]
        [TestCase(128, "hyakunijūhachi")]
        [TestCase(256, "nihyakugojūroku")]
        [TestCase(512, "gohyakujūni")]
        [TestCase(1_024, "sennijūyon")]
        [TestCase(2_048, "nisenyonjūhachi")]
        [TestCase(4_096, "yonsenkyūjūroku")]
        [TestCase(8_192, "hassenhyakukyūjūni")]
        [TestCase(16_384, "ichimanrokusensambyakuhachijūyon")]
        [TestCase(32_768, "sammannisennanahyakurokujūhachi")]
        [TestCase(65_536, "rokumangosengohyakusanjūroku")]
        [TestCase(131_072, "jūsanmansennanajūni")]
        [TestCase(262_144, "nijūrokumannisenhyakuyonjūyon")]
        [TestCase(524_288, "gojūnimanyonsennihyakuhachijūhachi")]
        [TestCase(1_048_576, "hyakuyonmanhassengohyakunanajūroku")]
        [TestCase(2_097_152, "nihyakukyūmannanasenhyakugojūni")]
        [TestCase(4_194_304, "yonhyakujūkyūmanyonsensambyakuyon")]
        [TestCase(8_388_608, "happyakusanjūhachimanhassenroppyakuhachi")]
        [TestCase(16_777_216, "senroppyakunanajūnanamannanasennihyakujūroku")]
        [TestCase(33_554_432, "sanzensambyakugojūgomanyonsenyonhyakusanjūni")]
        [TestCase(1_000, "sen")]
        [TestCase(10_000, "ichiman")]
        [TestCase(100_000, "jūman")]
        [TestCase(1000_000, "hyakuman")]
        [TestCase(9999_999, "kyūhyakukyūjūkyūmankyūsenkyūhyakukyūjūkyū")]
        [TestCase(10_000_000, "senman")]
        [TestCase(100_000_000, "ichioku")]
        [TestCase(1_000_000_000, "jūoku")]
        [TestCase(10_000_000_000, "hyakuoku")]
        [TestCase(100_000_000_000, "senoku")]
        [TestCase(770_752_025_379, "nanasennanahyakunanaokugosennihyakunimangosensambyakunanajūkyū")]
        [TestCase(2_222_222_222_222, "nichonisennihyakunijūniokunisennihyakunijūnimannisennihyakunijūni")]
        public void TestConvertToJapaneseRomaji_ChoonpuAndNoSpaces_Correctly(long number, string expected)
        {
            var result = _service.ConvertToJapaneseRomaji(number, true, false);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}