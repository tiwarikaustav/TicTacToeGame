﻿using System;

namespace WorkShopOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            char[] ticTacToeBoard = ticTacToeGame.CreateBoard();
            char playerChoice = ticTacToeGame.ChooseXO();
            ticTacToeGame.ShowBoard();
            if (ticTacToeGame.TossWhoBegins() == 0) 
            {
                ticTacToeGame.PlayerMakesMove();
            }
            else
            {
                ticTacToeGame.CompMakesMove();
            }
        }

    }
}

