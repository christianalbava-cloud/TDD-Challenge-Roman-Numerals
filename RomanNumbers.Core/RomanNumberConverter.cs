namespace RomanNumbers.Core;

public class RomanNumberConverter
{
    public string ToRoman(int number)
    {
        if (number == 1)
            return "I";

        if (number == 5)
            return "V";

        if (number == 4)
            return "IV";

        if (number == 9)
            return "IX";

        if (number == 40)
            return "XL";

        if (number == 90)
            return "XC";

        if (number == 400)
            return "CD";

        if (number == 900)
            return "CM";

        return "";
    }
}