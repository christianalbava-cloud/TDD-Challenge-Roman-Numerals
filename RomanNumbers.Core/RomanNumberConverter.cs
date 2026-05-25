using System.Text;

namespace RomanNumbers.Core;

public class RomanNumberConverter
{
    public string ToRoman(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(number),
                "The number can not be less than 0"
            );

        var romanMap = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        StringBuilder result = new StringBuilder();

        foreach (var item in romanMap)
        {
            while (number >= item.Key)
            {
                result.Append(item.Value);
                number -= item.Key;
            }
        }

        return result.ToString();
    }
}