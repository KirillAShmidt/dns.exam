public struct MyStruct
{
	public string Name { get; set; }

	public MyStruct(string name)
	{
		Name = name;
	}
}

public struct MyClass
{
	public MyStruct MyStruct { get; set; }

	public MyClass(MyStruct myStruct)
	{
		MyStruct = myStruct;
	}
}

public class Program
{
	public static void Main()
	{

	}
}