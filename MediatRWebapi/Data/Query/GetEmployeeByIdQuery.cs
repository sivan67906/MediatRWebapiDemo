using MediatR;
using MediatRWebapi.Models;

namespace MediatRWebapi.Data.Query
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<Employee>;
}
