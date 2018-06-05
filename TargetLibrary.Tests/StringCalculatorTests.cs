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
  }
}
