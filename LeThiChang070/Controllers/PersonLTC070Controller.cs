using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeThiChang070.Data;
using LeThiChang070.Models;

namespace LeThiChang070.Controllers
{
    public class PersonLTC070Controller : Controller
    {
        private readonly LeThiChang070Context _context;

        public PersonLTC070Controller(LeThiChang070Context context)
        {
            _context = context;
        }

        // GET: PersonLTC070
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonLTC070.ToListAsync());
        }

        // GET: PersonLTC070/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTC070 = await _context.PersonLTC070
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personLTC070 == null)
            {
                return NotFound();
            }

            return View(personLTC070);
        }

        // GET: PersonLTC070/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonLTC070/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonLTC070 personLTC070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personLTC070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personLTC070);
        }

        // GET: PersonLTC070/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTC070 = await _context.PersonLTC070.FindAsync(id);
            if (personLTC070 == null)
            {
                return NotFound();
            }
            return View(personLTC070);
        }

        // POST: PersonLTC070/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,PersonName")] PersonLTC070 personLTC070)
        {
            if (id != personLTC070.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personLTC070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonLTC070Exists(personLTC070.PersonID))
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
            return View(personLTC070);
        }

        // GET: PersonLTC070/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTC070 = await _context.PersonLTC070
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personLTC070 == null)
            {
                return NotFound();
            }

            return View(personLTC070);
        }

        // POST: PersonLTC070/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personLTC070 = await _context.PersonLTC070.FindAsync(id);
            _context.PersonLTC070.Remove(personLTC070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonLTC070Exists(string id)
        {
            return _context.PersonLTC070.Any(e => e.PersonID == id);
        }
    }
}
