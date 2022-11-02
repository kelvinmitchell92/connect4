using Connect4;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace connect4
{


    class Program
    {

        static void Main(string[] args)
        {
            List<string> results = new List<string>();
            Filewriter filewriter = new Filewriter();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                
                    Tree<Board> tree = new Tree<Board>();
                    tree.Root = new TreeNode<Board>();
                    tree.Root.Children = new List<TreeNode<Board>>();

                    tree.Root.Data = new Board(i, j, 4);

                    tree.Root.Data.boardToString();
                 
                    Recursive recursive = new Recursive();


                     string entry = "Length: "+ tree.Root.Data.Length.ToString() + "Height: " +tree.Root.Data.Height.ToString() + "\n Could Win:" + recursive.Recursion(tree.Root);
                    results.Add(entry);
                }
            }
            string[] result = results.ToArray();

            Filewriter.Write(result, "connect4normal-smallboards.txt");



            /*Board board = new Board(4,4,3);
           
            board.play(2, board);
            board.play(3, board);
            board.play(2, board);
            board.play(1, board);
            board.play(3, board);
            board.play(0, board);
            board.play(0, board);
            board.play(1, board);
            board.play(0, board);





            board.boardToString();
            */

        }

        }
    }
