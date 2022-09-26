using System;


namespace connect4

{

	public class TreeNode<Board>
	{
		private Board data;
		private TreeNode<Board> parent;
		private List<TreeNode<Board>> children;

		public Board Data //property
		{
			get { return data; }
			set { this.data = value; }
		}
		public TreeNode<Board> Parent
		{
			get { return parent; }
			set { parent = value; }
		}
		public List<TreeNode<Board>> Children
		{
			get { return children; }
			set { children = value; }
		}
		public int GetHeight()
		{
			int height = 1;
			TreeNode<Board> current = this;
			while (current.Parent != null)
			{
				height++;
				current = current.Parent;

			}
			return height;
		}


	}
}