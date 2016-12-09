using System;

public class Dubstep
{
    public static string SongDecoder(string input)
    {
        return string.Join(" ", input.Split(new string[] { "WUB" }, int.MaxValue, StringSplitOptions.RemoveEmptyEntries));
    }
}
