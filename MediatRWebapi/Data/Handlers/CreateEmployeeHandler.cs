using MediatR;
using MediatRWebapi.Data.Command;
using MediatRWebapi.Models;
using MediatRWebapi.Services;

namespace MediatRWebapi.Data.Handlers;

public class CreateEmployeeHandler(IEmployeeRepository EmployeeRepository) : IRequestHandler<CreateEmployeeCommand, Employee>
{
    private readonly IEmployeeRepository _employeeRepository = EmployeeRepository;
    public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        Employee employee = new Employee 
        { 
            Name = request.Name, 
            Address = request.Address, 
            Email = request.Email, 
            Phone = request.Phone 
        };
        return await _employeeRepository.CreateEmployeeAsync(employee);
    }
}
