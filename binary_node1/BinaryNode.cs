using System;

namespace binary_node1
{
	class BinaryNode<T>
	{
		public T Value { get; set; }
		private BinaryNode<T> RightChild { get; set; }
		private BinaryNode<T> LeftChild { get; set; }

		public BinaryNode(T value)
		{
			Value = value;
			RightChild = null;
			LeftChild = null;
		}

		public void AddRight(BinaryNode<T> child)
		{
			RightChild = child;
		}

		public void AddLeft(BinaryNode<T> child)
		{
			LeftChild = child;
		}

		public override string ToString()
		{
			return string.Format("{0}: {1} {2}\n", Value,
				LeftChild == null ? (object)"null" : LeftChild.Value,
				RightChild == null ? (object)"null" : RightChild.Value);
		}

		public void PrintTree(BinaryNode<T> node)
		{
			if (node == null)
			{
				return;
			}

			Console.Write(node.ToString());
			PrintTree(node.LeftChild);
			PrintTree(node.RightChild);
		}
	}
}
