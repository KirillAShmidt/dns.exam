[Serializable]
public class UserFailedProcessedException : Exception
{
	public string? UserName { get; }
	public string? ProcessName { get; }
	public DateTime DateTime { get; }

	public UserFailedProcessedException() : base () { }
	public UserFailedProcessedException(string message) : base(message) { }
	public UserFailedProcessedException(string message, Exception innerException) : base(message, innerException) { }
	public UserFailedProcessedException(string message, string userName, string processName) : this(message)
	{
		UserName = userName;
		ProcessName = processName;
		DateTime = DateTime.Now;
	}
}

public class Program
{
	public static void Do()
	{
		try
		{
			throw new UserFailedProcessedException
				(
					message: "Process failed",
					userName: "User",
					processName: "Process"
				);
		}
		//catch { }
		finally 
		{
			Console.WriteLine("111");
		}
	}

	public static void Main(string[] args)
	{
		Do();
	}
}