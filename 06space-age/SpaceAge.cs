using System;
using System.Runtime.InteropServices;

public class SpaceAge
{
    private const int YearInSeconds = 31557600;
    private readonly int _seconds;

    public SpaceAge(int seconds)
    {
        this._seconds = seconds;
    }

    public double OnEarth()
    {
        return Math.Round((double) _seconds / YearInSeconds, 2);
    }

    public double OnMercury()
    {
        return Math.Round(OnEarth() / 0.2408467, 2);
    }

    public double OnVenus()
    {
        return Math.Round(OnEarth() / 0.61519726, 2);
    }

    public double OnMars()
    {
        return Math.Round(OnEarth() / 1.8808158, 2);
    }

    public double OnJupiter()
    {
        return Math.Round(OnEarth() / 11.862615, 2);
    }

    public double OnSaturn()
    {
        return Math.Round(OnEarth() / 29.447498, 2);
    }

    public double OnUranus()
    {
        return Math.Round(OnEarth() / 84.016846, 2);
    }

    public double OnNeptune()
    {
        return Math.Round(OnEarth() / 164.79132, 2);
    }
}