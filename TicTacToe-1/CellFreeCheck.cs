using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1
{
    public class CellFreeCheck
    {
        public bool CheckCell(int cellPlayer, int[] arrayOfCells)
        {
            if (arrayOfCells[cellPlayer] == 0)
            {
                return true;
            }

            return false;
        }
    }
}
