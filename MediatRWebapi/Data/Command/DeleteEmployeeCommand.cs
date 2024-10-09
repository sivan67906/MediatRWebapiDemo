using MediatR;

namespace MediatRWebapi.Data.Command;

public record DeleteEmployeeCommand(int Id) : IRequest<int>;

