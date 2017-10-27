using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchClass
{
    public class Match
    {
        public bool DoMatch(string input)
        {
            bool isMatched = true;

            Stack<string> stack = new Stack<string>();

            //logic
            //1.when you see ( push it and pop stack when you see ) 
            //2.if stack has no ( but if ) entered, it fails
            //3.finally when the string is parsed completely the stack should be empty

            return isMatched;
        }
    }
}
