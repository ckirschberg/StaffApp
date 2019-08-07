using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StaffApp.Models;

namespace StaffApp.Controllers
{
    public class StaffController : Controller
    {
        private readonly StaffAppContext _context;

        public StaffController(StaffAppContext context)
        {
            _context = context;
        }

        // GET: Staff
        public async Task<IActionResult> Index()
        {
            return View(await _context.StaffEntities.ToListAsync());
        }

        // GET: Staff/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffEntity = await _context.StaffEntities
                .FirstOrDefaultAsync(m => m.StaffEntityId == id);
            if (staffEntity == null)
            {
                return NotFound();
            }

            return View(staffEntity);
        }

        // GET: Staff/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffEntityId,Firstname,Lastname,Email")] StaffEntity staffEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staffEntity);
        }

        // GET: Staff/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffEntity = await _context.StaffEntities.FindAsync(id);
            if (staffEntity == null)
            {
                return NotFound();
            }
            return View(staffEntity);
        }

        // POST: Staff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffEntityId,Firstname,Lastname,Email")] StaffEntity staffEntity)
        {
            if (id != staffEntity.StaffEntityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffEntityExists(staffEntity.StaffEntityId))
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
            return View(staffEntity);
        }

        // GET: Staff/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffEntity = await _context.StaffEntities
                .FirstOrDefaultAsync(m => m.StaffEntityId == id);
            if (staffEntity == null)
            {
                return NotFound();
            }

            return View(staffEntity);
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staffEntity = await _context.StaffEntities.FindAsync(id);
            _context.StaffEntities.Remove(staffEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffEntityExists(int id)
        {
            return _context.StaffEntities.Any(e => e.StaffEntityId == id);
        }
    }
}
