namespace TicTacToe_1.Interfaces
{
    public interface IPlayer
    {
        int Id { get; set; }
        string PlayerStatus { get; set; } //victory or defeat
        void MakeMove(int playerMove, IGameState gameState);
    }
}
