using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NivsTestGames
{
    public partial class RPSForm : Form
    {
        RockPaperScissors m_game = new RockPaperScissors();

        public RPSForm()
        {
            InitializeComponent();
        }

        private void pictureRock_Click(object sender, EventArgs e)
        {
            resetPictureBorders();
            pictureRock.BorderStyle = BorderStyle.Fixed3D;
            m_game.PlayerChoice = eRPS.Rock;

        }



        private void picturePaper_Click(object sender, EventArgs e)
        {
            resetPictureBorders();
            picturePaper.BorderStyle = BorderStyle.Fixed3D;
            m_game.PlayerChoice = eRPS.Paper;
        }

        private void pictureScissors_Click(object sender, EventArgs e)
        {
            resetPictureBorders();
            pictureScissors.BorderStyle = BorderStyle.Fixed3D;
            m_game.PlayerChoice = eRPS.Scissors;
        }

        private void resetPictureBorders()
        {
            pictureRock.BorderStyle = BorderStyle.None;
            pictureScissors.BorderStyle = BorderStyle.None;
            picturePaper.BorderStyle = BorderStyle.None;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            m_game.Play();

            switch (m_game.LastGameResult)
            {
                case eResultType.Win:
                    labelResult.Text = "YOU WON!";
                    labelNumOfWins.Text = m_game.NumberOfPlayersWins.ToString();
                    break;
                case eResultType.Loss:
                    labelResult.Text = "You Lost :(";
                    labelNumOfLosses.Text = m_game.NumberOfPlayerLosses.ToString();
                    break;
                case eResultType.Draw:
                    labelResult.Text = "It's a Draw!";
                    labelNumOfDraws.Text = m_game.NumberOfDraws.ToString();
                    break;
                case eResultType.New:
                    labelResult.Text = "NA";
                    break;
                default:
                    break;
            }
            labelTotalNumberOfGames.Text = m_game.TotalNumberOfGames().ToString();
        }

        private void RPSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            m_game = RockPaperScissors.ResetGame();
            resetPictureBorders();
            resetlabels();
        }

        private void resetlabels()
        {
            labelNumOfDraws.Text = "0";
            labelNumOfLosses.Text = "0";
            labelNumOfWins.Text = "0";
            labelResult.Text = "NA";
            labelTotalNumberOfGames.Text = m_game.TotalNumberOfGames().ToString();
        }
    }

}
