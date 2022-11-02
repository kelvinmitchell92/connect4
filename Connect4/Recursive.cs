using System;

namespace connect4
{
    public class Recursive
    {
        //List<TreeNode<Board>> dynamic = new List<TreeNode<Board>>();
        //bool dynamicCheck;
        //public List<TreeNode<Board>> Dynamic { get { return dynamic; } }
        public string Recursion(TreeNode<Board> Root)
        {
           
            if (Root.Data.Winner == "Not Finished")
            {
                for (int i = 0; i < Root.Data.Length; i++)
                {
                    
                    if (Root.Data.board[0, i] == 0)
                    {
                        Board board2 = new Board(Root.Data.Length,Root.Data.Height,Root.Data.WinLength);
                        for (int k = 0; k < Root.Data.Height; k++)
                        {
                            for (int j = 0; j < Root.Data.Length; j++)
                            {
                                board2.board[k, j] = Root.Data.board[k, j];
                            }
                        }
                        board2.Count = Root.Data.Count;
                        board2.Winner = Root.Data.Winner;

                        TreeNode<Board> child = new TreeNode<Board>();
                        child.Children = new List<TreeNode<Board>>();
                        child.Data = board2.play(i, board2);
                        child.Parent = Root;
                        Root.Children.Add(child);
                        /*foreach( TreeNode<Board> node in dynamic) 
                        {
                            dynamicCheck = true;
                            while (dynamicCheck)
                            {
                                for (int k = 0; k < node.Data.Length; k++)
                                {
                                    for (int j = 0; j < node.Data.Height; j++)
                                    {
                                        if(node.Data.board[j, k] != child.Data.board[j, k])
                                        {
                                            dynamicCheck = false; 
                                        }
                                    }
                                }

                                return child.WinState = node.WinState;

                            }
                        
                        }*/
                        if (child.Data.Count % 2 == 0)
                        {
                            if (child.Data.Winner == "Black")
                            {
                                return child.WinState = child.Data.Winner;

                            }
                        }
                        if (child.Data.Count % 2 == 1)
                        {
                            if (child.Data.Winner == "White")
                            {
                                return child.WinState = child.Data.Winner;

                            }
                        } 

                        if (board2.Count == 0)
                        {
                            board2.boardToString();
                        } 
                       
                        if (child.Data.Winner == "Black" || child.Data.Winner == "White" || child.Data.Winner == "Draw")
                        {
                            child.WinState = child.Data.Winner;
                            //dynamic.Add(child);
                        }
                        else
                        {
                            child.WinState = Recursion(child);
                        }

                    }
                }
            }

            return Root.WinState = checkingMethod(Root);
        }

        public string checkingMethod(TreeNode<Board> root)
        {
            string value = "";

            if (root.Data.Count % 2 > 0)
            {
                value = "White";
            }
            if (root.Data.Count % 2 == 0)
            {
                value = "Black";
            }


            foreach (TreeNode<Board> child in root.Children)
            {
                if (root.Data.Count % 2 > 0)
                {
                    //value = "White";
                    if (child.WinState == "Black")
                    {
                        return value = "Black";
                    }
                    if (child.WinState == "Draw")
                    {
                        value = "Draw";
                    }

                    //return value;
                }
                if (root.Data.Count % 2 == 0)
                {
                    //value = "Black";
                    if (child.WinState == "White")
                    {
                        return value = "White";
                    }
                    if (child.WinState == "Draw")
                    {
                        value = "Draw";
                    }

                    //return value;
                }
            }
            return value;
        }


        public Recursive()
        {
        }
    }
}