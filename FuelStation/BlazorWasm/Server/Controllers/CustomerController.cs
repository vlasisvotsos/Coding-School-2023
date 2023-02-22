using BlazorWasm.Shared;
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
    }
}
