using BlazorWasm.Client.Pages.Customer;
using BlazorWasm.Shared.Customer;
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

        //[HttpGet("{id}")]
        //public async Task<CustomerEditDto> GetById(int id)
        //{
        //    var result = _customerRepo.GetById(id);
        //    return new CustomerEditDto
        //    {
        //        Id = id,
        //        Title = result.Title,
        //        TodoType = result.TodoType,
        //        Finished = result.Finished,
        //        Comments = result.Comments.Select(comment => new TodoEditCommentDto
        //        {
        //            Id = comment.Id,
        //            Text = comment.Text
        //        }).ToList()
        //    };
        //}

    }
}
