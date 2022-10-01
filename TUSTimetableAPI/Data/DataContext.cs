using Microsoft.EntityFrameworkCore;

namespace TUSTimetableAPI.Data;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{
		
	}
	
}