using System;
using System.Collections.Generic;

namespace Outlineviews.NaryNode
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
			return ToString("");
		}

		public string ToString(string spaces)
		{
			var result = string.Format("{0}{1}:\n", spaces, Value);

			foreach (var child in Children)
			{
				result += child.ToString(spaces + "  ");
			}

			return result;
		}
	}
}
