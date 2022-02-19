using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node1
{
	class BinaryNode<T>
	{
		public T Value { get; set; }
		public BinaryNode<T> RightChild { get; set; }
		public BinaryNode<T> LeftChild { get; set; }

		public BinaryNode(T value)
		{
			Value = value;
			RightChild = null;
			LeftChild = null;
		}

		void AddRight(BinaryNode<T> node, BinaryNode<T> child)
		{
			node.RightChild = child;
		}

		void AddLeft(BinaryNode<T> node, BinaryNode<T> child)
		{
			node.LeftChild = child;
		}

		public override string ToString()
		{

			return string.Format("my_value: {0} left_child_value: {1} right_child_value: {2}", Value, LeftChild, RightChild);
		}

	}
}
