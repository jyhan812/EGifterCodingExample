﻿using System;
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
            bool isMatched = false;

            Stack<int> stack = new Stack<int>();

            //logic
            //1.when you see ( push it and pop stack when you see ) 
            //2.if stack has no ( but if ) entered, it fails
            //3.finally when the string is parsed completely the stack should be empty

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
                        indexOfEnteredOpenParen = stack.Any() ? stack.Pop() : -1;
                        isMatched = (indexOfEnteredOpenParen == 0);
                        break;
                    default:
                        isMatched = false;
                        break;
                }

            }

            return isMatched;
        }
    }
}
