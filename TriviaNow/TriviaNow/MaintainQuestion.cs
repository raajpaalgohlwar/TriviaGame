//Raajpaal Gohlwar CIS 345 12:00 PM Project Final
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    //Delegate for handling question events
    public delegate void QuestionEventHandler(Question q);

    public partial class MaintainQuestion : Form
    {
        //Events for creating and updating a question
        public event QuestionEventHandler QuestionCreated;
        public event QuestionEventHandler QuestionUpdated;

        public MaintainQuestion()
        {
            //Add form
            InitializeComponent();
            this.Text = "Add Question";
            maintainButton.Text = "&Add";
        }

        public MaintainQuestion(Question tmpQ)
        {
            //Update form
            InitializeComponent();
            this.Text = "Update Question";
            maintainButton.Text = "&Update";
            questionTextBox.Text = tmpQ.QuestionText;
            choice1TextBox.Text = tmpQ.Choice1;
            choice2TextBox.Text = tmpQ.Choice2;
            choice3TextBox.Text = tmpQ.Choice3;
            choice4TextBox.Text = tmpQ.Choice4;
            feedbackTextBox.Text = tmpQ.QuestionFeedback;
            correctChoiceComboBox.Text = tmpQ.CorrectChoice;
        }

        private void maintainButton_Click(object sender, EventArgs e)
        {
            Question tmpQuestion;

            if (maintainButton.Text == "&Add")
            {
                //Verification that user has entered all data
                if (questionTextBox.Text == string.Empty || choice1TextBox.Text == string.Empty
                    || choice2TextBox.Text == string.Empty || choice3TextBox.Text == string.Empty
                    || choice4TextBox.Text == string.Empty || feedbackTextBox.Text == string.Empty
                    || correctChoiceComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all data");
                }
                else
                {
                    switch (correctChoiceComboBox.Text)
                    {
                        //Switch statement to verify user selected proper choice
                        case "Choice 1":
                        case "Choice 2":
                        case "Choice 3":
                        case "Choice 4":
                            tmpQuestion = new Question(questionTextBox.Text,
                                           choice1TextBox.Text,
                                           choice2TextBox.Text,
                                           choice3TextBox.Text,
                                           choice4TextBox.Text,
                                           feedbackTextBox.Text,
                                           correctChoiceComboBox.Text);
                            QuestionCreated(tmpQuestion);
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Please select either Choice 1, 2, 3 or 4");
                            break;
                    }
                }
            }
            else if (maintainButton.Text == "&Update")
            {
                tmpQuestion = new Question(questionTextBox.Text,
                                               choice1TextBox.Text,
                                               choice2TextBox.Text,
                                               choice3TextBox.Text,
                                               choice4TextBox.Text,
                                               feedbackTextBox.Text,
                                               correctChoiceComboBox.Text);
                QuestionUpdated(tmpQuestion);
                this.Close();
            }
        }
    }
}
