using MediatR;
using MediatRWebapi.Data.Command;
using MediatRWebapi.Models;
using MediatRWebapi.Services;

namespace MediatRWebapi.Data.Handlers;

public class UpdateEmployeeHandler(IEmployeeRepository EmployeeRepository) : IRequestHandler<UpdateEmployeeCommand, int>
{
    private readonly IEmployeeRepository _employeeRepository = EmployeeRepository;
    public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        Employee employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        if (employee == null)
            return default;
        else
        {
            employee.Name = request.Name;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            employee.Address = request.Address;
            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
