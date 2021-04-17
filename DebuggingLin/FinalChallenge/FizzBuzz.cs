﻿using System;

namespace DebuggingLin.FinalChallenge
{
	public class FizzBuzz
	{
		public void Execute()
		{
			for (int i = 1; i < 100; i++)
			{
				if (i % 15 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}