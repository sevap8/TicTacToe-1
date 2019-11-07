using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1
{
    public class CheckingTheNumberOfPossibleMoves
    {
        public bool MoveabilityCheck(int[] checkedArray)
        {
            for (int i = 0; i < checkedArray.Length; i++)
            {
                if (checkedArray[i] == 0)
                {
                    return true;
                } 
            }
            return false; 
        }
    }
}
