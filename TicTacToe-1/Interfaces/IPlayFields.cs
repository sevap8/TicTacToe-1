using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1.Interfaces
{
    public interface IGameState
    {
        int[] PlayingFieldsArray { get; set; }
        string GameStatus { get; set; } 
        bool CheckAvailableMoves();
        bool CheckWin();
    }
}
