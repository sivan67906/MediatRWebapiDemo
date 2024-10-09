using MediatRWebapi.Data;
using MediatRWebapi.Models;

namespace MediatRWebapi.Services;

public class EmployeeRepository(AppDbContext AppDbContext) : IEmployeeRepository
{
    private readonly AppDbContext _appDbContext = AppDbContext;
    public async Task<Employee> CreateEmployeeAsync(Employee employee)
    {
        var result = _appDbContext.Employees.Add(employee);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> DeleteEmployeeAsync(int Id)
    {
        var result = _appDbContext.Employees.Where(emp => emp.Id == Id).FirstOrDefault();
        _appDbContext.Employees.Remove(result);
        _appDbContext.SaveChangesAsync();
        return result.Id;
    }

    public async Task<Employee> GetEmployeeByIdAsync(int Id)
    {
        var result = _appDbContext.Employees.Where(emp => emp.Id == Id).FirstOrDefault();
        return result;
    }

    public async Task<List<Employee>> GetEmployeeListAsync()
    {
        List<Employee> result = _appDbContext.Employees.ToList();
        return result;
    }

    public async Task<int> UpdateEmployeeAsync(Employee employee)
    {
        var result = _appDbContext.Employees.Update(employee);
        await _appDbContext.SaveChangesAsync();
        return result.Entity.Id;
    }
}
