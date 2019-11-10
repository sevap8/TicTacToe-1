using TicTacToe_1.Interfaces;
using System;


namespace TicTacToe_1
{
    public class ImitationGame
    {
        private readonly IGame game;
        private readonly IPlayer player1;
        private readonly IPlayer player2;
        private readonly IGameState gameState;
        private readonly IOutputWriter outputWriter;
        private readonly IInputReader inputReader;
        public ImitationGame(
            IGame game,
            IPlayer player1,
            IPlayer player2,
            IGameState gameState,
            IOutputWriter outputWriter,
            IInputReader inputReader)
        {
            this.game = game;
            this.player1 = player1;
            this.player2 = player2;
            this.gameState = gameState;
            this.outputWriter = outputWriter;
            this.inputReader = inputReader;
        }

        /// <summary>
        /// The method of starting the game where the action will take place.
        /// </summary>
        public void Run()
        {
            
            while (true)
            {
                //gameState.FieldArrayTransformed();
                //gameState.DrawField(outputWriter);
                //Console.ReadKey();
                //player1.MakeMove(0, gameState);
                //player1.MakeMove(1, gameState);
                //player1.MakeMove(2, gameState);
                //player1.MakeMove(3, gameState);
                //outputWriter.СlearСonsole();
                //gameState.FieldArrayTransformed();
                //gameState.DrawField(outputWriter);
                //Console.ReadKey();
                //bool a = gameState.CheckWin();
                //Console.WriteLine(a + " ты првда выигнал !!!");
                //Console.ReadKey();
                //outputWriter.СlearСonsole();
                //Console.ReadKey();
            }
        }
    }
}
