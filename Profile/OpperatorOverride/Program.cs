using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
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

	[Benchmark]
	public int AddBigAmount()
	{
		int result = 0;
		
		for (int i = 0; i < 10000; i++)
		{
			result += new MegaHugeNumber("1") + new MegaHugeNumber("2");
		}

		return result;
	}
	
	
	public int AddMediumAmount()
	{
		int result = 0;
		
		for (int i = 0; i < 1000; i++)
		{
			result += new MegaHugeNumber("1") + new MegaHugeNumber("2");
		}

		return result;
	}
	
	public int AddSmallAmount()
	{
		int result = 0;
		
		for (int i = 0; i < 1000; i++)
		{
			result += new MegaHugeNumber("1") + new MegaHugeNumber("2");
		}

		return result;
	}

	[Benchmark]
	public int AddInt()
	{
		int result = 0;
		
		for (int i = 0; i < 10000; i++)
		{
			result += 3;
		}

		return result;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(new MegaHugeNumber("123") + new MegaHugeNumber("234"));
		var summary = BenchmarkRunner.Run<Program>();
	}
	
	[GlobalSetup]
	public void Setup()
	{
		System.Diagnostics.Debugger.Launch();
	}
}