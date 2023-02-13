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
    public class TransactionsController : Controller
    {
        private readonly PetShopMVCContext _context;

        public TransactionsController(PetShopMVCContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            var petShopMVCContext = _context.Transaction.Include(t => t.Customer).Include(t => t.Employee).Include(t => t.Pet).Include(t => t.PetFood);
            return View(await petShopMVCContext.ToListAsync());
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.Customer)
                .Include(t => t.Employee)
                .Include(t => t.Pet)
                .Include(t => t.PetFood)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id");
            ViewData["PetId"] = new SelectList(_context.Pet, "Id", "Id");
            ViewData["PetFoodId"] = new SelectList(_context.PetFood, "Id", "Id");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,PetPrice,PetFoodQty,PetFoodPrice,TotalPrice,CustomerId,EmployeeId,PetId,PetFoodId")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", transaction.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id", transaction.EmployeeId);
            ViewData["PetId"] = new SelectList(_context.Pet, "Id", "Id", transaction.PetId);
            ViewData["PetFoodId"] = new SelectList(_context.PetFood, "Id", "Id", transaction.PetFoodId);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", transaction.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id", transaction.EmployeeId);
            ViewData["PetId"] = new SelectList(_context.Pet, "Id", "Id", transaction.PetId);
            ViewData["PetFoodId"] = new SelectList(_context.PetFood, "Id", "Id", transaction.PetFoodId);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,PetPrice,PetFoodQty,PetFoodPrice,TotalPrice,CustomerId,EmployeeId,PetId,PetFoodId")] Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", transaction.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id", transaction.EmployeeId);
            ViewData["PetId"] = new SelectList(_context.Pet, "Id", "Id", transaction.PetId);
            ViewData["PetFoodId"] = new SelectList(_context.PetFood, "Id", "Id", transaction.PetFoodId);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.Customer)
                .Include(t => t.Employee)
                .Include(t => t.Pet)
                .Include(t => t.PetFood)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transaction == null)
            {
                return Problem("Entity set 'PetShopMVCContext.Transaction'  is null.");
            }
            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction != null)
            {
                _context.Transaction.Remove(transaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
          return (_context.Transaction?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
