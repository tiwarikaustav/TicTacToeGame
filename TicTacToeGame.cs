using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShopOne
{
    class TicTacToeGame
    {
        char [] board = new char[10];
        char playerChoice, compChoice;
        public char[] CreateBoard()
        {
            //creating an empty char array of size 10
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        //The Player Chooses X or O
        public char ChooseXO()
        {
            Console.WriteLine("Enter Your Choice X/O");
            playerChoice = Console.ReadKey().KeyChar;
            if(playerChoice == 'X')
            {
                compChoice = 'O';
            }
            else
            {
                compChoice = 'X';
            }
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
            //check if desired position is empty or not
            if(position>0 && position<10 && board[position] == ' ')
            {
                board[position] = playerChoice;
                CompMakesMove();
            }
            else
            {
                Console.WriteLine("The desired position is not empty!");
            }
        }

        //Comp makes a move
        public void CompMakesMove()
        {
            int count = 0;
            int[] emptyPositions = new int[10];
            int j = 1;
            for (int i=1; i<=9; i++)
            {
                if (board[i]==' ')
                {
                    count++;
                    emptyPositions[j] = i;
                    j++;
                }
                else
                {
                    break;
                }
            }
            Random random = new Random();
            int randNumber = random.Next(1, count + 1);
            board[emptyPositions[randNumber]] = compChoice;
        }
    }
}
