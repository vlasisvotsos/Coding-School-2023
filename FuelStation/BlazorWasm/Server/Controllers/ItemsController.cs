using BlazorWasm.Shared.Customer;
using BlazorWasm.Shared.Items;
using EF.Model;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemRepo _itemRepo;
        public ItemsController(ItemRepo itemRepo)
        {
            _itemRepo = itemRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<ItemsDto>> Get()
        {
            var result = _itemRepo.GetAll();
            return result.Select(item => new ItemsDto
            {
                ID = item.ID,
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
            });
        }

        [HttpGet("{id}")]
        public async Task<ItemEditDto> GetById(int id)
        {
            var result = _itemRepo.GetById(id);
            return new ItemEditDto
            {
                ID = id,
                Code = result.Code,
                Description = result.Description,
                ItemType = result.ItemType,
                Price = result.Price,
                Cost = result.Cost,
            };
        }

        [HttpPost]
        public async Task Post(ItemEditDto item)
        {
            var newItem = new Item(item.ID);
            newItem.Code = item.Code;
            newItem.Description = item.Description;
            newItem.ItemType = item.ItemType;
            newItem.Price = item.Price;
            newItem.Cost = item.Cost;
            _itemRepo.Add(newItem);
        }
        [HttpPut]
        public async Task Put(ItemEditDto item)
        {
            var itemToUpdate = _itemRepo.GetById(item.ID);
            itemToUpdate.ID = item.ID;
            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;
            _itemRepo.Update(item.ID, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _itemRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex)
            {
                return BadRequest("This item cannot be deleted!");
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest($"Item with id {id} not found!");
            }

        }
    }
}
