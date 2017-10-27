using System.Collections.Generic;
using System.Linq;

namespace MatchClass
{
    public class Match
    {
        public bool DoMatch(string input)
        {
            bool isMatched = false;

            Stack<int> stack = new Stack<int>();

            //logic
            //1.when you see ( push it and pop stack when you see ) 
            //2.if stack has no ( but if ) entered, it fails
            //3.finally when the string is parsed completely the stack should be empty
            //4.if not 3, it fail 

            int indexOfEnteredOpenParen = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                        stack.Push(i);
                        isMatched = false;
                        break;
                    case ')':
                        indexOfEnteredOpenParen = stack.Any() ? 0 : -1;
                        if (indexOfEnteredOpenParen == 0) stack.Pop();
                        isMatched = (indexOfEnteredOpenParen == 0);
                        break;
                    default:
                        isMatched = false;
                        break;
                }

            }


            if (stack.Any())
                isMatched = false;

            return isMatched;
        }
    }
}
