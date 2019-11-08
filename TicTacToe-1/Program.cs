using System;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game();
            IPlayer player1 = new Player() {Id = 1 };
            IPlayer player2 = new Player() {Id = 2 };
            IGameState gameState = new GameState() { PlayingFieldsArray = new int[]{ 0, 2, 3, 4, 5, 6, 7, 0 }};

            ImitationGame imitationGame = new ImitationGame(game, player1, player2, gameState);
            imitationGame.Run();
        }
    }
}
