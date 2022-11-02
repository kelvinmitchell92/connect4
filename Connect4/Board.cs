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
                for (int j = 0; j < this.Length; j++)
                {
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


        void checkWin(string game)
        {
            if (game == "normal")
            {
                for (int j = 0; j < this.Length; j++)
                {

                    for (int i = this.Height - 1; i > -1; i--)
                    {
                        if (board[i, j] > 0)
                        {

                            if (j < this.Length - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {

                                    if (board[i, j] != board[i, j + k])
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

                            if (j > this.WinLength - 2)
                            {
                                bool check = true;
                                for (int k = this.WinLength - 1; k > -1; k--)
                                {

                                    if (board[i, j] != board[i, j - k])
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

                            if (i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {

                                    if (board[i, j] != board[i + k, j])
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

                            if (i > this.WinLength - 1)
                            {
                                bool check = true;
                                for (int k = this.WinLength - 1; k > -1; k--)
                                {

                                    if (board[i, j] != board[i - k, j])
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
                            if (j < this.Length - this.WinLength + 1 && i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {


                                    if (board[i, j] != board[i + k, j + k])
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

                            if (j > this.WinLength - 2 && i > this.WinLength - 2)
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

                            if (j > this.WinLength - 2 && i < this.Height - this.WinLength + 1)
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

                            if (j < this.Length - this.WinLength + 1 && i > this.WinLength - 1)
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

            }
            if (game == "snake")
            {
                for (int j = 0; j < this.Length; j++)
                {

                    for (int i = this.Height - 1; i > -1; i--)
                    {
                        if (board[i, j] > 0)
                        {

                            if (j < this.Length)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;
                                        if (i == 0)
                                        {
                                            if (board[i, j] != board[this.Height - 1, l])
                                            {
                                                check = false;
                                            }

                                        }
                                        else
                                        {
                                            if (board[i, j] != board[i - 1, l])
                                            {
                                                check = false;
                                            }
                                        }

                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {

                                    if (board[i, j] != board[i + k, j])
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

                            if (i > this.WinLength - 1)
                            {
                                bool check = true;
                                for (int k = this.WinLength - 1; k > -1; k--)
                                {

                                    if (board[i, j] != board[i - k, j])
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


            }

            if (game == "cylinder")
            {
                for (int j = 0; j < this.Length; j++)
                {

                    for (int i = this.Height - 1; i > -1; i--)
                    {
                        if (board[i, j] > 0)
                        {

                            if (j < this.Length)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;
                                        while(l >= this.length)
                                        {
                                            l=l-this.Length;
                                        }
                                        if (board[i, j] != board[i, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {

                                    if (board[i, j] != board[i + k, j])
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

                            if (i > this.WinLength - 1)
                            {
                                bool check = true;
                                for (int k = this.WinLength - 1; k > -1; k--)
                                {

                                    if (board[i, j] != board[i - k, j])
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
                            if (j < this.Length && i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;

                                        if (board[i, j] != board[i + k, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i + k, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (j > -1 && i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j - k < 0)
                                    {
                                        int l = j - k + this.Length;

                                        if (board[i, j] != board[i, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j - k >= 0)
                                    {
                                        if (board[i, j] != board[i + k, j - k])
                                        {
                                            check = false;
                                        }
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

                            if (j < this.Length && i > this.WinLength - 2)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;
                                        while (l >= this.length)
                                        {
                                            l = l - this.Length;
                                        }
                                        if (board[i, j] != board[i - k, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i - k, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (j > -1 && i > this.WinLength - 2)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j - k < 0)
                                    {
                                        int l = j - k + this.Length;
                                        while (l < 0 )
                                        {
                                            l = l + this.Length;
                                        }
                                        int m = i - k;
                                        while (m < 0)
                                        {
                                            m = m+this.Length;
                                        }

                                        if (board[i, j] != board[m, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j - k >= 0)
                                    {
                                        if (board[i, j] != board[i - k, j - k])
                                        {
                                            check = false;
                                        }
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

            }

            if (game == "warped")
            {
                for (int j = 0; j < this.Length; j++)
                {

                    for (int i = this.Height - 1; i > -1; i--)
                    {
                        if (board[i, j] > 0)
                        {

                            if (j < this.Length)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;

                                        while(l >= this.Length){

                                            l = l - this.Length;

                                        }

                                        int t = this.Height - 1 - i;

                                        if (board[i, j] != board[t, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {

                                    if (board[i, j] != board[i + k, j])
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

                            if (i > this.WinLength - 1)
                            {
                                bool check = true;
                                for (int k = this.WinLength - 1; k > -1; k--)
                                {

                                    if (board[i, j] != board[i - k, j])
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
                            if (j < this.Length && i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;
                                        while (l >= this.length)
                                        {
                                            l = l - this.Length;
                                        }

                                        int t = this.Height - 1 - i;

                                        if (board[i, j] != board[t, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i + k, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (j > -1 && i < this.Height - this.WinLength + 1)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j - k < 0)
                                    {
                                        int l = j - k + this.Length;
                                        while (l < 0)
                                        {
                                            l = l + this.Length;
                                        }
                                        int t = this.Height - 1 - i;

                                        if (board[i, j] != board[t, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j - k >= 0)
                                    {
                                        if (board[i, j] != board[i + k, j - k])
                                        {
                                            check = false;
                                        }
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

                            if (j < this.Length && i > this.WinLength - 2)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j + k >= this.Length)
                                    {
                                        int l = j + k - this.Length;
                                        while (l >= this.length)
                                        {
                                            l = l - this.Length;
                                        }
                                        int t = this.Height - 1 - i;

                                        if (board[i, j] != board[t, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j + k < this.Length)
                                    {
                                        if (board[i, j] != board[i - k, j + k])
                                        {
                                            check = false;
                                        }
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



                            if (j > -1 && i > this.WinLength - 2)
                            {
                                bool check = true;
                                for (int k = 0; k < this.WinLength; k++)
                                {
                                    if (j - k < 0)
                                    {
                                        int l = j - k + this.Length;
                                        while (l < 0)
                                        {
                                            l = l + this.Length;
                                        }
                                        int t = this.Height - 1 - i;

                                        if (board[i, j] != board[t, l])
                                        {
                                            check = false;
                                        }


                                    }
                                    if (j - k >= 0)
                                    {
                                        if (board[i, j] != board[i - k, j - k])
                                        {
                                            check = false;
                                        }
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

            }

            if (count == this.length * this.height && winner == "Not Finished")
            {
                winner = "Draw";
            }
        }








        public Board play(int k, Board board, string game)
        {
            checkWin(game);

            if (board.Winner == "Not Finished")
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
                    for (int i = this.Height - 1; i > -1; i--)
                    {
                        if (board.board[i, k] == 0)
                        {

                            if (count % 2 == 0)
                            {
                                board.board[i, k] = 1;
                                count++;
                                board.checkWin(game);
                                return board;
                            }
                            else
                            {
                                board.board[i, k] = 2;
                                count++;
                                board.checkWin(game);
                                return board;
                            }
                        }
                    }

                }

            }
            return board;
        }

        public Board play(int k, Board board)
        {
            return play(k, board, "normal");
        }
    }
}

