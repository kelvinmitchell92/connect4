using System;

namespace connect4
{

    public class Board
    {
        public int[,] board = new int[6, 7];
        int count = 0;
        string winState = "Not Finished";

        public Board()
        {

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = 0;
                }
            }

        }

        public void boardToString()
        {
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine(board[i, 0] + " " + board[i, 1] + " " + board[i, 2] + " " + board[i, 3] + " " + board[i, 4] + " " + board[i, 5] + " " + board[i, 6]);

            }

            Console.WriteLine("Winner : " + winState);

        }


        void checkWin()
        {

            for (int j = 0; j < 7; j++)
            {

                for (int i = 5; i > -1; i--)
                {
                    if (board[i, j] > 0)
                    {
                        if (j < 4)
                        {
                            if (board[i, j] == board[i, j + 1] && board[i, j] == board[i, j + 2] && board[i, j] == board[i, j + 3])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                        if (j > 2)
                        {
                            if (board[i, j] == board[i, j - 1] && board[i, j] == board[i, j - 2] && board[i, j] == board[i, j - 3])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                        if (i < 3)
                        {
                            if (board[i, j] == board[i + 1, j] && board[i, j] == board[i + 2, j] && board[i, j] == board[i + 3, j])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                        if (i > 3)
                        {
                            if (board[i, j] == board[i - 1, j] && board[i, j] == board[i - 2, j] && board[i, j] == board[i - 3, j])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }
                        if (j < 4 && i<3)
                        {
                            if (board[i, j] == board[i+1, j + 1] && board[i, j] == board[i+2, j + 2] && board[i+3, j] == board[i, j + 3])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                        if (j > 2 && i>3)
                        {
                            if (board[i, j] == board[i-1, j - 1] && board[i, j] == board[i-2, j - 2] && board[i, j] == board[i-3, j - 3])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                        if (j>2 && i < 3)
                        {
                            if (board[i, j] == board[i + 1, j-1] && board[i, j] == board[i + 2, j-2] && board[i, j] == board[i + 3, j-3])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                        if (j<4 && i > 3)
                        {
                            if (board[i, j] == board[i - 1, j+1] && board[i, j] == board[i - 2, j+2] && board[i, j] == board[i - 3, j+3])
                            {
                                if (board[i, j] == 1)
                                {
                                    this.winState = "White";
                                }
                                if (board[i, j] == 2)
                                {
                                    this.winState = "Black";
                                }

                            }
                        }

                    }

                }
            }
            if(count ==42 && winState=="Not Finished")
            {
                winState = "Draw";
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
                        if(winState!="Not Finished")
                        {
                            return;
                        }

                    }
                }
            } 
            
        
        }

        public void play(int k)
        {
            checkWin();
            if (winState == "Not Finished")
            {
                if (k < 0 || k > 6)
                {
                    Console.WriteLine("Not a Valid Column Please select column 0-6");
                }
                if (board[0, k] != 0)
                {
                    Console.WriteLine("This Column is full");
                }
                else
                {
                    for (int i = 5; i > -1; i--)
                    {
                        if (board[i, k] == 0)
                        {

                            if (count % 2 == 0)
                            {
                                board[i, k] = 1;
                                count++;
                                return;
                            }
                            else
                            {
                                board[i, k] = 2;
                                count++;
                                return;
                            }
                        }
                    }

                }

            }

        }
    }
}

