using System;

namespace ExhaustiveSearch.binary_node
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

		public BinaryNode<T> FindNode(T target)
		{

			if (Value.Equals(target))
			{
				return this;
			}

			if (LeftChild != null)
			{
				var node = LeftChild.FindNode(target);

				if (node != null)
				{
					return node;
				}
			}

			if (RightChild != null)
			{
				var node = RightChild.FindNode(target);

				if (node != null)
				{
					return node;
				}
			}


			return null;
		}

		public override string ToString()
		{
			return string.Format("{0}: {1} {2}\n", Value,
				LeftChild == null ? (object)"null" : LeftChild.Value,
				RightChild == null ? (object)"null" : RightChild.Value);
		}
	}
}
