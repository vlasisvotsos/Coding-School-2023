using BlazorWasm.Client.Pages.Customer;
using BlazorWasm.Shared.Customer;
using EF.Model;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepo _customerRepo;
        public CustomerController(CustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> Get()
        {
            var result = _customerRepo.GetAll();
            return result.Select(customer => new CustomerDto
            {
                ID = customer.ID,
                CardNumber = customer.CardNumber,
                Name = customer.Name,
                Surname = customer.Surname
            });
        }

        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
                ID = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber
            };
        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer(customer.Name);
            newCustomer.ID = customer.ID;
            newCustomer.Name = customer.Name;
            newCustomer.Surname = customer.Surname;
            newCustomer.CardNumber = customer.CardNumber;
            _customerRepo.Add(newCustomer);
        }
        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var customerToUpdate = _customerRepo.GetById(customer.ID);
            customerToUpdate.ID = customer.ID;
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.CardNumber = customer.CardNumber;
            _customerRepo.Update(customer.ID, customerToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _customerRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex)
            {
                return BadRequest("This customer cannot be deleted!");
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest($"Customer with id {id} not found!");
            }

        }
    }
}
