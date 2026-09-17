using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp2
{
    public class AnswerChecker
    {
        public bool CheckAnswer(Question q, int selectedIndex)
        {
            return q.CorrectIndex == selectedIndex;

            //
        }
    }
}