using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1
{
    public class PlayerWinCheck
    {
        public bool CheckWin(int[] winningArrayCheck)
        {
            // processing possible winnings 'X'

            if (winningArrayCheck[0] == 1 && winningArrayCheck[1] == 1 && winningArrayCheck[2] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[3] == 1 && winningArrayCheck[4] == 1 && winningArrayCheck[5] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[6] == 1 && winningArrayCheck[7] == 1 && winningArrayCheck[8] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[0] == 1 && winningArrayCheck[3] == 1 && winningArrayCheck[6] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[1] == 1 && winningArrayCheck[4] == 1 && winningArrayCheck[8] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[2] == 1 && winningArrayCheck[5] == 1 && winningArrayCheck[8] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[0] == 1 && winningArrayCheck[4] == 1 && winningArrayCheck[8] == 1)
            {
                return true;
            }

            else if (winningArrayCheck[2] == 1 && winningArrayCheck[4] == 1 && winningArrayCheck[6] == 1)
            {
                return true;
            }

            // processing possible winnings 'O'

            if (winningArrayCheck[0] == 2 && winningArrayCheck[1] == 2 && winningArrayCheck[2] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[3] == 2 && winningArrayCheck[4] == 2 && winningArrayCheck[5] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[6] == 2 && winningArrayCheck[7] == 2 && winningArrayCheck[8] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[0] == 2 && winningArrayCheck[3] == 2 && winningArrayCheck[6] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[1] == 2 && winningArrayCheck[4] == 2 && winningArrayCheck[8] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[2] == 2 && winningArrayCheck[5] == 2 && winningArrayCheck[8] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[0] == 2 && winningArrayCheck[4] == 2 && winningArrayCheck[8] == 2)
            {
                return true;
            }

            else if (winningArrayCheck[2] == 2 && winningArrayCheck[4] == 2 && winningArrayCheck[6] == 2)
            {
                return true;
            }

            return false;
        }
    }
}
