using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_1.Interfaces;

namespace TicTacToe_1.Components
{
    public class OutputWriter : IOutputWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void СlearСonsole()
        {
            Console.Clear();
        } 
        public void ChangeСolorYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void ChangeСolorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
