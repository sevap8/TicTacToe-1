using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class GameState : IGameState
    {
        public int[] PlayingFieldsArray { get; set; }
        public string[] PlayingFieldsArrayTransformed { get; set; }

        /// <summary>
        /// Change string to enam.
        /// </summary>
        public string GameStatus { get; set; }

        /// <summary>
        /// Checks if it is possible to make another move.
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
        /// It needs to be converted to a more compact, now this is a quick solution.
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

        /// <summary>
        /// This method draws the game field.
        /// </summary>
        /// <param name="outputWriter"></param>
        public void DrawField(IOutputWriter outputWriter)
        { 
            outputWriter.ChangeСolorYellow();
            outputWriter.Write(" -------------");
            outputWriter.Write(string.Format(" | {0} | {1} | {2} |", PlayingFieldsArrayTransformed[0], PlayingFieldsArrayTransformed[1], PlayingFieldsArrayTransformed[2]));
            outputWriter.Write(" ----+---+----");
            outputWriter.Write(string.Format(" | {0} | {1} | {2} |", PlayingFieldsArrayTransformed[3], PlayingFieldsArrayTransformed[4], PlayingFieldsArrayTransformed[5]));
            outputWriter.Write(" ----+---+----");
            outputWriter.Write(string.Format(" | {0} | {1} | {2} |", PlayingFieldsArrayTransformed[6], PlayingFieldsArrayTransformed[7], PlayingFieldsArrayTransformed[8]));
            outputWriter.Write(" -------------");
            outputWriter.ChangeСolorWhite();
        }

        public void FieldArrayTransformed()
        {
            for (int i = 0; i < PlayingFieldsArray.Length; i++)
            {
                if (PlayingFieldsArray[i] == 0)
                {
                    PlayingFieldsArrayTransformed[i] = " ";
                }
                if (PlayingFieldsArray[i] == 1)
                {
                    PlayingFieldsArrayTransformed[i] = "X";
                }
                if (PlayingFieldsArray[i] == 2)
                {
                    PlayingFieldsArrayTransformed[i] = "O";
                }
            }
        }
    }
}
