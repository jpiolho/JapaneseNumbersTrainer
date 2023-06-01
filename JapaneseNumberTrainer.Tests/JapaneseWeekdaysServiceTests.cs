using JapaneseNumbersTrainer.Services.Japanese;

namespace JapaneseNumberTrainer.Tests
{
    public class JapaneseWeekdaysServiceTests
    {
        private JapaneseWeekdaysService _service;

        [SetUp]
        public void Setup()
        {
            _service = new JapaneseWeekdaysService();
        }

        [Test]
        [TestCase(DayOfWeek.Monday, "Getsuyoubi")]
        [TestCase(DayOfWeek.Tuesday, "Kayoubi")]
        [TestCase(DayOfWeek.Wednesday, "Suiyoubi")]
        [TestCase(DayOfWeek.Thursday, "Mokuyoubi")]
        [TestCase(DayOfWeek.Friday, "Kinyoubi")]
        [TestCase(DayOfWeek.Saturday, "Doyoubi")]
        [TestCase(DayOfWeek.Sunday, "Nichiyoubi")]
       
        public void TestWeekdayToRomaji_ReturnsRomaji_Correctly(DayOfWeek weekday, string expected)
        {
            var result = _service.WeekdayToRomaji(weekday);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}