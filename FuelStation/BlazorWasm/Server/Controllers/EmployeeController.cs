using BlazorWasm.Shared.Customer;
using BlazorWasm.Shared.Employee;
using EF.Model;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepo _employeeRepo;
        public EmployeeController(EmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeesDto>> Get()
        {
            var result = _employeeRepo.GetAll();
            return result.Select(employee => new EmployeesDto
            {
                ID = employee.ID,
                Name = employee.Name,
                Surname = employee.Surname,
                HiretDateStart = employee.HiretDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
                EmployeeType = employee.EmployeeType,
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditDto> GetById(int id)
        {
            var result = _employeeRepo.GetById(id);
            return new EmployeeEditDto
            {
              ID = result.ID,
              Name = result.Name,
              Surname = result.Surname,
              HiretDateStart= result.HiretDateStart,
              HireDateEnd= result.HireDateEnd,
              SallaryPerMonth= result.SallaryPerMonth,
              EmployeeType = result.EmployeeType,
            };
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee();
            newEmployee.ID = employee.ID;
            newEmployee.Name = employee.Name;
            newEmployee.Surname = employee.Surname;
            newEmployee.HiretDateStart = employee.HiretDateStart;
            newEmployee.HireDateEnd = employee.HireDateEnd;
            newEmployee.SallaryPerMonth = employee.SallaryPerMonth;
            newEmployee.EmployeeType = employee.EmployeeType;
            _employeeRepo.Add(newEmployee);
        }
        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {
            var employeeToUpdate = _employeeRepo.GetById(employee.ID);
            employeeToUpdate.ID = employee.ID;
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Surname = employee.Surname;
            employeeToUpdate.HiretDateStart = employee.HiretDateStart;
            employeeToUpdate.HireDateEnd = employee.HireDateEnd;
            employeeToUpdate.SallaryPerMonth= employee.SallaryPerMonth;
            employeeToUpdate.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(employee.ID, employeeToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _employeeRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex)
            {
                return BadRequest("This employee cannot be deleted!");
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest($"Employee with id {id} not found!");
            }

        }
    }
}
