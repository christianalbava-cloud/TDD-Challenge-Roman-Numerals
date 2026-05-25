using FluentAssertions;
using RomanNumbers.Core;


namespace RomanNumbers.Tests;

public class RomanNumberConverterTests
{
    [Fact]
    public void Should_Convert_1_To_I()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(1);

        result.Should().Be("I");
    }

    [Fact]
    public void Should_Convert_5_To_V()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(5);

        result.Should().Be("V");
    }

    [Fact]
    public void Should_Convert_Number_4_To_Roman_Number()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(4);

        result.Should().Be("IV");
    }

    [Fact]
    public void Should_Convert_Number_9_To_Roman_Number()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(9);

        result.Should().Be("IX");
    }

    [Fact]
    public void Should_Convert_Number_40_To_Roman_Number()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(40);

        result.Should().Be("XL");
    }

    [Fact]
    public void Should_Convert_Number_90_To_Roman_Number()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(90);

        result.Should().Be("XC");
    }

    [Fact]
    public void Should_Convert_Number_400_To_Roman_Number()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(400);

        result.Should().Be("CD");
    }

    [Fact]
    public void Should_Convert_Number_900_To_Roman_Number()
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(900);

        result.Should().Be("CM");
    }


    [Theory]
    [InlineData(3, "III")]
    [InlineData(14, "XIV")]
    [InlineData(26, "XXVI")]
    [InlineData(39, "XXXIX")]
    [InlineData(51, "LI")]
    [InlineData(68, "LXVIII")]
    [InlineData(84, "LXXXIV")]
    [InlineData(128, "CXXVIII")]
    [InlineData(489, "CDLXXXIX")]
    [InlineData(731, "DCCXXXI")]
    [InlineData(896, "DCCCXCVI")]

    public void Should_Convert_Number_N_To_Roman_Number(int num, string expected)
    {
        var converter = new RomanNumberConverter();

        var result = converter.ToRoman(num);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-100)]
    public void Should_Fail_Convert_Negative_and_Zero_Number_To_Roman_Number(int negativeNumber)
    {
        var converter = new RomanNumberConverter();

        Action act = () => converter.ToRoman(negativeNumber);

        act.Should()
          .Throw<ArgumentOutOfRangeException>()
          .WithMessage("The number can not be less than 0*");
    }
}