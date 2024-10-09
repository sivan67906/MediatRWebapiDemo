using MediatR;
using MediatRWebapi.Models;

namespace MediatRWebapi.Data.Command;

public class UpdateEmployeeCommand(int id, string name, string address, string email, string phone) : IRequest<int>
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;
    public string Email { get; set; } = email;
    public string Phone { get; set; } = phone;
}
