using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class ImitationGame
    {
        private readonly IGame game;
        private readonly IPlayer player1;
        private readonly IPlayer player2;
        private readonly IPlayFields playFields;
        public ImitationGame(
            IGame game,
            IPlayer player1,
            IPlayer player2,
            IPlayFields playFields)
        {
            this.game = game;
            this.player1 = player1;
            this.player2 = player2;
            this.playFields = playFields;
        }
        public void Run()
        {
            player1.MakeAMove(6, playFields, player1);
            player2.MakeAMove(3, playFields, player2);

            foreach (var item in playFields.PlayingFieldsArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
