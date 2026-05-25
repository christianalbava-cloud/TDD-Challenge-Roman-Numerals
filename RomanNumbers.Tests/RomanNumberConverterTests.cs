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
}