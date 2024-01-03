using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaCroute.Data;
using LaCroute.Models;

namespace LaCroute
{
    public class AdminTypeModelController : Controller
    {
        private readonly LaCrouteContext _context;

        public AdminTypeModelController(LaCrouteContext context)
        {
            _context = context;
        }

        // GET: AdminTypeModel
        public async Task<IActionResult> Index()
        {
            return View(await _context.Type.ToListAsync());
        }

        // GET: AdminTypeModel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeModel = await _context.Type
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeModel == null)
            {
                return NotFound();
            }

            return View(typeModel);
        }

        // GET: AdminTypeModel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminTypeModel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Created_at,Updated_at")] TypeModel typeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeModel);
        }

        // GET: AdminTypeModel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeModel = await _context.Type.FindAsync(id);
            if (typeModel == null)
            {
                return NotFound();
            }
            return View(typeModel);
        }

        // POST: AdminTypeModel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Created_at,Updated_at")] TypeModel typeModel)
        {
            if (id != typeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeModelExists(typeModel.Id))
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
            return View(typeModel);
        }

        // GET: AdminTypeModel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeModel = await _context.Type
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeModel == null)
            {
                return NotFound();
            }

            return View(typeModel);
        }

        // POST: AdminTypeModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeModel = await _context.Type.FindAsync(id);
            if (typeModel != null)
            {
                _context.Type.Remove(typeModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeModelExists(int id)
        {
            return _context.Type.Any(e => e.Id == id);
        }
    }
}