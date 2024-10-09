using MediatR;
using MediatRWebapi.Data.Query;
using MediatRWebapi.Models;
using MediatRWebapi.Services;

namespace MediatRWebapi.Data.Handlers;

public class GetEmployeeByIdHandler(IEmployeeRepository EmployeeRepository) : IRequestHandler<GetEmployeeByIdQuery, Employee>
{
    private readonly IEmployeeRepository _employeeRepository = EmployeeRepository;
    public async Task<Employee> Handle(
        GetEmployeeByIdQuery request, CancellationToken cancellationToken) => 
        await _employeeRepository.GetEmployeeByIdAsync(request.Id);
}
