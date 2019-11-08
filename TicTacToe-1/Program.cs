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
            IPlayFields playFields = new PlayFields() { PlayingFieldsArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8 }};

            ImitationGame imitationGame = new ImitationGame(game, player1, player2, playFields);
            imitationGame.Run();
        }
    }
}
