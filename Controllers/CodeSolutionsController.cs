using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectEuler.Models;

namespace ProjectEuler.Controllers
{
    public class CodeSolutionsController : Controller
    {
        private readonly CodeSolutionContext _context;

        public CodeSolutionsController(CodeSolutionContext context)
        {
            _context = context;
        }

        // GET: CodeSolutions
        public async Task<IActionResult> Index()
        {
            return View(await _context.CodeSolution.ToListAsync());
        }

        // GET: CodeSolutions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codeSolution = await _context.CodeSolution
                .FirstOrDefaultAsync(m => m.Id == id);
            if (codeSolution == null)
            {
                return NotFound();
            }

            return View(codeSolution);
        }

        // GET: CodeSolutions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CodeSolutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Solution,Problem,ProjectEulerLink")] CodeSolution codeSolution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(codeSolution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(codeSolution);
        }

        // GET: CodeSolutions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codeSolution = await _context.CodeSolution.FindAsync(id);
            if (codeSolution == null)
            {
                return NotFound();
            }
            return View(codeSolution);
        }

        // POST: CodeSolutions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Solution,Problem,ProjectEulerLink")] CodeSolution codeSolution)
        {
            if (id != codeSolution.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(codeSolution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CodeSolutionExists(codeSolution.Id))
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
            return View(codeSolution);
        }

        // GET: CodeSolutions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codeSolution = await _context.CodeSolution
                .FirstOrDefaultAsync(m => m.Id == id);
            if (codeSolution == null)
            {
                return NotFound();
            }

            return View(codeSolution);
        }

        // POST: CodeSolutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var codeSolution = await _context.CodeSolution.FindAsync(id);
            _context.CodeSolution.Remove(codeSolution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CodeSolutionExists(int id)
        {
            return _context.CodeSolution.Any(e => e.Id == id);
        }
    }
}
