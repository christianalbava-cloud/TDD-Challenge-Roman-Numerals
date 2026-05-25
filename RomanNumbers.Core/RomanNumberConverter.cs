namespace RomanNumbers.Core;

public class RomanNumberConverter
{
    public string ToRoman(int number)
    {
        if (number == 1)
            return "I";

        if (number == 5)
            return "V";

        return "";
    }
}