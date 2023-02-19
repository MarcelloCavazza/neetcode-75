using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    internal class AnagramTest
    {
        public static string firstTextIsAnagramOfTheSecondText(string originalString, string possibleString)
        {
            string originalStringTreated = originalString.Trim().ToLower();
            string possibleStringTreated = possibleString.Trim().ToLower();
            string[] possibleAnagramArray = possibleStringTreated.Split("");
            if (possibleStringTreated == originalStringTreated) return "Same word";
            for(int index = 0; index < possibleAnagramArray.Length; index++)
            {
                char storedLetter = Convert.ToChar(possibleAnagramArray[index]);
                int indexOfLetter = Array.IndexOf(possibleAnagramArray, storedLetter);

                string[] newArrayToTestNewPossibleAnagram = new string[possibleAnagramArray.Length];
                
            }
        }
    }
}
