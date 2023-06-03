using JapaneseNumbersTrainer.Base;
using JapaneseNumbersTrainer.Services.Japanese;

namespace JapaneseNumberTrainer.Tests
{
    public class JapaneseDateServiceTests
    {
        private JapaneseDateService _service;

        [SetUp]
        public void Setup()
        {
            _service = new JapaneseDateService();
        }

        [Test]
        [TestCase(DayOfWeek.Monday, "getsuyoubi")]
        [TestCase(DayOfWeek.Tuesday, "kayoubi")]
        [TestCase(DayOfWeek.Wednesday, "suiyoubi")]
        [TestCase(DayOfWeek.Thursday, "mokuyoubi")]
        [TestCase(DayOfWeek.Friday, "kinyoubi")]
        [TestCase(DayOfWeek.Saturday, "doyoubi")]
        [TestCase(DayOfWeek.Sunday, "nichiyoubi")]

        public void TestWeekdayToRomaji_ReturnsRomaji_Correctly(DayOfWeek weekday, string expected)
        {
            var result = _service.WeekdayToRomaji(weekday);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(Month.January, "ichigatsu")]
        [TestCase(Month.February, "nigatsu")]
        [TestCase(Month.March, "sangatsu")]
        [TestCase(Month.April, "shigatsu")]
        [TestCase(Month.May, "gogatsu")]
        [TestCase(Month.June, "rokugatsu")]
        [TestCase(Month.July, "shichigatsu")]
        [TestCase(Month.August, "hachigatsu")]
        [TestCase(Month.September, "kugatsu")]
        [TestCase(Month.October, "juugatsu")]
        [TestCase(Month.November, "juuichigatsu")]
        [TestCase(Month.December, "juunigatsu")]
        public void MonthToRomaji_ShouldReturnCorrectRomaji(Month month, string expected)
        {
            var result = _service.MonthToRomaji(month);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}