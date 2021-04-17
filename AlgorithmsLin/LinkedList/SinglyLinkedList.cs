using System;

namespace AlgorithmsLin.LinkedList
{
	public class SinglyLinkedList
	{
		private Node _first;

		public bool IsEmpty() =>
			_first == null;

		public void InsertFirst(int data)
		{
			var addedNode = new Node(data, _first);

			_first = addedNode;
		}

		public Node DeleteFirst()
		{
			var temp = _first;
			_first = _first.Next;

			return temp;
		}

		public void InsertLast(int data)
		{
			var current = _first;

			while (current.Next!=null)
			{
				current = current.Next;
			}

			var createdNode = new Node(data);
			current.Next = createdNode;
		}
		public void Display()
		{
			var current = _first;

			while (current != null)
			{
				current.DisplayNode();

				current = current.Next;

			}

			Console.WriteLine("End");
		}
	}
	
}