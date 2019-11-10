using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public enum PlayerStatus { winner = 'W', loser = 'L', draw = 'D' }

        /// <summary>
        /// Method allows the player to make a move.
        /// </summary>
        /// <param name="playerMove"></param>
        /// <param name="gameState"></param>
        /// <param name="player"></param>
        public void MakeMove(int playerMove, IGameState gameState)
        {
            gameState.PlayingFieldsArray[playerMove] = Id;
        }
    }
}
