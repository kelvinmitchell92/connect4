using System;

namespace connect4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Board board1 = new Board();
            board1.boardToString();
            board1.play(1);
            board1.play(0);
            board1.play(3);
            board1.play(2);
            board1.play(5);
            board1.play(4);
            board1.play(0);
            board1.play(6);
            board1.build();
            board1.boardToString();

        }

    }
}