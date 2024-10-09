using MediatR;
using MediatRWebapi.Data.Command;
using MediatRWebapi.Data.Query;
using MediatRWebapi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator Mediator) : ControllerBase
    {
        private readonly IMediator _iMediator = Mediator;
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<List<Employee>> Get() =>
            await _iMediator.Send(new GetEmployeeListQuery());

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<Employee> Get(int id) => 
            await _iMediator.Send(new GetEmployeeByIdQuery(id));

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<Employee> Post([FromBody] Employee employee) => 
            await _iMediator.Send(
                new CreateEmployeeCommand(
                    employee.Name, 
                    employee.Address, 
                    employee.Email, 
                    employee.Phone));

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<int> Put([FromBody] Employee employee) =>
              await _iMediator.Send(new UpdateEmployeeCommand(
                employee.Id,
                employee.Name,
                employee.Address,
                employee.Email,
                employee.Phone
            ));

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id) =>
            await _iMediator.Send(new DeleteEmployeeCommand(id));
    }
}
