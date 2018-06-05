using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetLibrary
{
  public class StringCalculator
  {
    public int Calculate(string stringToCalculate)
    {
      if (stringToCalculate == string.Empty)
      {
        return 0;
      }

      return stringToCalculate.Split(',', '\n').Sum(x => int.Parse(x));
    }
  }
}
