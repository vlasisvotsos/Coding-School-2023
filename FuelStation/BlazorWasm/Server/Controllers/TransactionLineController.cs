using BlazorWasm.Shared.Customer;
using BlazorWasm.Shared.TransactionLine;
using EF.Model;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase
    {
        private readonly TransactionLineRepo _transactionLineRepo;
        public TransactionLineController(TransactionLineRepo transactionLineRepo)
        {
            _transactionLineRepo = transactionLineRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionLineDto>> Get()
        {
            var result = _transactionLineRepo.GetAll();
            return result.Select(transactionLine => new TransactionLineDto
            {
               ID = transactionLine.ID,
               TransactionID = transactionLine.TransactionID,
               ItemID = transactionLine.ItemID,
               Quantity = transactionLine.Quantity,
               ItemPrice = transactionLine.ItemPrice,
               NetValue = transactionLine.NetValue,
               DiscountPercent = transactionLine.DiscountPercent,
               DiscountValue = transactionLine.DiscountValue,
               TotalValue = transactionLine.TotalValue,
            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionLineEditDto> GetById(int id)
        {
            var result = _transactionLineRepo.GetById(id);
            return new TransactionLineEditDto
            {
                ID = id,
                TransactionID = result.ID,
                ItemID = result.ItemID,
                Quantity = result.Quantity,
                ItemPrice = result.ItemPrice,
                NetValue = result.NetValue,
                DiscountPercent = result.DiscountPercent,
                DiscountValue = result.DiscountValue,
                TotalValue = result.TotalValue,
            };
        }

        [HttpPost]
        public async Task Post(TransactionLineEditDto transactionLine)
        {
            var newTransactionLine = new TransactionLine(transactionLine.ID);
            newTransactionLine.ID = transactionLine.ID;
            newTransactionLine.TransactionID = transactionLine.TransactionID;
            newTransactionLine.ItemID = transactionLine.ItemID;
            newTransactionLine.Quantity = transactionLine.Quantity;
            newTransactionLine.ItemPrice = transactionLine.ItemPrice;
            newTransactionLine.NetValue = transactionLine.NetValue;
            newTransactionLine.DiscountPercent = transactionLine.DiscountPercent;
            newTransactionLine.DiscountValue = transactionLine.DiscountValue;
            newTransactionLine.TotalValue = transactionLine.TotalValue;      
            _transactionLineRepo.Add(newTransactionLine);
        }
        [HttpPut]
        public async Task Put(TransactionLineEditDto transactionLine)
        {
            var transactionLineToUpdate = _transactionLineRepo.GetById(transactionLine.ID);
            transactionLineToUpdate.ID = transactionLine.ID;
            transactionLineToUpdate.TransactionID = transactionLine.TransactionID;
            transactionLineToUpdate.ItemID = transactionLine.ItemID;
            transactionLineToUpdate.Quantity = transactionLine.Quantity;
            transactionLineToUpdate.ItemPrice = transactionLine.ItemPrice;
            transactionLineToUpdate.NetValue = transactionLine.NetValue;
            transactionLineToUpdate.DiscountPercent = transactionLine.DiscountPercent;
            transactionLineToUpdate.DiscountValue = transactionLine.DiscountValue;
            transactionLineToUpdate.TotalValue = transactionLine.TotalValue;
            _transactionLineRepo.Update(transactionLine.ID, transactionLineToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _transactionLineRepo.Delete(id);
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
