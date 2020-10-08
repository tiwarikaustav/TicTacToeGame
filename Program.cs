using System;

namespace WorkShopOne
{
    class Program
    {
        char playerChoice, compChoice;
        static void Main(string[] args)
        {
            char[] ticTacToeBoard = CreateBoard();
            char playerChoice = ChooseXO();
            if (playerChoice == 'O')
            {
                compChoice = 'X';
            }
            else
            {
                compChoice = 'O';
            }
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

        public static char ChooseXO()
        {
            char playerChoice, compChoice;
            playerChoice = Console.ReadKey().KeyChar;
            return playerChoice;
        }

    }
}
