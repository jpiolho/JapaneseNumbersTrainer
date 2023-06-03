namespace JapaneseNumbersTrainer.Base;

public static class Utils
{
    public static TItem? GetNewRandomFromArrayNullable<TItem>(IList<TItem> array, Nullable<TItem> previous) where TItem : struct
    {
        TItem value;

        do
        {
            value = array[Random.Shared.Next(0, array.Count)];
        }
        while (previous != null && EqualityComparer<TItem>.Default.Equals(value, previous.Value));

        return value;
    }
}
