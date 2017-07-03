using System;
using System.Collections.Generic;
using System.Text;

namespace NivsTestGames
{
    public enum eRPS
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3,
        New
    }

    public enum eResultType
    {
        Win,
        Loss,
        Draw,
        New
    }

    public class RockPaperScissors
    {
        private int m_NumberOfPlayersWins;

        public int NumberOfPlayersWins
        {
            get { return m_NumberOfPlayersWins; }
            set { m_NumberOfPlayersWins = value; }
        }

        private int m_NumberOfPlayerLosses;

        public int NumberOfPlayerLosses
        {
            get { return m_NumberOfPlayerLosses; }
            set { m_NumberOfPlayerLosses = value; }
        }

        private int m_NumberOfDraws;

        public int NumberOfDraws
        {
            get { return m_NumberOfDraws; }
            set { m_NumberOfDraws = value; }
        }

        public RockPaperScissors()
        {
            NumberOfDraws = 0;
            NumberOfPlayerLosses = 0;
            NumberOfPlayersWins = 0;
            m_LastGameResult = eResultType.New;
            m_PlayerChoice = eRPS.New;
        }

        private eResultType m_LastGameResult;

        public eResultType LastGameResult
        {
            get { return m_LastGameResult; }
        }

        private eRPS m_PlayerChoice;

        public eRPS PlayerChoice
        {
            get
            {
                return m_PlayerChoice;
            }

            set
            {
                m_PlayerChoice = value;
            }

        }

        public void setPlayerChoice(eRPS i_PlayerChoice)
        {
            m_PlayerChoice = i_PlayerChoice;
        }

        public void Play()
        {
            eResultType matchResult;

            if (PlayerChoice == eRPS.New)
            {
                matchResult = eResultType.New;
            }
            else
            {
                eRPS computerChoice = generateComputerChoice();
                matchResult = calculateResult(PlayerChoice, computerChoice);

                switch (matchResult)
                {
                    case eResultType.Win:
                        {
                            m_LastGameResult = eResultType.Win;
                            NumberOfPlayersWins++;
                            break;
                        }

                    case eResultType.Loss:
                        {
                            m_LastGameResult = eResultType.Loss;
                            NumberOfPlayerLosses++;
                            break;
                        }
                    case eResultType.Draw:
                        {
                            m_LastGameResult = eResultType.Draw;
                            NumberOfDraws++;
                            break;
                        }

                }
            }

        }

        private eResultType calculateResult(eRPS i_PlayerChoice, eRPS i_ComputerChoice)
        {
            eResultType result = eResultType.New;

            switch (i_PlayerChoice)
            {
                case eRPS.Rock:
                    {
                        switch (i_ComputerChoice)
                        {
                            case eRPS.Rock:
                                {
                                    result = eResultType.Draw;
                                    break;
                                }
                            case eRPS.Paper:
                                {
                                    result = eResultType.Loss;
                                    break;
                                }
                            case eRPS.Scissors:
                                {
                                    result = eResultType.Win;
                                    break;
                                }
                        }
                        break;
                    }
                case eRPS.Paper:
                    {
                        switch (i_ComputerChoice)
                        {
                            case eRPS.Rock:
                                {
                                    result = eResultType.Win;
                                    break;
                                }
                            case eRPS.Paper:
                                {
                                    result = eResultType.Draw;
                                    break;
                                }
                            case eRPS.Scissors:
                                {
                                    result = eResultType.Loss;
                                    break;
                                }
                        }
                        break;
                    }
                case eRPS.Scissors:
                    {
                        switch (i_ComputerChoice)
                        {
                            case eRPS.Rock:
                                {
                                    result = eResultType.Loss;
                                    break;
                                }
                            case eRPS.Paper:
                                {
                                    result = eResultType.Win;
                                    break;
                                }
                            case eRPS.Scissors:
                                {
                                    result = eResultType.Draw;
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    break;
            }

            return result;
        }

        private eRPS generateComputerChoice()
        {
            return (eRPS)(new Random().Next(1, 4));
        }

        public int TotalNumberOfGames()
        {
            return NumberOfDraws + NumberOfPlayerLosses + NumberOfPlayersWins;
        }

        public static RockPaperScissors ResetGame()
        {
            return new RockPaperScissors();
        }
    }
}
