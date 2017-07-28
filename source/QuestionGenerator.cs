using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Game
{
    class QuestionGenerator
    {
        public static int answer;

        public static string Generate()
        {
            Random r = new Random();
            int randomOne = r.Next(1, 12);
            int randomTwo = r.Next(1, 12);
            r = null; // dispose r, we no longer need it
            answer = randomOne * randomTwo;

            return "What is " + randomOne + " times " + randomTwo + "?";
        }
    }
}
