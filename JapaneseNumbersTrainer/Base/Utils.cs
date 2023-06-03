using System;

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

    public static int GetNewRandomInt(int minInclusive,int maxExclusive, int? previous)
    {
        int newRandomInt;

        do
        {
            newRandomInt = Random.Shared.Next(minInclusive, maxExclusive);
        } while (previous.HasValue && newRandomInt == previous.Value);

        return newRandomInt;
    }

    public static string ToStringOrdinal(int num)
    {
        if (num <= 0) return num.ToString();

        switch (num % 100)
        {
            case 11:
            case 12:
            case 13:
                return num + "th";
        }

        switch (num % 10)
        {
            case 1:
                return num + "st";
            case 2:
                return num + "nd";
            case 3:
                return num + "rd";
            default:
                return num + "th";
        }
    }
}
