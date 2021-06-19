using System;

public static class Kata
{
    // method to remove vowels from a given string 
    public static string Disemvowel(string str)
    {
        string[] vowels = {"a","e","i","o","u","A","E","I","O","U"}; 
        // iterate through the whole string using a for loop
        for (int i = 0; i < vowels.Length; i++)
        {
            // replace vowels with nothing
            str = str.Replace(vowels[i],"");  
        }
        return str;
    }
   
}