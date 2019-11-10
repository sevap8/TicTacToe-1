namespace TicTacToe_1.Interfaces
{
    public interface IGameState
    {
        int[] PlayingFieldsArray { get; set; }
        string[] PlayingFieldsArrayTransformed { get; set; }
        string GameStatus { get; set; }
        bool CheckAvailableMoves();
        bool CheckWin();
        void DrawField(IOutputWriter outputWriter);
        void FieldArrayTransformed();
    }
}
