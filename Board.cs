namespace Mission4;

public class Board
{
    public static void PrintBoard(char[] board)
    {
        Console.WriteLine("| " + board[0] + " | " + board[1] + " | " + board[2] + " |");
        Console.WriteLine("|-----------|");
        Console.WriteLine("| " + board[3] + " | " + board[4] + " | " + board[5] + " |");
        Console.WriteLine("|-----------|");
        Console.WriteLine("| " + board[6] + " | " + board[7] + " | " + board[8] + " |");
    }

    public static (bool, char) CheckWinner(char[] board)
    {
        bool winner = false;
        char currentPlayer = ' ';
        
        // Check each row for a winner, top to bottom
        if ((board[0] == board[1] && board[0] == board[2] && board[1] == board[2]) & board[0] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[0].ToString());
        }
        else if ((board[3] == board[4] && board[3] == board[5] && board[4] == board[5]) & board[3] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[3].ToString());
        }
        else if ((board[6] == board[7] && board[6] == board[8] && board[7] == board[8]) & board[6] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[6].ToString());
        }
        
        // Check each column for a winner, left to right
        if ((board[0] == board[3] && board[0] == board[6] && board[3] == board[6]) & board[0] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[0].ToString());
        }
        else if ((board[1] == board[4] && board[1] == board[7] && board[4] == board[7]) & board[1] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[1].ToString());
        }
        else if ((board[2] == board[5] && board[2] == board[8] && board[5] == board[8]) & board[2] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[2].ToString());
        }
        
        // Check each diagonal for a winner, top left to bottom right and top right to bottom left
        if ((board[0] == board[4] && board[0] == board[8] && board[4] == board[8]) & board[0] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[0].ToString());
        }
        else if ((board[2] == board[4] && board[2] == board[6] && board[4] == board[6]) & board[2] != '*')
        {
            winner = true;
            currentPlayer = char.Parse(board[2].ToString());
        }

        return (winner, currentPlayer);
    }
}

