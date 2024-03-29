﻿using System;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public DateTime Started { get; set; }
        public DateTime Finish { get; set; }       
    }
}
