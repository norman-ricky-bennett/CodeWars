using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        str = "This website is for losers LOL!"
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        string newString = str.TrimEnd(vowels);
        return newString;
    }
   
}