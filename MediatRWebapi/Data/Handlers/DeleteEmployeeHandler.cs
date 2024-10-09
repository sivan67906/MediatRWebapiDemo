using MediatR;
using MediatRWebapi.Data.Command;
using MediatRWebapi.Models;
using MediatRWebapi.Services;

namespace MediatRWebapi.Data.Handlers;

public class DeleteEmployeeHandler(IEmployeeRepository EmployeeRepository) : IRequestHandler<DeleteEmployeeCommand, int>
{
    private readonly IEmployeeRepository _employeeRepository = EmployeeRepository;

    public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        Employee employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        if (employee == null)
            return default;
        else
        {
            return await _employeeRepository.DeleteEmployeeAsync(employee.Id);
        }
    }
}
