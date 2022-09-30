using System;

namespace connect4
{

    class Program
    {


        public string Recursion(TreeNode<Board> Root)
        {
            for (int i = 0; i < 7; i++)
            {

                if (Root.Data.board[5, i] == 0)
                {
                    Board board2 = new Board();
                    TreeNode<Board> node = new TreeNode<Board>();
                    node.Data = board2.play(i, board2);
                    node.Parent = tree.Root;
                    tree.Root.Children.Add(node);
                }
            }

        }


        static void Main(string[] args)
        {
            Tree<Board> tree = new Tree<Board>();
            tree.Root = new TreeNode<Board>();
            tree.Root.Children = new List<TreeNode<Board>>();

            tree.Root.Data = new Board();
            tree.Root.WinState = "Not Finished";

            for (int i = 0; i < 7; i++)
            {

                if (tree.Root.Data.board[5, i] == 0)
                {
                    Board board2 = new Board();
                    TreeNode<Board> node = new TreeNode<Board>();
                    node.Data = board2.play(i, board2);
                    node.Parent = tree.Root;
                    tree.Root.Children.Add(node);
                }
            }


            tree.Root.Data.boardToString();

            for (int i = 0; i < 7; i++)
            {
                tree.Root.Children[i].Data.boardToString();
            }
                /*for (int i = 0; i < 7; i++)
                {

                    if (tree.Root.Data.board[5, i] == 0)
                    {
                       Board board2 = new Board();
                        TreeNode<Board> node = new TreeNode<Board>();
                        node.Data = board2.play(i,board2);
                        node.Parent = tree.Root;
                        tree.Root.Children.Add(node);
                    }
                }

                tree.Root.Data.boardToString();

                foreach (TreeNode<Board> node in tree.Root.Children)
                {
                    node.Data.boardToString();
                }
         */



            }

    }
}