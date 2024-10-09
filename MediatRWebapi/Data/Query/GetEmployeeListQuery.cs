using MediatR;
using MediatRWebapi.Models;

namespace MediatRWebapi.Data.Query;

public record GetEmployeeListQuery : IRequest<List<Employee>>;
