using BlazorWasm.Client.Pages.Customer;
using BlazorWasm.Shared.Customer;
using EF.Model;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepo _customerRepo;
        CustomerController(CustomerRepo customerRepo) 
        {
            _customerRepo = customerRepo;
        }
        [HttpGet]
       public async Task<IEnumerable<CustomerDto>> Get()
        {
            var result = _customerRepo.GetAll();
            return result.Select(customer => new CustomerDto
            {
                ID= customer.ID,
                CardNumber= customer.CardNumber,
                Name= customer.Name,
                Surname= customer.Surname               
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
            newCustomer.Surname = customer.Surname;
            _customerRepo.Add(newCustomer);
        }
        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var customerToUpdate = _customerRepo.GetById(customer.ID);
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname=customer.Surname;
            _customerRepo.Update(customer.ID,customerToUpdate);
        }

    }
}
