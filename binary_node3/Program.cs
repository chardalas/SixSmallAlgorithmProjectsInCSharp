using System;

namespace ExhaustiveSearch.binary_node
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryNode<string> root = new BinaryNode<string>("Root");

			var a = new BinaryNode<string>("A");
			var b = new BinaryNode<string>("B");
			var c = new BinaryNode<string>("C");
			var d = new BinaryNode<string>("D");
			var e = new BinaryNode<string>("E");
			var f = new BinaryNode<string>("F");

			a.AddRight(d);
			a.AddLeft(c);

			b.AddRight(e);
			e.AddLeft(f);

			root.AddLeft(a);
			root.AddRight(b);

			FindValue(root, "E");


			Console.ReadLine();
		}

		static void FindValue(BinaryNode<string> root, string target)
		{
			var node = root.FindNode(target);

			if (node != null)
			{
				Console.WriteLine("Node {0} was found", node.Value);
			}
			else
			{
				Console.WriteLine("Node {0} was not found", target);
			}
		}

	}
}

