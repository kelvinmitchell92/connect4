using System;

namespace connect4
{

  

    public class Board
    {
        public int[,] board;
        int count = 0;
        int height;
        int length;
        int winLength;
        string winner = "Not Finished";
        public string Winner //property
        {
            get { return winner; }
            set { this.winner = value; }
        }
        public int Length //property
        {
            get { return length; }
            set { this.length = value; }
        }
        public int WinLength //property
        {
            get { return winLength; }
            set { this.winLength = value; }
        }
        public int Height //property
        {
            get { return height; }
            set { this.height = value; }
        }
        public int Count //property
        {
            get { return count; }
            set { this.count = value; }
        }
        public Board()
        {
            board = new int[6, 7];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = 0;
                }
            }

        }

        public Board(int length, int height, int winLength)
        {
            this.Height = height;
            this.Length = length;
            this.winLength = winLength; 

            board = new int[height, length];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    board[i, j] = 0;
                }
            }

        }

        public void boardToString()
        {
            for (int i = 0; i < this.Height; i++)
            {                      
                for (int j = 0; j < this.Length;j++) {
                    if (j == this.Length - 1)
                    {
                        Console.Write(board[i, j] + "\n");
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");
                    }
                }
            }

            Console.WriteLine("Winner : " + winner);

        }


        void checkWin()
        {
           
            for (int j = 0; j < this.Length; j++)
            {

                for (int i = this.Height-1; i > -1; i--)
                {
                    if (board[i, j] > 0)
                    {
                        
                        if (j < this.Length-this.WinLength)
                        {
                            bool check = true;
                            for (int k = 0; k < this.WinLength; k++) {
                            
                                if (board[i,j] != board[i, j+k])
                                {
                                    check = false;
                                }
                            
                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
                        }

                        if (j > this.WinLength-2)
                        {
                            bool check = true;
                            for (int k = this.WinLength-1; k >-1; k--)
                            {

                                if (board[i, j] != board[i, j-k])
                                {
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
                            
                        }

                        if (i < this.Height-this.WinLength)
                        {
                            bool check = true;
                            for (int k = 0; k < this.WinLength; k++)
                            {

                                if (board[i, j] != board[i+k, j])
                                {
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
                           
                        }

                        if (i > this.WinLength-1)
                        {
                            bool check = true;
                            for (int k = this.WinLength-1; k > -1; k--)
                            {

                                if (board[i, j] != board[i-k, j])
                                {
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
             
                        }
                        if (j < this.Length - this.WinLength && i<this.Height - this.WinLength)
                        {
                            bool check = true;
                            for (int k = 0; k < this.WinLength; k++)
                            {
                          

                                    if (board[i, j] != board[i+k, j+k])
                                    {
                                        check = false;
                                    }
                                
                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
           
                        }

                        if (j > this.WinLength-2 && i>this.WinLength-2)
                        {
                            bool check = true;
                            for (int k = 0; k < this.WinLength; k++)
                            {


                                if (board[i, j] != board[i - k, j - k])
                                {
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
                        
                        }

                        if (j>this.WinLength-2 && i < this.height-this.WinLength)
                        {
                            bool check = true;
                            for (int k = 0; k < this.WinLength; k++)
                            {


                                if (board[i, j] != board[i + k, j - k])
                                {
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
                        }

                        if (j<this.Height-this.WinLength && i > this.WinLength-1)
                        {
                            bool check = true;
                            for (int k = 0; k < this.WinLength; k++)
                            {


                                if (board[i, j] != board[i - k, j + k])
                                {
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winner = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winner = "Black";
                                }

                            }
                        }

                    }

                }
            }
            if(count == this.length*this.height && winner=="Not Finished")
            {
                winner = "Draw";
            }
        }

        public void build()
        {

          

            for (int j = 0; j < 7; j++)
            {
                if (board[0, j] == 0)
                {


                    for (int i = 5; i > -1; i--)
                    {

                        if (board[i, j] == 0)
                        {

                            if (count % 2 == 0)
                            {
                                board[i, j] = 1;
                                count++;
                                checkWin();

                            }
                            else
                            {
                                board[i, j] = 2;
                                count++;
                                checkWin();
                            }

                        }
                        if(winner!="Not Finished")
                        {
                            return;
                        }

                    }
                }
            } 
            
        
        }

        public Board play(int k,Board board)
        {
            checkWin();
            
            if (winner == "Not Finished")
            {
                if (k < 0 || k > this.Length)
                {
                    Console.WriteLine("Not a Valid Column Please select column 0-6");
                    return board;
                }
                if (board.board[0, k] != 0)
                {
                    Console.WriteLine("This Column is full");
                    return board;
                }
                else
                {
                    for (int i = this.Height-1; i > -1; i--)
                    {
                        if (board.board[i, k] == 0)
                        {

                            if (count % 2 == 0)
                            {
                                board.board[i, k] = 1;
                                count++;
                                board.checkWin();
                                return board;
                            }
                            else
                            {
                                board.board[i, k] = 2;
                                count++;
                                board.checkWin();
                                return board;
                            }
                        }
                    }

                }

            }
            return board;
        }
    }
}

