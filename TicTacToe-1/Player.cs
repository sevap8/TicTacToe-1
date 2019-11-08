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

        /// <summary>
        /// method allows the player to make a move
        /// </summary>
        /// <param name="playerMove"></param>
        /// <param name="playFields"></param>
        /// <param name="player"></param>
        public void MakeMove(int playerMove, IGameState playFields, IPlayer player)
        {
            playFields.PlayingFieldsArray[playerMove] = player.Id;
        }
    }
}
