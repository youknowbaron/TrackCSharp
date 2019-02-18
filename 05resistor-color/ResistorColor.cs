using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        for (var i = 0; i < ResistorColor.Colors().Length; i++)
        {
            if (ResistorColor.Colors()[i] == color)
                return i;
        }

        return -1;
    }

    public static string[] Colors()
    {
        return new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }
}