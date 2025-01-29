﻿/*
• Welcome the user to the game
• Create a game board array to store the players’ choices
• Ask each player in turn for their choice and update the game board array
• Print the board by calling the method in the supporting class
• Check for a winner by calling the method in the supporting class, and notify the players
when a win has occurred and which player won the game
*/

/*
 * Array of arrays (3x3)
 * Asterisks until Xs and Os
 * 
 */

using Mission4;

Board board = new Board();

Console.WriteLine($"{board.PrintBoard()}");