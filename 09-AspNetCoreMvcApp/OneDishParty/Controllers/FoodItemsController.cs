using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneDishParty.Data;
using OneDishParty.Models;

namespace OneDishParty.Controllers
{
    public class FoodItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoodItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: FoodItems
        public async Task<IActionResult> Index()
        {
            var items = await _context.FoodItems.ToListAsync();
            return View(items);
        }

        //Get: FoodItems/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: FodItem
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FoodItem foodItem)
        {
            if(!ModelState.IsValid) return  View(foodItem);
            _context.Add(foodItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Get: FoodItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null) return NotFound();
            var foodItem = await _context.FoodItems.SingleOrDefaultAsync(m => m.Id == id);
            if(foodItem == null) return NotFound();
            return View(foodItem);
        }

        //POST: FoodItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, FoodItem foodItem)
        {
            if(Id != foodItem.Id) return NotFound();
            if (!ModelState.IsValid) return View(foodItem);
            try
            {
                _context.Update(foodItem);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                //item deleted by someone else
                if(!FoodItemExists(foodItem.Id)) return NotFound();
                //some thing went wrong so throw the exception. Usually there is some sort of
                //logging mechanism put in place. The logging will pick it up, capture and then
                //redirect to the error page.
                throw;
            }
            //good
            return RedirectToAction(nameof(Index));
        }

        //Get: FoodItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null) return NotFound();
            var foodItem = await _context.FoodItems.SingleOrDefaultAsync(m => m.Id == id);
            if(foodItem == null) return NotFound();
            return View(foodItem);
        }

        //POST: FoodItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodItem = await _context.FoodItems.SingleOrDefaultAsync(m => m.Id == id);
            _context.FoodItems.Remove(foodItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //helper method to check if the food item exists
        private bool FoodItemExists(int id)
        {
            return _context.FoodItems.Any(e => e.Id == id);
        }
    }
}