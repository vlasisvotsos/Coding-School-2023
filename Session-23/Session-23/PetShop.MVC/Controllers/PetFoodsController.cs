using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetShop.MVC.Data;
using PetShop.Model;

namespace PetShop.MVC.Controllers
{
    public class PetFoodsController : Controller
    {
        private readonly PetShopMVCContext _context;

        public PetFoodsController(PetShopMVCContext context)
        {
            _context = context;
        }

        // GET: PetFoods
        public async Task<IActionResult> Index()
        {
              return _context.PetFood != null ? 
                          View(await _context.PetFood.ToListAsync()) :
                          Problem("Entity set 'PetShopMVCContext.PetFood'  is null.");
        }

        // GET: PetFoods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PetFood == null)
            {
                return NotFound();
            }

            var petFood = await _context.PetFood
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petFood == null)
            {
                return NotFound();
            }

            return View(petFood);
        }

        // GET: PetFoods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PetFoods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AnimalType,Price,Cost")] PetFood petFood)
        {
            if (ModelState.IsValid)
            {
                _context.Add(petFood);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petFood);
        }

        // GET: PetFoods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PetFood == null)
            {
                return NotFound();
            }

            var petFood = await _context.PetFood.FindAsync(id);
            if (petFood == null)
            {
                return NotFound();
            }
            return View(petFood);
        }

        // POST: PetFoods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AnimalType,Price,Cost")] PetFood petFood)
        {
            if (id != petFood.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petFood);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetFoodExists(petFood.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(petFood);
        }

        // GET: PetFoods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PetFood == null)
            {
                return NotFound();
            }

            var petFood = await _context.PetFood
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petFood == null)
            {
                return NotFound();
            }

            return View(petFood);
        }

        // POST: PetFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PetFood == null)
            {
                return Problem("Entity set 'PetShopMVCContext.PetFood'  is null.");
            }
            var petFood = await _context.PetFood.FindAsync(id);
            if (petFood != null)
            {
                _context.PetFood.Remove(petFood);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetFoodExists(int id)
        {
          return (_context.PetFood?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
