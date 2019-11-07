using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1.Interfaces
{
    public interface IPlayFields
    {
        int[] PlayingFieldsArray { get; set; }
        string GameStatus { get; set; } 
        bool CheckingAvailableMoves(int[] checkedArray);
        bool CheckWin(int[] winningArrayCheck);
    }
}
