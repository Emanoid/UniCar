using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniCar.Data;
using UniCar.Models;

namespace UniCar.Controllers
{
    public class WorkHistoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkHistoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.WorkHistory.ToListAsync());
        }

        // GET: WorkHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workHistory = await _context.WorkHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workHistory == null)
            {
                return NotFound();
            }

            return View(workHistory);
        }

        // GET: WorkHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Organization,StartDate,EndDate,IsCurrent,WorkDescription")] WorkHistory workHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workHistory);
        }

        // GET: WorkHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workHistory = await _context.WorkHistory.FindAsync(id);
            if (workHistory == null)
            {
                return NotFound();
            }
            return View(workHistory);
        }

        // POST: WorkHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Organization,StartDate,EndDate,IsCurrent,WorkDescription")] WorkHistory workHistory)
        {
            if (id != workHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkHistoryExists(workHistory.Id))
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
            return View(workHistory);
        }

        // GET: WorkHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workHistory = await _context.WorkHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workHistory == null)
            {
                return NotFound();
            }

            return View(workHistory);
        }

        // POST: WorkHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workHistory = await _context.WorkHistory.FindAsync(id);
            _context.WorkHistory.Remove(workHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkHistoryExists(int id)
        {
            return _context.WorkHistory.Any(e => e.Id == id);
        }
    }
}
