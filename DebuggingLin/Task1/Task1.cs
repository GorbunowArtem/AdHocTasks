using System;

namespace DebuggingLin.Task1
{
	public class Task1
	{
		public int FindMin(int[] array)
		{
			var min = array[0];
			
			
			for (int i = 1; i < array.Length; i++)
			{
				var current = array[i];
				if (min > current)
				{
					min = current;
				}
				
			}

			return min;
		}
	}
}