using Domain.Models;
namespace Infrastructure;

public class EmployeeService
{
 public List<Employee>  _employees=new List<Employee>();
 
public List<Employee> GetEmployees()
{
    return _employees;
}
public void AddEmployees(Employee employee)
{
_employees.Add(employee);
}

}

