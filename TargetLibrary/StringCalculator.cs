﻿using System;
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

      if (stringToCalculate.StartsWith("//"))
      {
        var lines = stringToCalculate.Split('\n');
        var delimiter = lines[0].Trim('/');

        return CalculateSum(Split(lines[1], delimiter));
      }

      return CalculateSum(Split(stringToCalculate, ",", "\n"));
    }

    private IEnumerable<string> Split(string input, params string[] delimiters)
    {
      return input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    }

    private int CalculateSum(IEnumerable<string> numbers)
    {
      var nums = numbers.Select(n => int.Parse(n));
      if (nums.Any(n => n < 0))
      {
        throw new InvalidOperationException("Negatives not allowed: " + string.Join(",", nums.Where(n => n < 0)));
      }

      return numbers.Sum(n => int.Parse(n));
    }
  }
}
