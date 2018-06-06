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

    [Fact]
    public void WhenCustomDelimiterIsDefined_ShouldReturnSum()
    {
      target.Calculate("//!\n1!2!3").ShouldBe(6);
    }

    [Fact]
    public void WhenCustomDelimiterIsDefinedAsPlus_ShouldReturnSum()
    {
      target.Calculate("//+\n1+1").ShouldBe(2);
    }

    [Fact]
    public void WhenOneNegativeNumberExists_ShouldThrowException()
    {
      Assert.Throws<InvalidOperationException>(() => target.Calculate("1,-1"));
    }

    [Fact]
    public void WhenOneNegativeNumberExists_ShouldThrowExceptionAndLogMessage()
    {
      var ex = Assert.Throws<InvalidOperationException>(() => target.Calculate("1,-1"));
      ex.Message.ShouldBe("Negatives not allowed: -1");
    }

    [Fact]
    public void WhenMultipleNegativeNumberExist_ShouldThrowExceptionAndLogMessage()
    {
      var ex = Assert.Throws<InvalidOperationException>(() => target.Calculate("1,-2,-3"));
      ex.Message.ShouldBe("Negatives not allowed: -2,-3");
    }

    [Fact]
    public void WhenNumberOver1000InInput_ShouldIgnoreWhenCalculatingSum()
    {
      target.Calculate("1,1001").ShouldBe(1);
      target.Calculate("1,1000").ShouldBe(1001);
    }
  }
}
