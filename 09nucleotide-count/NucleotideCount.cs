using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotide = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        var arr = sequence.ToCharArray();
        foreach (var c in arr)
        {
            switch (c)
            {
                case 'A':
                    nucleotide['A']++;
                    break;
                case 'C':
                    nucleotide['C']++;
                    break;
                case 'G':
                    nucleotide['G']++;
                    break;
                case 'T':
                    nucleotide['T']++;
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }

        return nucleotide;
    }
}