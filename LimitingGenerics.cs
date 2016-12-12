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
		private string name;
		private int id;

		public CurrentEmployee(string s, int i)
		{
			name = s;
			id = i;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
	}

	public class ExEmployee
	{
		private string name;
		private int id;

		public ExEmployee(string s, int i)
		{
			name = s;
			id = i;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
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