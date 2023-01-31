using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // set top and bottom to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        // One param for top and set bottom to 1
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        // Two params for top and bottom
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = ($"{_top} / {_bottom}");
        return text;
    }

    public double GetDecimalString()
    {
        return (double)_top / (double)_bottom;
    }


}