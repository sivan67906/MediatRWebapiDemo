using MediatRWebapi.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRWebapi.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
}
