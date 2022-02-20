using System;
using System.Collections.Generic;

namespace NaryNode
{
	class NaryNode<T>
	{
		public T Value { get; set; }
		public List<NaryNode<T>> Children { get; set; }

		public NaryNode(T value)
		{
			Value = value;
			Children = new List<NaryNode<T>>();
		}

		public void AddChild(NaryNode<T> child)
		{
			Children.Add(child);
		}

		public override string ToString()
		{
			string values = Value.ToString() + ":";

			foreach (var child in Children)
			{
				values += string.Format(" {0} ", child.Value);
			}

			return values;
		}
	}
}
