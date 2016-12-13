using System;

namespace GenericsLab
{
	public class LimitingGenerics
	{
		public void tryIt()
		{
			//error var employee = new SuperPerson<ExEmployee>(); 
			var employee = new SuperPerson<CurrentEmployee>();
		}
	}

	public class CurrentEmployee
	{


		public CurrentEmployee(string s, int i)
		{

		}


	}

	public class ExEmployee
	{

		public ExEmployee(string s, int i)
		{
			
		}

		
	}

	public class SuperPerson<T> where T : CurrentEmployee
	{
		public SuperPerson()
		{
			Console.WriteLine("I am a super employee");
		}
	}
}