using System;

namespace Outlineviews.binary_node
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
			return ToString("");
		}

		public string ToString(string spaces)
		{
			Console.Write(string.Format("{0}{1}: \n", spaces, Value));


			if (LeftChild == null || RightChild == null)
			{
				Console.Write(string.Format("{0}None\n", spaces + "  "));
			}

			if (LeftChild != null)
			{
				LeftChild.ToString(spaces + "  ");
			}

			if (RightChild != null)
			{
				RightChild.ToString(spaces + "  ");
			}

			return "";
		}
	}
}
