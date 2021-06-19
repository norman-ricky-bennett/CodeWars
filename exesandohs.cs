using System.Linq;
using System;
public static class Kata 
{
    // Count occurences of exes and ohs in a given string
    // and determine if there are the same number of occurences of both letters
    // return boolean 
  public static bool XO (string input)
  {
    string lowerInput = input.ToLower();
    char ex = 'x';
    char o = 'o';
    int xFreq = lowerInput.Where(x => (x == ex)).Count();
    int yFreq = lowerInput.Where(x => (x == o)).Count();
    
    if (xFreq == yFreq)
      return true;
    else
      return false;
  }
}