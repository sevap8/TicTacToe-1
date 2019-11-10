
namespace TicTacToe_1
{
    /// <summary>
    /// 
    /// </summary>
    public class CellFreeCheck
    {
        /// <summary>
        /// This method will do validation of the player’s move on the client side.
        /// </summary>
        /// <param name="cellPlayer"></param>
        /// <param name="arrayOfCells"></param>
        /// <returns></returns>
        public bool CheckCell(int cellPlayer, int[] arrayOfCells)
        {
            if (arrayOfCells[cellPlayer] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
