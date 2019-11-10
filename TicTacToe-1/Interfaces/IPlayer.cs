namespace TicTacToe_1.Interfaces
{
    public interface IPlayer
    {
        int Id { get; set; }
        enum PlayerStatus { }; //victory or defeat
        void MakeMove(int playerMove, IGameState gameState);
    }
}
