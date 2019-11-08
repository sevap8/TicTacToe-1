using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1.Interfaces
{
    public interface IPlayer
    {
        int Id { get; set; }
        string PlayerStatus { get; set; } //victory or defeat
        void MakeMove(int playerMove, IGameState playFields, IPlayer player);
    }
}
