namespace JapaneseNumbersTrainer.Services.Options;

public class AppOptions
{
    public class NormalNumbersOptions
    {
        public int Minimum { get; set; } = 0;
        public int Maximum { get; set; } = 100;
    }

    public NormalNumbersOptions NormalNumbers { get; set; } = new();
}
