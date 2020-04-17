using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Backwards
    {
        public bool BackwardsTests(string word)
        {

            word = word.ToLower().Replace(" ", string.Empty).Replace(",", string.Empty).Replace("!", string.Empty);
            bool testAgent = false;
            var characters = word.Reverse().ToList();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == characters[i])
                {
                    testAgent = true;
                }
                else
                {
                    {
                        testAgent = false;
                        break;
                    }
                }
            }

            return testAgent;
        }
    }
}
