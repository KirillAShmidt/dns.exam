public class Wrapper
{
	public delegate void TestDelegate();
	TestDelegate testDelegate;
	public event TestDelegate testEvent
	{
		add
		{
			testDelegate += value;
			Console.WriteLine("added");
		}
		remove
		{
			testDelegate -= value;
			Console.WriteLine("removed");
		}
	}

	public void Invoke()
	{
		testDelegate?.Invoke();
		Console.WriteLine("event triggered");
	}

	public void ClearEvents()
	{
		Console.WriteLine(testDelegate.GetInvocationList().Length);
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		var wrapper = new Wrapper();
		wrapper.testEvent += Do;

		wrapper.Invoke();
		wrapper.ClearEvents();
	}

	public static void Do()
	{
		Console.WriteLine("Do");
	}
}