public class User
{
	public required string Name { get; set; }
}

public class Users
{
	public int Length => _users.Count;

	private List<User> _users = new List<User>();

	public Users(User[] users) => _users = users.ToList();

	public User this[int index]
	{
		get => _users[index];
		set => _users[index] = value;
	}

	public void Add(User user) => _users.Add(user);

	public void Remove(int index) => _users.RemoveAt(index);

	public void Remove(User user) => _users.Remove(user);
}

public class Program
{
	public static User[] custonUsers = new User[]
	{
		new User{ Name = "Kirill" },
		new User{ Name = "Anton" },
		new User{ Name = "Nikita" },
		new User{ Name = "Ivan" },
		new User{ Name = "Alexey" },
		new User{ Name = "Alexandr" }
	};

	public static Users users = new Users(custonUsers);

	public static void Main(string[] args)
	{
		users.Add(new User { Name = "New User" });
		users.Add(new User { Name = "New User" });
		users.Add(new User { Name = "New User" });
		users.Remove(0);
		Console.WriteLine(users[0].Name);
		Console.WriteLine(users.Length);
	}
}