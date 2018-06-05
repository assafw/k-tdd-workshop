using System;
using Xunit;
using TargetLibrary;
using Shouldly;

namespace TargetLibrary.Tests
{
  public class StringCalculatorTests
  {
    private readonly StringCalculator target;

    public StringCalculatorTests()
    {
      target = new StringCalculator();
    }

    [Fact]
    public void MyFirstTest()
    {
      Assert.NotNull(target);
    }

    [Fact]
    public void WhenEmptyString_ShouldReturnZero()
    {
      target.Calculate("").ShouldBe(0);
    }

    [Fact]
    public void WhenSingleNumberAsInput_ShouldReturnIt()
    {
      target.Calculate("11").ShouldBe(11);
    }

    [Fact]
    public void WhenMultipleNumbers_ShouldReturnSum()
    {
      target.Calculate("1,2").ShouldBe(3);
    }

    [Fact]
    public void WhenHasThreeNumbersInInput_ShouldReturnSum()
    {
      target.Calculate("1,2,3").ShouldBe(6);
    }

    [Fact]
    public void WhenHasMoreThanThree_ShouldReturnSum()
    {
      target.Calculate("1,1,1,1,1,5").ShouldBe(10);
    }

    [Fact]
    public void WhenUsingNewLineDelimiter_ShouldReturnSum()
    {
      target.Calculate("1\n2").ShouldBe(3);
    }

    [Fact]
    public void WhenUsingMixedDelimiters_ShouldReturnSum()
    {
      target.Calculate("1,2\n3").ShouldBe(6);
    }
  }
}
