using System;

namespace WorkShopOne
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ticTacToeBoard = CreateBoard();
        }

        //creating an empty array
        public static char[] CreateBoard()
        {
            //creating an empty char array of size 10
            char[] board = new char[10];
            for(int i=0; i <= board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

    }
}
