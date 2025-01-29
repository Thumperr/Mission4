/*
    • Receive the “board” array from the driver class
    • Contain a method that prints the board based on the information passed to it
    • Contain a method that receives the game board array as input and returns if there is a
    winner and who it was
 */

namespace Mission4;

public class Board
{
    public void PrintBoard(Array[] board)
    {
        console.Writeline("| " + board[1] + " | " board[2] " | " board[3] + " |");
        console.Writeline("|---------------|");
        console.Writeline("| " + board[4] + " | " board[5] " | " board[5] + " |");
        console.Writeline("|---------------|");
        console.Writeline("| " + board[7] + " | " board[8] " | " board[9] + " |");
        console.Writeline("|---------------|");
    }
    
    PrintBoard(["x","x","x","x","x","x","x","x","x",]);

    public string CheckWinner(Array[] board)
    {
        string message = "";
        
        

        return message;
    }
}

