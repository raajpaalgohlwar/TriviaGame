//Raajpaal Gohlwar CIS 345 12:00 PM Project Final
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]
    public class Question
    {
        private string questionText;
        private string choice1;
        private string choice2;
        private string choice3;
        private string choice4;
        private string questionFeedback;
        private string correctChoice;

        public string QuestionText { get => questionText; set => questionText = value; }
        public string Choice1 { get => choice1; set => choice1 = value; }
        public string Choice2 { get => choice2; set => choice2 = value; }
        public string Choice3 { get => choice3; set => choice3 = value; }
        public string Choice4 { get => choice4; set => choice4 = value; }
        public string QuestionFeedback { get => questionFeedback;
            set => questionFeedback = value; }
        public string CorrectChoice { get => correctChoice; set => correctChoice = value; }

        public Question(string questionText, string choice1, string choice2, string choice3, 
            string choice4, string questionFeedback, string correctChoice)
        {
            QuestionText = questionText;
            Choice1 = choice1;
            Choice2 = choice2;
            Choice3 = choice3;
            Choice4 = choice4;
            QuestionFeedback = questionFeedback;
            CorrectChoice = correctChoice;
        }

        public Question()
        {

        }

        public override string ToString()
        {
            return $"{questionText}";
        }
    }
}
