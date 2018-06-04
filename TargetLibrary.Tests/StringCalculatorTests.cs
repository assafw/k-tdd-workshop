using System;
using Xunit;
using TargetLibrary;

namespace TargetLibrary.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void MyFirstTest()
    {
      Assert.NotNull(new StringCalculator());
    }
  }
}
