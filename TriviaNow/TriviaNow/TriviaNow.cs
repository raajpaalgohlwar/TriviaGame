//Raajpaal Gohlwar CIS 345 12:00 PM Project Final
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class TriviaNow : Form
    {
        BindingList<Question> questionList;
        BindingList<Question> userSearchList;
        List<Question> triviaGameQuestions;
        MaintainQuestion newForm;
        TriviaGame newGame;
        private Question questionToBeUpdated;
        Random randomQuestion;
        int randInt;
        int[] oldIntArray;
        int[] previousIntArray;
        int[] currentIntArray;
        bool intNotInArray;

        public TriviaNow()
        {
            InitializeComponent();
        }

        private void TriviaNow_Load(object sender, EventArgs e)
        {
            //Assigning questionList as the list box data source
            questionList = new BindingList<Question>();
            questionListBox.DataSource = questionList;

            //Instantiate game question list
            triviaGameQuestions = new List<Question>();

            //Initialize lists for selecting random questions
            oldIntArray = new int[3];
            oldIntArray[0] = -1;
            oldIntArray[1] = -1;
            oldIntArray[2] = -1;
            previousIntArray = new int[3];
            previousIntArray[0] = -1;
            previousIntArray[1] = -1;
            previousIntArray[2] = -1;
            currentIntArray = new int[3];
            intNotInArray = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            notificationStatusLabel.Text = "Ready";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            
            //Try/catch block for opening file
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    questionList = bf.Deserialize(file) as BindingList<Question>;
                    questionListBox.DataSource = questionList;
                    notificationStatusLabel.Text = "Data loaded";
                }
            }
            catch (Exception)
            {
                notificationStatusLabel.Text = "Data loading not successful";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;

                //Try/Catch block for saving file
                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, questionList);
                    file.Close();
                    notificationStatusLabel.Text = "File saved";
                }
                catch (Exception)
                {
                    notificationStatusLabel.Text = "Save not successful";
                }
            }
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Construct the sub form
            newForm = new MaintainQuestion();

            //Wire the event
            newForm.QuestionCreated += new QuestionEventHandler(NewQuestionCreated);

            //Show the form
            newForm.Show();
        }

        private void updateQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question tmpQ;

            //Verification that user has selected an item to update
            if (questionListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a question you would like to update");
            }
            else
            {
                tmpQ = questionListBox.SelectedItem as Question;
                questionToBeUpdated = questionListBox.SelectedItem as Question;

                //Construct the sub form
                newForm = new MaintainQuestion(tmpQ);

                //Wire the event
                newForm.QuestionUpdated += new QuestionEventHandler(QuestionUpdated);

                //Show the form
                newForm.Show();
            }
        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code to allow user to delete multiple entries at once
            Question tmpQ;

            if (questionListBox.SelectedItems == null)
            {
                MessageBox.Show("Please select a question you would like to delete");
            }
            else
            {
                tmpQ = questionListBox.SelectedItem as Question;
                questionList.Remove(tmpQ);
                notificationStatusLabel.Text = "A question has been deleted";
                timer.Enabled = true;
            }
        }

        private void NewQuestionCreated(Question q)
        {
            //Event handler for creating a new question
            questionList.Add(q);
            notificationStatusLabel.Text = "A new question has been added";
            timer.Enabled = true;
        }

        private void QuestionUpdated(Question q)
        {
            //Delete existing question from list
            questionList.Remove(questionToBeUpdated);

            //Event handler for updating a question
            questionList.Add(q);
            notificationStatusLabel.Text = "A question has been updated";
            timer.Enabled = true;
        }

        private void questionListBox_DoubleClick(object sender, EventArgs e)
        {
            this.updateQuestionToolStripMenuItem_Click(sender, e);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionList.Count == 0)
            {
                MessageBox.Show("Please enter a minimum of 3 questions before starting a game");
            }
            else
            {
                //Clear trivia game list
                triviaGameQuestions.Clear();

                //Select three random questions
                randomQuestion = new Random();
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        //Generates random integer
                        randInt = randomQuestion.Next(0, questionList.Count);

                        //Logic to check if random integer has already been selected in past arrays
                        if (randInt == oldIntArray[0] || randInt == oldIntArray[1] || randInt == oldIntArray[2])
                        {
                            intNotInArray = false;
                        }
                        else if (randInt == previousIntArray[0] || randInt == previousIntArray[1] || randInt == previousIntArray[2])
                        {
                            intNotInArray = false;
                        }
                        else if ((i == 1) && (randInt == currentIntArray[0]))
                        {
                            intNotInArray = false;
                        }
                        else if ((i == 2) && (randInt == currentIntArray[1] || randInt == currentIntArray[0]))
                        {
                            intNotInArray = false;
                        }
                        else
                        {
                            triviaGameQuestions.Add(questionList[randInt]);
                            currentIntArray[i] = randInt;
                            intNotInArray = true;
                        }
                    } while (intNotInArray == false);
                }

                //Pre-populate the Trivia Game Question List
                triviaGameQuestions.Add(questionList[currentIntArray[0]]);
                triviaGameQuestions.Add(questionList[currentIntArray[1]]);
                triviaGameQuestions.Add(questionList[currentIntArray[2]]);

                //Enter in previous numbers to oldIntArray
                for (int i = 0; i < oldIntArray.Length; i++)
                {
                    oldIntArray[i] = previousIntArray[i];
                }

                //Enter in current numbers to previousIntArray
                for (int i = 0; i < previousIntArray.Length; i++)
                {
                    previousIntArray[i] = currentIntArray[i];
                }
                
                //Construct the game subform
                newGame = new TriviaGame(triviaGameQuestions);

                //Show the game form
                newGame.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saves data
            this.saveToolStripMenuItem_Click(this, e);

            //Cleanly exits application
            System.Environment.Exit(0);
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            //Clears previous text and allows user to search questions
            searchTextBox.Text = "";
            searchTextBox.Focus();

            //Reset listBox DataSource to questionList to display available questions
            questionListBox.DataSource = questionList;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string userSearch;

            //Instantiates userSearchList
            userSearchList = new BindingList<Question>();

            //Search through questions, choices, and feedback
            userSearch = searchTextBox.Text.ToUpper();
            for (int i = 0; i < questionList.Count; i++)
            {
                if (questionList[i].QuestionText.ToUpper().Contains(userSearch))
                {
                    userSearchList.Add(questionList[i]);
                }
                else if (questionList[i].Choice1.ToUpper().Contains(userSearch))
                {
                    userSearchList.Add(questionList[i]);
                }
                else if (questionList[i].Choice2.ToUpper().Contains(userSearch))
                {
                    userSearchList.Add(questionList[i]);
                }
                else if (questionList[i].Choice3.ToUpper().Contains(userSearch))
                {
                    userSearchList.Add(questionList[i]);
                }
                else if (questionList[i].Choice4.ToUpper().Contains(userSearch))
                {
                    userSearchList.Add(questionList[i]);
                }
                else if (questionList[i].QuestionFeedback.ToUpper().Contains(userSearch))
                {
                    userSearchList.Add(questionList[i]);
                }
            }

            questionListBox.DataSource = userSearchList;
        }
    }
}
