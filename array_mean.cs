using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    // get the mean of a given array, and round down to the lowest whole number
  public static int GetAverage(int[] marks)
  {
        // array average
        double average = marks.Average();
        // round to lowest integer
        int lower = (int)Math.Floor(average);
        // return value
        return lower;
  }
}