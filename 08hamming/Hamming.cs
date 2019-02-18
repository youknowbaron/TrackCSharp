using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) 
            throw new ArgumentException();

        var char1 = firstStrand.ToCharArray();
        var char2 = secondStrand.ToCharArray();
        var count = 0;
        for (var i = 0; i < firstStrand.Length; i++)
        {
            if (char1[i] != char2[i])
                count++;
        }

        return count;
    }
}