using System;

namespace connect4{
	public class Recursive
	{

        public string Recursion(TreeNode<Board> Root)
        {
            for (int i = 0; i < 7; i++)
            {

                if (Root.Data.board[5, i] == 0)
                {
                    Board board2 = new Board();
                    TreeNode<Board> child = new TreeNode<Board>();
                    child.Children = new List<TreeNode<Board>>();
                    child.Data = board2.play(i, board2);
                    child.Parent = Root;
                    Root.Children.Add(child);
                    if (child.Data.Winner == "Black" || child.Data.Winner == "White" || child.Data.Winner == "Draw")
                    {
                        child.WinState = child.Data.Winner;
                    }
                    else
                    {
                        child.WinState = Recursion(child);
                    }

                }
            }
            return Root.WinState = checkingMethod(Root);
        }

        public string checkingMethod(TreeNode<Board> root)
        {
            string value = "";
            foreach (TreeNode<Board> child in root.Children)
            {
                if (root.Data.Count % 2 > 0)
                {
                    value = "White";
                    if (child.WinState == "Black")
                    {
                        return value = "Black";
                    }
                    if (child.WinState == "Draw")
                    {
                        value = "Draw";
                    }

                    return value;
                }
                if (root.Data.Count % 2 == 0)
                {
                    value = "Black";
                    if (child.WinState == "White")
                    {
                        return value = "White";
                    }
                    if (child.WinState == "Draw")
                    {
                        value = "Draw";
                    }

                    return value;
                }
            }
            return value;
        }


        public Recursive()
		{
		}
	}
}