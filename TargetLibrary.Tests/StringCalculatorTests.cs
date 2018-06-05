using System;
using Xunit;
using TargetLibrary;

namespace TargetLibrary.Tests
{
  public class StringCalculatorTests
  {
    [Fact]
    public void MyFirstTest()
    {
      Assert.NotNull(new StringCalculator());
    }

    [Fact]
    public void WhenEmptyStringShouldReturnZero()
    {
      Assert.Equal(0, new StringCalculator().Calculate(""));
    }
  }
}
