using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CustomerProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: CustomerProducts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CustomerProduct.Include(c => c.customer).Include(c => c.product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerProduct = await _context.CustomerProduct
                .Include(c => c.customer)
                .Include(c => c.product)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customerProduct == null)
            {
                return NotFound();
            }

            return View(customerProduct);
        }

        // GET: CustomerProducts/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id");
           // Product p = new Product();
            string s= ViewData["Productid"].ToString();
           // float price = p.getPrice(int.Parse(s));

            ViewData["Price"] = s;
            return View();
        }

        // POST: CustomerProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("basicId,CustomerId,ProductId,Price,Order_date")] CustomerProduct customerProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", customerProduct.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", customerProduct.ProductId);
            return View(customerProduct);
        }

        // GET: CustomerProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerProduct = await _context.CustomerProduct.FindAsync(id);
            if (customerProduct == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", customerProduct.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", customerProduct.ProductId);
            return View(customerProduct);
        }

        // POST: CustomerProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("basicId,CustomerId,ProductId,Price,Order_date")] CustomerProduct customerProduct)
        {
            if (id != customerProduct.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerProductExists(customerProduct.CustomerId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", customerProduct.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", customerProduct.ProductId);
            return View(customerProduct);
        }

        // GET: CustomerProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerProduct = await _context.CustomerProduct
                .Include(c => c.customer)
                .Include(c => c.product)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customerProduct == null)
            {
                return NotFound();
            }

            return View(customerProduct);
        }

        // POST: CustomerProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerProduct = await _context.CustomerProduct.FindAsync(id);
            _context.CustomerProduct.Remove(customerProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerProductExists(int id)
        {
            return _context.CustomerProduct.Any(e => e.CustomerId == id);
        }
    }
}
