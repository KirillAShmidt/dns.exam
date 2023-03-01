public interface IOrganizationEntity { }
public interface IUserEntity : IOrganizationEntity { }
public class WarehouseWorker : IUserEntity { }
public class CashierWorker : WarehouseWorker { }

public interface IContrvariantManager<in T> where T : IUserEntity
{
		
}
public interface ICovariantManager<out T> where T : IUserEntity
{

}
public class UserManager<T> : ICovariantManager<T>, IContrvariantManager<T> where T : IUserEntity  
{

}

public class Program
{
	public static void Main(string[] args)
	{
		UserManager<IUserEntity> user = new UserManager<IUserEntity>();
		UserManager<WarehouseWorker> worker = new UserManager<WarehouseWorker>();

		IContrvariantManager<CashierWorker> contrvariant = user;
		ICovariantManager<WarehouseWorker> covariant = worker;
	}
}