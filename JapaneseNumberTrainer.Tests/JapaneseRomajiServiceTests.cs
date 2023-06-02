using JapaneseNumbersTrainer.Services.Japanese;

namespace JapaneseNumberTrainer.Tests
{
    public class JapaneseRomajiServiceTests
    {
        private JapaneseRomajiService _service;

        [SetUp]
        public void Setup()
        {
            _service = new JapaneseRomajiService();
        }

        [Test]
        [TestCase("haiyuu", "haiyū")]
        [TestCase("ookii", "ōkī")]
        [TestCase("ii", "ī")]
        [TestCase("ooi", "ōi")]
        [TestCase("koori", "kōri")]
        [TestCase("tooi", "tōi")]
        [TestCase("aoi", "aoi")]
        [TestCase("kiiroi", "kīroi")]
        [TestCase("chiisai", "chīsai")]
        [TestCase("samui", "samui")]
        [TestCase("aozora", "aozora")]
        public void TestToChoonpu_ReturnsRomaji_Correctly(string romaji, string expected)
        {
            var result = _service.ToChoonpu(romaji);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}