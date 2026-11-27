using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests;

public class FizzBuzzDetectorTests
{
    private readonly FizzBuzzDetector _detector = new();

    [Fact]
    public void ThirdWord_ShouldBeReplacedWithFizz()
    {
        var result = _detector.getOverlappings("Asma loves drawing.");

        Assert.Equal("Asma loves Fizz.", result.Output);
        Assert.Equal(1, result.totalCount);
    }

    [Fact]
    public void FifthWord_ShouldBeReplacedWithBuzz()
    {
        var result = _detector.getOverlappings(
            "Asma loves drawing and painting.");

        Assert.Equal("Asma loves Fizz and Buzz.", result.Output);
        Assert.Equal(2, result.totalCount);
    }

    [Fact]
    public void FifteenthWord_ShouldBeReplacedWithFizzBuzz()
    {
        var result = _detector.getOverlappings(
            "Asma enjoys painting and reading books. She also loves coding and solving problems every day.");

        Assert.Equal(
            "Asma enjoys Fizz and Buzz Fizz. She also Fizz Buzz and Fizz problems every FizzBuzz.",
            result.Output);
        Assert.Equal(7, result.totalCount);
    }

    [Fact]
    public void Punctuation_ShouldBePreserved()
    {
        var result = _detector.getOverlappings(
            "Hello, Asma is here!");

        Assert.Equal("Hello, Asma Fizz here!", result.Output);
    }

    [Fact]
    public void MultipleSpaces_ShouldBePreserved()
    {
        var result = _detector.getOverlappings(
            "Asma  loves   painting");

        Assert.Equal("Asma  loves   Fizz", result.Output);
    }

    [Fact]
    public void EmptyInput_ShouldReturnEmptyOutput()
    {
        var result = _detector.getOverlappings("");

        Assert.Equal("", result.Output);
        Assert.Equal(0, result.totalCount);
    }
}