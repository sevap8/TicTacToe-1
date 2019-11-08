using System;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class ImitationGame
    {
        private readonly IGame game;
        private readonly IPlayer player1;
        private readonly IPlayer player2;
        private readonly IGameState gameState;
        public ImitationGame(
            IGame game,
            IPlayer player1,
            IPlayer player2,
            IGameState gameState)
        {
            this.game = game;
            this.player1 = player1;
            this.player2 = player2;
            this.gameState = gameState;
        }

        /// <summary>
        /// The method of starting the game where the action will take place
        /// </summary>
        public void Run()
        {
            Console.WriteLine("I am working!");
        }
    }
}
