using System;
using System.Globalization;
using System.Xml.Serialization;

namespace connect4
{


    class Program
    {

        static void Main(string[] args)
        {

            /*Tree<Board> tree = new Tree<Board>();
            tree.Root = new TreeNode<Board>();
            tree.Root.Children = new List<TreeNode<Board>>();

            tree.Root.Data = new Board(4,2,3);
  
            tree.Root.Data.boardToString();
            Console.WriteLine("Could Win:" + tree.Root.WinState);
            Recursive recursive = new Recursive();
            

            tree.Root.Data.boardToString();
            Console.WriteLine("Could Win:" + recursive.Recursion(tree.Root));
            */

            Board board = new Board(4,4,3);
           
            board.play(2, board,"snake");
            board.play(3, board,"snake");
            board.play(2, board,"snake");
            board.play(1, board,"snake");
            board.play(3, board,"snake");
            board.play(0, board,"snake");
            board.play(0, board,"snake");
            board.play(1, board, "snake");
            board.play(0, board, "snake");





            board.boardToString();
            

        }

        }
    }
