using System;
namespace WebApi.Crud.Model;


public class Employee
{
	[Key]
	public int EmployeeId { get; set; }
	public string Name { get; set; }
	public string Address { get; set; }
	public string PhoneNumber { get; set; }
	public DateTime CreatedOn { get; set; }

}
