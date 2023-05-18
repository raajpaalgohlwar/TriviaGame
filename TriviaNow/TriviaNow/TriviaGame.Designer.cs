namespace TriviaNow
{
    partial class TriviaGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaGame));
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.userFeedbackPanel = new System.Windows.Forms.Panel();
            this.continueButton = new System.Windows.Forms.Button();
            this.gameFeedbackLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.gameSubmitButton = new System.Windows.Forms.Button();
            this.gameQuestionLabel = new System.Windows.Forms.Label();
            this.gameChoiceRadioButton1 = new System.Windows.Forms.RadioButton();
            this.gameChoiceRadioButton2 = new System.Windows.Forms.RadioButton();
            this.gameChoiceRadioButton4 = new System.Windows.Forms.RadioButton();
            this.gameChoiceRadioButton3 = new System.Windows.Forms.RadioButton();
            this.triviaGameStatusStrip = new System.Windows.Forms.StatusStrip();
            this.triviaGameStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameGroupBox.SuspendLayout();
            this.userFeedbackPanel.SuspendLayout();
            this.triviaGameStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.gameGroupBox.Controls.Add(this.userFeedbackPanel);
            this.gameGroupBox.Controls.Add(this.gameSubmitButton);
            this.gameGroupBox.Controls.Add(this.gameQuestionLabel);
            this.gameGroupBox.Controls.Add(this.gameChoiceRadioButton1);
            this.gameGroupBox.Controls.Add(this.gameChoiceRadioButton2);
            this.gameGroupBox.Controls.Add(this.gameChoiceRadioButton4);
            this.gameGroupBox.Controls.Add(this.gameChoiceRadioButton3);
            this.gameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameGroupBox.ForeColor = System.Drawing.Color.White;
            this.gameGroupBox.Location = new System.Drawing.Point(12, 31);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(558, 261);
            this.gameGroupBox.TabIndex = 0;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Question #";
            // 
            // userFeedbackPanel
            // 
            this.userFeedbackPanel.Controls.Add(this.continueButton);
            this.userFeedbackPanel.Controls.Add(this.gameFeedbackLabel);
            this.userFeedbackPanel.Controls.Add(this.resultLabel);
            this.userFeedbackPanel.Location = new System.Drawing.Point(6, 76);
            this.userFeedbackPanel.Name = "userFeedbackPanel";
            this.userFeedbackPanel.Size = new System.Drawing.Size(546, 100);
            this.userFeedbackPanel.TabIndex = 8;
            // 
            // continueButton
            // 
            this.continueButton.ForeColor = System.Drawing.Color.Black;
            this.continueButton.Location = new System.Drawing.Point(445, 70);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(81, 27);
            this.continueButton.TabIndex = 8;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // gameFeedbackLabel
            // 
            this.gameFeedbackLabel.AutoSize = true;
            this.gameFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameFeedbackLabel.Location = new System.Drawing.Point(3, 50);
            this.gameFeedbackLabel.Name = "gameFeedbackLabel";
            this.gameFeedbackLabel.Size = new System.Drawing.Size(78, 17);
            this.gameFeedbackLabel.TabIndex = 5;
            this.gameFeedbackLabel.Text = "Feedback";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(200, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(123, 32);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Correct!";
            // 
            // gameSubmitButton
            // 
            this.gameSubmitButton.ForeColor = System.Drawing.Color.Black;
            this.gameSubmitButton.Location = new System.Drawing.Point(33, 198);
            this.gameSubmitButton.Name = "gameSubmitButton";
            this.gameSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.gameSubmitButton.TabIndex = 6;
            this.gameSubmitButton.Text = "Submit";
            this.gameSubmitButton.UseVisualStyleBackColor = true;
            this.gameSubmitButton.Click += new System.EventHandler(this.gameSubmitButton_Click);
            // 
            // gameQuestionLabel
            // 
            this.gameQuestionLabel.AutoSize = true;
            this.gameQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameQuestionLabel.Location = new System.Drawing.Point(19, 35);
            this.gameQuestionLabel.Name = "gameQuestionLabel";
            this.gameQuestionLabel.Size = new System.Drawing.Size(120, 17);
            this.gameQuestionLabel.TabIndex = 4;
            this.gameQuestionLabel.Text = "Game Question";
            // 
            // gameChoiceRadioButton1
            // 
            this.gameChoiceRadioButton1.AutoSize = true;
            this.gameChoiceRadioButton1.Checked = true;
            this.gameChoiceRadioButton1.Location = new System.Drawing.Point(33, 74);
            this.gameChoiceRadioButton1.Name = "gameChoiceRadioButton1";
            this.gameChoiceRadioButton1.Size = new System.Drawing.Size(92, 21);
            this.gameChoiceRadioButton1.TabIndex = 0;
            this.gameChoiceRadioButton1.TabStop = true;
            this.gameChoiceRadioButton1.Text = "Choice 1";
            this.gameChoiceRadioButton1.UseVisualStyleBackColor = true;
            // 
            // gameChoiceRadioButton2
            // 
            this.gameChoiceRadioButton2.AutoSize = true;
            this.gameChoiceRadioButton2.Location = new System.Drawing.Point(33, 101);
            this.gameChoiceRadioButton2.Name = "gameChoiceRadioButton2";
            this.gameChoiceRadioButton2.Size = new System.Drawing.Size(92, 21);
            this.gameChoiceRadioButton2.TabIndex = 1;
            this.gameChoiceRadioButton2.Text = "Choice 2";
            this.gameChoiceRadioButton2.UseVisualStyleBackColor = true;
            // 
            // gameChoiceRadioButton4
            // 
            this.gameChoiceRadioButton4.AutoSize = true;
            this.gameChoiceRadioButton4.Location = new System.Drawing.Point(33, 155);
            this.gameChoiceRadioButton4.Name = "gameChoiceRadioButton4";
            this.gameChoiceRadioButton4.Size = new System.Drawing.Size(92, 21);
            this.gameChoiceRadioButton4.TabIndex = 3;
            this.gameChoiceRadioButton4.Text = "Choice 4";
            this.gameChoiceRadioButton4.UseVisualStyleBackColor = true;
            // 
            // gameChoiceRadioButton3
            // 
            this.gameChoiceRadioButton3.AutoSize = true;
            this.gameChoiceRadioButton3.Location = new System.Drawing.Point(33, 128);
            this.gameChoiceRadioButton3.Name = "gameChoiceRadioButton3";
            this.gameChoiceRadioButton3.Size = new System.Drawing.Size(92, 21);
            this.gameChoiceRadioButton3.TabIndex = 2;
            this.gameChoiceRadioButton3.Text = "Choice 3";
            this.gameChoiceRadioButton3.UseVisualStyleBackColor = true;
            // 
            // triviaGameStatusStrip
            // 
            this.triviaGameStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.triviaGameStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triviaGameStatusStripLabel});
            this.triviaGameStatusStrip.Location = new System.Drawing.Point(0, 328);
            this.triviaGameStatusStrip.Name = "triviaGameStatusStrip";
            this.triviaGameStatusStrip.Size = new System.Drawing.Size(582, 25);
            this.triviaGameStatusStrip.TabIndex = 1;
            // 
            // triviaGameStatusStripLabel
            // 
            this.triviaGameStatusStripLabel.Name = "triviaGameStatusStripLabel";
            this.triviaGameStatusStripLabel.Size = new System.Drawing.Size(95, 20);
            this.triviaGameStatusStripLabel.Text = "Question #/3";
            // 
            // TriviaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.triviaGameStatusStrip);
            this.Controls.Add(this.gameGroupBox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriviaGame";
            this.Text = "TriviaGame";
            this.Load += new System.EventHandler(this.TriviaGame_Load);
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.userFeedbackPanel.ResumeLayout(false);
            this.userFeedbackPanel.PerformLayout();
            this.triviaGameStatusStrip.ResumeLayout(false);
            this.triviaGameStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.RadioButton gameChoiceRadioButton4;
        private System.Windows.Forms.RadioButton gameChoiceRadioButton3;
        private System.Windows.Forms.RadioButton gameChoiceRadioButton2;
        private System.Windows.Forms.RadioButton gameChoiceRadioButton1;
        private System.Windows.Forms.Label gameQuestionLabel;
        private System.Windows.Forms.Label gameFeedbackLabel;
        private System.Windows.Forms.Button gameSubmitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.StatusStrip triviaGameStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel triviaGameStatusStripLabel;
        private System.Windows.Forms.Panel userFeedbackPanel;
        private System.Windows.Forms.Button continueButton;
    }
}