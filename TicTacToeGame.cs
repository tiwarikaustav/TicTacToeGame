using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShopOne
{
    class TicTacToeGame
    {
        char [] board = new char[10];
        char playerChoice;
        public char[] CreateBoard()
        {
            //creating an empty char array of size 10
            for (int i = 0; i < 10; i++)
            {
                board[i] = 'd';
            }
            return board;
        }

        //The Player Chooses X or O
        public char ChooseXO()
        {
            Console.WriteLine("Enter Your Choice X/O");
            playerChoice = Console.ReadKey().KeyChar;
            return playerChoice;
        }

        //show the board
        public void ShowBoard()
        {
            Console.WriteLine("\n");
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }

        //Player makes a move
        public void PlayerMakesMove()
        {
            string temp = Console.ReadLine();
            int position = Convert.ToInt32(temp);
            //check is empty
            if(board[position] == ' ')
            {
                board[position] = playerChoice;
            }
            else
            {
                Console.WriteLine("The desired position is not empty!");
            }
        }
    }
}
