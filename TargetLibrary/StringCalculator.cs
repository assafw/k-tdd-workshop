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

      if (stringToCalculate.StartsWith("//"))
      {
        return CalculateWithCustomDelimiter(stringToCalculate);
      }

      return CalculateSum(Split(stringToCalculate, ",", "\n"));
    }

    private int CalculateWithCustomDelimiter(string stringToCalculate)
    {
      var lines = stringToCalculate.Split('\n');
      var delimiters = GetCustomDelimiters(lines[0]);

      return CalculateSum(Split(lines[1], delimiters.ToArray()));
    }

    private IEnumerable<string> GetCustomDelimiters(string line)
    {
        var delimiters = line.Trim('/');

        if (delimiters.StartsWith("["))
        {
          var customDelimiters = Split(delimiters.Trim('[', ']'), "][");
          return customDelimiters;
        }

        return new[] { delimiters };
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

      return nums.Where(n => n <= 1000).Sum();
    }
  }
}
