//Raajpaal Gohlwar CIS 345 12:00 PM Project Final
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class TriviaGame : Form
    {
        List<Question> gameQuestions;
        int questionCounter;
        int correctGuesses;
        bool gameOver;
        TriviaNow homePage;
        SoundPlayer backgroundMusic;
        SoundPlayer wrongAnswer;
        SoundPlayer correctAnswer;

        public TriviaGame()
        {
            InitializeComponent();
        }

        public TriviaGame(List<Question> questions)
        {
            InitializeComponent();
            gameQuestions = questions;
        }

        private void TriviaGame_Load(object sender, EventArgs e)
        {
            //Initializes trivia game
            questionCounter = 0;
            correctGuesses = 0;
            SetGameQuestion();
            gameOver = false;
            homePage = new TriviaNow();

            //Sets background music
            backgroundMusic = new SoundPlayer("BackgroundMusic.wav");
            backgroundMusic.Load();
            backgroundMusic.PlayLooping();

            //Sets wrong answer music
            wrongAnswer = new SoundPlayer("WrongAnswer.wav");
            wrongAnswer.Load();

            //Sets correct answer music
            correctAnswer = new SoundPlayer("CorrectAnswer.wav");
            correctAnswer.Load();
        }

        private void SetGameQuestion()
        {
            //Fill game controls with new question
            triviaGameStatusStripLabel.Text = $"Question {questionCounter + 1}/3";
            gameGroupBox.Text = $"Question {questionCounter + 1}";
            gameQuestionLabel.Text = gameQuestions[questionCounter].QuestionText;
            gameChoiceRadioButton1.Text = gameQuestions[questionCounter].Choice1;
            gameChoiceRadioButton2.Text = gameQuestions[questionCounter].Choice2;
            gameChoiceRadioButton3.Text = gameQuestions[questionCounter].Choice3;
            gameChoiceRadioButton4.Text = gameQuestions[questionCounter].Choice4;

            //Hide user feedback
            gameFeedbackLabel.Visible = false;
            userFeedbackPanel.Visible = false;
            resultLabel.Visible = false;
            continueButton.Visible = false;

            //Display question controls
            gameQuestionLabel.Visible = true;
            gameChoiceRadioButton1.Visible = true;
            gameChoiceRadioButton2.Visible = true;
            gameChoiceRadioButton3.Visible = true;
            gameChoiceRadioButton4.Visible = true;
            gameSubmitButton.Visible = true;
        }

        private void gameSubmitButton_Click(object sender, EventArgs e)
        {
            string userChoice = "";

            //Hide question controls
            gameQuestionLabel.Visible = false;
            gameChoiceRadioButton1.Visible = false;
            gameChoiceRadioButton2.Visible = false;
            gameChoiceRadioButton3.Visible = false;
            gameChoiceRadioButton4.Visible = false;
            gameSubmitButton.Visible = false;

            //Identify users selection and create a string
            if (gameChoiceRadioButton1.Checked == true)
            {
                userChoice = "Choice 1";
            }
            else if (gameChoiceRadioButton2.Checked == true)
            {
                userChoice = "Choice 2";
            }
            else if (gameChoiceRadioButton3.Checked == true)
            {
                userChoice = "Choice 3";
            }
            else if (gameChoiceRadioButton4.Checked == true)
            {
                userChoice = "Choice 4";
            }

            //Decide if user entered correct answer and display user feedback
            if (userChoice == gameQuestions[questionCounter].CorrectChoice)
            {
                //Display user feedback for correct answer
                correctAnswer.Play();
                correctGuesses++;
                gameFeedbackLabel.Text = gameQuestions[questionCounter].QuestionFeedback;
                gameFeedbackLabel.Visible = true;
                userFeedbackPanel.Visible = true;
                resultLabel.Visible = true;
                continueButton.Visible = true;
                resultLabel.Text = "Correct!";
                questionCounter++;
            }
            else
            {
                //Display user feedback for incorrect answer
                wrongAnswer.Play();
                gameFeedbackLabel.Text = gameQuestions[questionCounter].QuestionFeedback;
                gameFeedbackLabel.Visible = true;
                userFeedbackPanel.Visible = true;
                resultLabel.Visible = true;
                continueButton.Visible = true;
                resultLabel.Text = "Wrong!";
                questionCounter++;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                if (questionCounter < 3)
                {
                    SetGameQuestion();
                    backgroundMusic.PlayLooping();
                    gameOver = false;
                }
                else
                {
                    //End game
                    //Hide question controls
                    gameQuestionLabel.Visible = false;
                    gameChoiceRadioButton1.Visible = false;
                    gameChoiceRadioButton2.Visible = false;
                    gameChoiceRadioButton3.Visible = false;
                    gameChoiceRadioButton4.Visible = false;
                    gameSubmitButton.Visible = false;

                    //Display user feedback
                    gameFeedbackLabel.Text = "";
                    gameFeedbackLabel.Visible = true;
                    gameFeedbackLabel.Text = "Thanks for playing!";
                    userFeedbackPanel.Visible = true;
                    resultLabel.Visible = true;
                    resultLabel.Left = 100;
                    continueButton.Visible = true;
                    resultLabel.Text = $"You scored a {correctGuesses} out of 3!";
                    gameOver = true;
                    backgroundMusic.PlayLooping();
                }
            }
            else if(gameOver == true)
            {
                this.Close();
                backgroundMusic.Stop();
            }
        }
    }
}
