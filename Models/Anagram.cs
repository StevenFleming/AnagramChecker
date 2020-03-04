using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramCheck
    {
        public static char[] Initialwordarray;
        public static string sortedString;

        public static List<string> userAnagram = new List<string>() { };
        public static List<string> FinalCheck = new List<string>() { };

        public static void AnagramChecker(string userinput)
        {
            Initialwordarray = userinput.ToCharArray();
            Array.Sort(Initialwordarray);
            sortedString = new string(Initialwordarray);
            FinalCheck.Add(sortedString);
            for (int i = 0; i < FinalCheck.Count; i++)
            {
                if (FinalCheck[0] == FinalCheck[i])
                {
                    Console.WriteLine("Match" + FinalCheck[i]);
                }
            }

        }



    }
}