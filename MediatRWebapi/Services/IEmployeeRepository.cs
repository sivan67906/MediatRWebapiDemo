using MediatRWebapi.Models;

namespace MediatRWebapi.Services;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetEmployeeListAsync();
    Task<Employee> GetEmployeeByIdAsync(int Id);
    Task<Employee> CreateEmployeeAsync(Employee employee);
    Task<int> UpdateEmployeeAsync(Employee employee);
    Task<int> DeleteEmployeeAsync(int Id);
}
