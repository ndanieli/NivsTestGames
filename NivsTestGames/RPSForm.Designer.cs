using System;

namespace NivsTestGames
{
    partial class RPSForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumOfWins = new System.Windows.Forms.Label();
            this.labelNumOfLosses = new System.Windows.Forms.Label();
            this.labelNumOfDraws = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.lablel7 = new System.Windows.Forms.Label();
            this.labelTotalNumberOfGames = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picturePaper = new System.Windows.Forms.PictureBox();
            this.pictureScissors = new System.Windows.Forms.PictureBox();
            this.pictureRock = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Losses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of Draws";
            // 
            // labelNumOfWins
            // 
            this.labelNumOfWins.AutoSize = true;
            this.labelNumOfWins.Location = new System.Drawing.Point(119, 24);
            this.labelNumOfWins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumOfWins.Name = "labelNumOfWins";
            this.labelNumOfWins.Size = new System.Drawing.Size(13, 13);
            this.labelNumOfWins.TabIndex = 3;
            this.labelNumOfWins.Text = "0";
            // 
            // labelNumOfLosses
            // 
            this.labelNumOfLosses.AutoSize = true;
            this.labelNumOfLosses.Location = new System.Drawing.Point(394, 24);
            this.labelNumOfLosses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumOfLosses.Name = "labelNumOfLosses";
            this.labelNumOfLosses.Size = new System.Drawing.Size(13, 13);
            this.labelNumOfLosses.TabIndex = 4;
            this.labelNumOfLosses.Text = "0";
            // 
            // labelNumOfDraws
            // 
            this.labelNumOfDraws.AutoSize = true;
            this.labelNumOfDraws.Location = new System.Drawing.Point(254, 24);
            this.labelNumOfDraws.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumOfDraws.Name = "labelNumOfDraws";
            this.labelNumOfDraws.Size = new System.Drawing.Size(13, 13);
            this.labelNumOfDraws.TabIndex = 5;
            this.labelNumOfDraws.Text = "0";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(141, 251);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(152, 56);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "PLAY!";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 56);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(232, 318);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(70, 56);
            this.labelResult.TabIndex = 11;
            this.labelResult.Text = "NA";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lablel7
            // 
            this.lablel7.AutoSize = true;
            this.lablel7.Location = new System.Drawing.Point(19, 63);
            this.lablel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lablel7.Name = "lablel7";
            this.lablel7.Size = new System.Drawing.Size(92, 13);
            this.lablel7.TabIndex = 12;
            this.lablel7.Text = "Number of Games";
            // 
            // labelTotalNumberOfGames
            // 
            this.labelTotalNumberOfGames.AutoSize = true;
            this.labelTotalNumberOfGames.Location = new System.Drawing.Point(119, 63);
            this.labelTotalNumberOfGames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalNumberOfGames.Name = "labelTotalNumberOfGames";
            this.labelTotalNumberOfGames.Size = new System.Drawing.Size(13, 13);
            this.labelTotalNumberOfGames.TabIndex = 13;
            this.labelTotalNumberOfGames.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Choose your destiny";
            // 
            // picturePaper
            // 
            this.picturePaper.Image = global::NivsTestGames.Properties.Resources.Paper;
            this.picturePaper.Location = new System.Drawing.Point(191, 142);
            this.picturePaper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturePaper.Name = "picturePaper";
            this.picturePaper.Size = new System.Drawing.Size(100, 100);
            this.picturePaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePaper.TabIndex = 8;
            this.picturePaper.TabStop = false;
            this.picturePaper.Click += new System.EventHandler(this.picturePaper_Click);
            // 
            // pictureScissors
            // 
            this.pictureScissors.Image = global::NivsTestGames.Properties.Resources.Scissors;
            this.pictureScissors.Location = new System.Drawing.Point(320, 142);
            this.pictureScissors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureScissors.Name = "pictureScissors";
            this.pictureScissors.Size = new System.Drawing.Size(100, 100);
            this.pictureScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureScissors.TabIndex = 7;
            this.pictureScissors.TabStop = false;
            this.pictureScissors.Click += new System.EventHandler(this.pictureScissors_Click);
            // 
            // pictureRock
            // 
            this.pictureRock.Image = global::NivsTestGames.Properties.Resources.Rock;
            this.pictureRock.Location = new System.Drawing.Point(63, 142);
            this.pictureRock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureRock.Name = "pictureRock";
            this.pictureRock.Size = new System.Drawing.Size(100, 100);
            this.pictureRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureRock.TabIndex = 6;
            this.pictureRock.TabStop = false;
            this.pictureRock.Click += new System.EventHandler(this.pictureRock_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(9, 342);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(74, 41);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // RPSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 392);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotalNumberOfGames);
            this.Controls.Add(this.lablel7);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.picturePaper);
            this.Controls.Add(this.pictureScissors);
            this.Controls.Add(this.pictureRock);
            this.Controls.Add(this.labelNumOfDraws);
            this.Controls.Add(this.labelNumOfLosses);
            this.Controls.Add(this.labelNumOfWins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPSForm";
            this.Text = "Rock Paper Scissors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RPSForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picturePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumOfWins;
        private System.Windows.Forms.Label labelNumOfLosses;
        private System.Windows.Forms.Label labelNumOfDraws;
        private System.Windows.Forms.PictureBox pictureRock;
        private System.Windows.Forms.PictureBox pictureScissors;
        private System.Windows.Forms.PictureBox picturePaper;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label lablel7;
        private System.Windows.Forms.Label labelTotalNumberOfGames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReset;
    }
}