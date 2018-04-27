using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RiskFirstProject2
{
    class ExtractString
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //The better way is to use Regex but be honest after trying it multiple times without success I gave up
        //and approach differently .
        public string ExtractText(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                int lastIndexofOpenBracket = input.LastIndexOf(" /* "); 
                int lastIndexofClosedBracket = input.LastIndexOf(" */ ");
              
                int length = lastIndexofClosedBracket - lastIndexofOpenBracket  +1;
                string str = input.Substring(lastIndexofOpenBracket+3, length-3);

                return str;
            }
            else
            {
                log.Error("Input string is an empty or null.");
                return null ;
            }
        }
    }
}
