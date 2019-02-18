using System;

public static class TwoFer
{
    public static string Name(string input = "you")
    {
        var ret = "One for " + input + ", one for me.";
        return ret;
    }
}