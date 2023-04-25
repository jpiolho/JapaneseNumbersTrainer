namespace JapaneseNumbersTrainer.Services.Options;

public class AppOptions
{
    public class NormalNumbersOptions
    {
        public int Minimum { get; set; } = 0;
        public int Maximum { get; set; } = 100;
        public bool UseChoonpu { get; set; } = true;
        public bool UseSpaces { get; set; } = true;
    }

    public NormalNumbersOptions NormalNumbers { get; set; } = new();
}
