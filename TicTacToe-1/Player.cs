using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public string PlayerStatus { get; set; } //victory or defeat
        public void MakeAMove(int playerMove, PlayFields playFields, Player player)
        {
            playFields.PlayingFieldsArray[playerMove] = player.Id;
        }
    }
}
