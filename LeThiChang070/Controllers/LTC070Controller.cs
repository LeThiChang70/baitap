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
    public class LTC070Controller : Controller
    {
        private readonly LeThiChang070Context _context;

        public LTC070Controller(LeThiChang070Context context)
        {
            _context = context;
        }

        // GET: LTC070
        public async Task<IActionResult> Index()
        {
            return View(await _context.LTC070.ToListAsync());
        }

        // GET: LTC070/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTC070 = await _context.LTC070
                .FirstOrDefaultAsync(m => m.LTCID == id);
            if (lTC070 == null)
            {
                return NotFound();
            }

            return View(lTC070);
        }

        // GET: LTC070/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LTC070/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LTCID,LTCName,LTCGender")] LTC070 lTC070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lTC070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lTC070);
        }

        // GET: LTC070/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTC070 = await _context.LTC070.FindAsync(id);
            if (lTC070 == null)
            {
                return NotFound();
            }
            return View(lTC070);
        }

        // POST: LTC070/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LTCID,LTCName,LTCGender")] LTC070 lTC070)
        {
            if (id != lTC070.LTCID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lTC070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LTC070Exists(lTC070.LTCID))
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
            return View(lTC070);
        }

        // GET: LTC070/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTC070 = await _context.LTC070
                .FirstOrDefaultAsync(m => m.LTCID == id);
            if (lTC070 == null)
            {
                return NotFound();
            }

            return View(lTC070);
        }

        // POST: LTC070/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lTC070 = await _context.LTC070.FindAsync(id);
            _context.LTC070.Remove(lTC070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LTC070Exists(string id)
        {
            return _context.LTC070.Any(e => e.LTCID == id);
        }
    }
}
