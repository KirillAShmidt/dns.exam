public abstract class Human
{
	public required string Name { get; set; }

	public void Talk()
	{
		Console.WriteLine("I'm Human");
	}

	public void Talk(string message)
	{
		Console.WriteLine(message);
	}

	public abstract void Do(); 
}

public class Girl : Human
{
	public new void Talk()
	{
		Console.WriteLine("I'm Girl");
	}

	public override void Do()
	{
		Console.WriteLine("Girl is doing something");
	}
}

public class Boy : Human
{
	public override void Do()
	{
		Console.WriteLine("Boy is doing something");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Human girl = new Girl { Name = "Girl" };
		Human boy = new Boy { Name = "Boy" };

		girl.Talk();
		girl.Talk("overriden girl talk method");
		boy.Talk();

		girl.Do();
		boy.Do();

		Girl newGirl = new Girl { Name = "newGirl" };
		Boy newBoy = new Boy { Name = "newBoy" };

		newGirl.Talk();
		newBoy.Talk();
	}
}