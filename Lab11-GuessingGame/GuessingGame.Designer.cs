namespace Lab11_GuessingGame
{
    partial class GuessingGame
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEnterGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.rTxtOutput = new System.Windows.Forms.RichTextBox();
            this.lblNumOfGuesses = new System.Windows.Forms.Label();
            this.lblNumOfGuessesValue = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.Location = new System.Drawing.Point(32, 38);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(262, 48);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "I have a number between 1 and 1000. Can you guess the number?";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(419, 28);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 41);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEnterGuess
            // 
            this.lblEnterGuess.Location = new System.Drawing.Point(32, 148);
            this.lblEnterGuess.Name = "lblEnterGuess";
            this.lblEnterGuess.Size = new System.Drawing.Size(135, 26);
            this.lblEnterGuess.TabIndex = 3;
            this.lblEnterGuess.Text = "Enter a Guess:";
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(174, 148);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(56, 26);
            this.txtGuess.TabIndex = 4;
            this.txtGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuess_KeyDown);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(256, 148);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(56, 26);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTxtOutput
            // 
            this.rTxtOutput.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtOutput.Location = new System.Drawing.Point(36, 202);
            this.rTxtOutput.Name = "rTxtOutput";
            this.rTxtOutput.ReadOnly = true;
            this.rTxtOutput.Size = new System.Drawing.Size(386, 235);
            this.rTxtOutput.TabIndex = 6;
            this.rTxtOutput.Text = "";
            // 
            // lblNumOfGuesses
            // 
            this.lblNumOfGuesses.Location = new System.Drawing.Point(32, 450);
            this.lblNumOfGuesses.Name = "lblNumOfGuesses";
            this.lblNumOfGuesses.Size = new System.Drawing.Size(165, 23);
            this.lblNumOfGuesses.TabIndex = 7;
            this.lblNumOfGuesses.Text = "Number of Guesses:";
            this.lblNumOfGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOfGuessesValue
            // 
            this.lblNumOfGuessesValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfGuessesValue.Location = new System.Drawing.Point(203, 450);
            this.lblNumOfGuessesValue.Name = "lblNumOfGuessesValue";
            this.lblNumOfGuessesValue.Size = new System.Drawing.Size(54, 23);
            this.lblNumOfGuessesValue.TabIndex = 8;
            this.lblNumOfGuessesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameStatus.Location = new System.Drawing.Point(31, 492);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(573, 33);
            this.lblGameStatus.TabIndex = 9;
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 541);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.lblNumOfGuessesValue);
            this.Controls.Add(this.lblNumOfGuesses);
            this.Controls.Add(this.rTxtOutput);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblEnterGuess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblDirections);
            this.Name = "GuessingGame";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEnterGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.RichTextBox rTxtOutput;
        private System.Windows.Forms.Label lblNumOfGuesses;
        private System.Windows.Forms.Label lblNumOfGuessesValue;
        private System.Windows.Forms.Label lblGameStatus;
    }
}

