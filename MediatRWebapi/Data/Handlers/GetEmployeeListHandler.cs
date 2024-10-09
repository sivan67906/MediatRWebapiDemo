using MediatR;
using MediatRWebapi.Data.Query;
using MediatRWebapi.Models;
using MediatRWebapi.Services;

namespace MediatRWebapi.Data.Handlers;

public class GetEmployeeListHandler(IEmployeeRepository EmployeeRepository) : IRequestHandler<GetEmployeeListQuery, List<Employee>>
{
    private readonly IEmployeeRepository _employeeRepository = EmployeeRepository;
    public async Task<List<Employee>> Handle(
        GetEmployeeListQuery request, CancellationToken cancellationToken) =>
        await _employeeRepository.GetEmployeeListAsync();
}
