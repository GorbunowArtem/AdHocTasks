using AlgorithmsLin.LinkedList;

namespace AlgorithmsLin
{
	public class Program
	{
		public static void Main()
		{
			var l = new SinglyLinkedList();

			l.InsertFirst(1);
			l.Display();

			l.InsertFirst(2);
			l.Display();

			l.InsertLast(3);
			l.Display();

			l.DeleteFirst();
			l.Display();
			
			
		}
	}
}