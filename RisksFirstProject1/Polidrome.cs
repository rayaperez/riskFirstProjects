using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 * To implement a method for determining whether a string is a Palindrome 
 * You should ignore any whitespace 
 * and non alphabetic characters, 
 * and the comparison should be case insensitive.
 */
namespace RisksFirstProject1
{
    public class Polidrome
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool IsPalindrome(string input)
        {
            String reversedString = null;

            if (!string.IsNullOrEmpty(input))
            {
                string amendedString = maintainString(input);

                reversedString = new string(input.Reverse().ToArray());
            }
            else
            {
                log.Error("Input string is an empty or null.");
                return false;
            }

            return input == reversedString;
        }

        //as we going to ignore white spaces, non alphabetics and spaces 
        //I am going to completely remove them from the string and lower all the chars
        //to avoid cases insensitive test
        private string maintainString(String str)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            str = regex.Replace(str, "");

            string removeWhiteSpaces  = new string(str.ToCharArray()
                                            .Where(c => !Char.IsWhiteSpace(c))
                                            .ToArray());
            string lowerAllChars = removeWhiteSpaces.ToLowerInvariant();

            return lowerAllChars;
        }
    }
}
