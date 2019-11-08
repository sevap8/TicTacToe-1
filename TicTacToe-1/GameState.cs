using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class GameState : IGameState
    {
        public int[] PlayingFieldsArray { get; set; }

        /// <summary>
        /// change string to enam
        /// </summary>
        public string GameStatus { get; set; }

        /// <summary>
        /// checks if it is possible to make another move
        /// </summary>
        /// <returns></returns>
        public bool CheckAvailableMoves()
        {
            for (int i = 0; i < this.PlayingFieldsArray.Length; i++)
            {
                if (this.PlayingFieldsArray[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Does the method check whether the winnings have arrived?
        /// It needs to be converted to a more compact, now this is a quick solution
        /// </summary>
        /// <returns></returns>
        public bool CheckWin()
        {
            // processing possible winnings 'X'

            if (PlayingFieldsArray[0] == 1 && PlayingFieldsArray[1] == 1 && PlayingFieldsArray[2] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[3] == 1 && PlayingFieldsArray[4] == 1 && PlayingFieldsArray[5] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[6] == 1 && PlayingFieldsArray[7] == 1 && PlayingFieldsArray[8] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[0] == 1 && PlayingFieldsArray[3] == 1 && PlayingFieldsArray[6] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[1] == 1 && PlayingFieldsArray[4] == 1 && PlayingFieldsArray[8] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[2] == 1 && PlayingFieldsArray[5] == 1 && PlayingFieldsArray[8] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[0] == 1 && PlayingFieldsArray[4] == 1 && PlayingFieldsArray[8] == 1)
            {
                return true;
            }

            else if (PlayingFieldsArray[2] == 1 && PlayingFieldsArray[4] == 1 && PlayingFieldsArray[6] == 1)
            {
                return true;
            }

            // processing possible winnings 'O'

            if (PlayingFieldsArray[0] == 2 && PlayingFieldsArray[1] == 2 && PlayingFieldsArray[2] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[3] == 2 && PlayingFieldsArray[4] == 2 && PlayingFieldsArray[5] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[6] == 2 && PlayingFieldsArray[7] == 2 && PlayingFieldsArray[8] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[0] == 2 && PlayingFieldsArray[3] == 2 && PlayingFieldsArray[6] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[1] == 2 && PlayingFieldsArray[4] == 2 && PlayingFieldsArray[8] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[2] == 2 && PlayingFieldsArray[5] == 2 && PlayingFieldsArray[8] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[0] == 2 && PlayingFieldsArray[4] == 2 && PlayingFieldsArray[8] == 2)
            {
                return true;
            }

            else if (PlayingFieldsArray[2] == 2 && PlayingFieldsArray[4] == 2 && PlayingFieldsArray[6] == 2)
            {
                return true;
            }

            return false;
        }
    }
}
