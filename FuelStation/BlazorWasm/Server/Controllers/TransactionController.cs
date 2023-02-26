using BlazorWasm.Shared.Customer;
using BlazorWasm.Shared.Transaction;
using EF.Model;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionRepo _transactionRepo;
        public TransactionController(TransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionDto>> Get()
        {
            var result = _transactionRepo.GetAll();
            return result.Select(transaction => new TransactionDto
            {
                ID = transaction.ID,
                Date = transaction.Date,
                EmployeeID = transaction.EmployeeID,
                CustomerID = transaction.CustomerID,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id)
        {
            var result = _transactionRepo.GetById(id);
            return new TransactionEditDto
            {
                ID = id,
                Date = result.Date,
                EmployeeID = result.EmployeeID,
                CustomerID = result.CustomerID,
                PaymentMethod = result.PaymentMethod,
                TotalValue = result.TotalValue,
            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var newTransaction = new Transaction(transaction.ID);
            newTransaction.ID = transaction.ID;
            newTransaction.Date = transaction.Date;
            newTransaction.EmployeeID = transaction.EmployeeID;
            newTransaction.CustomerID = transaction.CustomerID;
            newTransaction.PaymentMethod = transaction.PaymentMethod;
            newTransaction.TotalValue = transaction.TotalValue;
            _transactionRepo.Add(newTransaction);
        }
        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var transactionToUpdate = _transactionRepo.GetById(transaction.ID);
            transactionToUpdate.ID = transaction.ID;
            transactionToUpdate.Date = transaction.Date;
            transactionToUpdate.EmployeeID = transaction.EmployeeID;
            transactionToUpdate.CustomerID = transaction.CustomerID;
            _transactionRepo.Update(transaction.ID, transactionToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _transactionRepo.Delete(id);
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
