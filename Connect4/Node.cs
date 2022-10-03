using System;

namespace connect4

{
	public class Node
	{

		Node parent;
		Board data;
		string couldWin;
		bool finished = false;
		List<Node> children;

		public Board Data //property
		{
			get { return data; }
			set { this.data = value; }
		}
		public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }
		public string CouldWin
        {
			get { return couldWin; }
			set { couldWin = value; }
        }
		public bool Finished
        {
			get { return finished; }
			set { finished = value; }
        }
		public void addChild(Node node)
		{
			children.Add(node);
		}

		public Node()
		{
			data = new Board();
			couldWin = "not finished";
			List<Node> children = new List<Node>();

		}


		public Node(Board board)
		{
			data = board;
			couldWin = board.Winner;
			List<Node> children = new List<Node>();
		}

		public void print()
		{
			data.boardToString();
			Console.WriteLine("Player Who Could Force a Win: " + couldWin);
		}

		public void play(int i)
		{
			if (i < 0 || i > 6)
			{
				Console.WriteLine("Not a Valid Play");
			}
			else
			{
				data.play(i,data);
			}

		}
	}
}