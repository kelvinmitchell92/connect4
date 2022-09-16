using System;

namespace connect4
{

	public class Board
	{
		public int[,] board = new int[6,7];

		public Board()
		{

			for(int i = 0; i < 6; i++)
            {
				for(int j = 0; j < 7; j++)
                {
					board[i,j] = 0;
                }
            }

		}

		public void boardToString(Board board)
        {
			for (int i = 0; i < 6; i++)
			{

				Console.WriteLine(board.board[i, 0] + " " + board.board[i, 1] + " " + board.board[i, 2] + " " + board.board[i, 3] + " " + board.board[i, 4] + " " + board.board[i, 5] + " " + board.board[i, 6]);
				
			}

		}
	}
}
