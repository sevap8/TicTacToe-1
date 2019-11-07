using System;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game();
            IPlayer player1 = new Player();
            IPlayer player2 = new Player();
            IPlayFields playFields = new PlayFields();

            ImitationGame imitationGame = new ImitationGame(game, player1, player2, playFields);
            imitationGame.Run();
        }
    }
}
