using System;

namespace AlgorithmsLin.LinkedList
{
	public class Node
	{
		public Node(int data, Node next = null)
		{
			Data = data;
			Next = next;
		}

		public int Data { get; set; }

		public Node Next { get; set; }

		public void DisplayNode() =>
			Console.WriteLine($"<{Data.ToString()}>");
	}
}