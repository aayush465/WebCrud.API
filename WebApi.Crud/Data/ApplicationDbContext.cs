using System;
namespace WebApi.Crud.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{


		}

		public dbSet<Employee> Employees { get; set; }
	}
}

