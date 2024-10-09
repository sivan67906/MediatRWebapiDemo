using MediatR;
using MediatRWebapi.Models;

namespace MediatRWebapi.Data.Command;

public record CreateEmployeeCommand(
    string Name, string Address, string Email, string Phone) : IRequest<Employee>;
