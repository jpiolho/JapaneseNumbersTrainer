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

        [Test]
        [TestCase(Months.January, "ichigatsu")]
        [TestCase(Months.February, "nigatsu")]
        [TestCase(Months.March, "sangatsu")]
        [TestCase(Months.April, "shigatsu")]
        [TestCase(Months.May, "gogatsu")]
        [TestCase(Months.June, "rokugatsu")]
        [TestCase(Months.July, "shichigatsu")]
        [TestCase(Months.August, "hachigatsu")]
        [TestCase(Months.September, "kugatsu")]
        [TestCase(Months.October, "juugatsu")]
        [TestCase(Months.November, "juuichigatsu")]
        [TestCase(Months.December, "juunigatsu")]
        public void MonthToRomaji_ShouldReturnCorrectRomaji(Months month, string expected)
        {
            var result = _service.MonthToRomaji(month);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}