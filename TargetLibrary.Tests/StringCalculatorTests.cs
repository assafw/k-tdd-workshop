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
    public void WhenEmptyStringShouldReturnZero()
    {
      target.Calculate("").ShouldBe(0);
    }

    [Fact]
    public void WhenEmptyStringReturnZero()
    {
      Assert.Equal(0, target.Calculate(""));
    }

    [Fact]
    public void WhenOnlySingleNumberReturnIt()
    {
      Assert.Equal(11, target.Calculate("11"));
    }

    [Fact]
    public void WhenMultipleNumbersReturnSum()
    {
      Assert.Equal(3, target.Calculate("1,2"));
    }

    [Fact]
    public void WhenHas3NumbersReturnSum()
    {
      Assert.Equal(6, target.Calculate("1,2,3"));
    }

    [Fact]
    public void WhenHasAlotOfNumbersReturnSum()
    {
      Assert.Equal(10, target.Calculate("1,1,1,1,1,5"));
    }
  }
}
