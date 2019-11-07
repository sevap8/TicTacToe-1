using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_1.Interfaces
{
    public interface IGame
    {
        int Id { get; set; }
        Player Player1 { get; set; }
        Player Player2 { get; set; }
        DateTime Started { get; set; }
        DateTime Finish { get; set; }
    }
}
