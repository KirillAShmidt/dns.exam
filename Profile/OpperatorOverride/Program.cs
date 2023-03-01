public class Program
{
	public class MegaHugeNumber
	{
		public string _number;

		public MegaHugeNumber(string number)
		{
			_number = number;
		}

		public static int operator +(MegaHugeNumber counter1, MegaHugeNumber counter2)
		{
			var x = Int32.Parse(counter1._number);
			var y = Int32.Parse(counter2._number);
			return x + y;
		}
		public static int operator -(MegaHugeNumber counter1, MegaHugeNumber counter2)
		{
			var x = Int32.Parse(counter1._number);
			var y = Int32.Parse(counter2._number);
			return x - y;
		}

		public static int operator *(MegaHugeNumber counter1, MegaHugeNumber counter2)
		{
			var x = Int32.Parse(counter1._number);
			var y = Int32.Parse(counter2._number);
			return x * y;
		}

		public static int operator /(MegaHugeNumber counter1, MegaHugeNumber counter2)
		{
			var x = Int32.Parse(counter1._number);
			var y = Int32.Parse(counter2._number);
			return x / y;
		}
	}


	public static void Main(string[] args)
	{
		Console.WriteLine(new MegaHugeNumber("123") + new MegaHugeNumber("234"));
	}
}