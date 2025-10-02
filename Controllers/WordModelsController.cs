using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wordle.Data;
using Wordle.Models;

namespace Wordle.Controllers
{
    public class WordModelsController : Controller
    {
        private readonly WordleContext _context;

        public WordModelsController(WordleContext context)
        {
            _context = context;
        }

        // GET: WordModels
        public async Task<IActionResult> Index(int? searchLength)
        {
            var words = from w in _context.WordModel
                        select w;

            if (searchLength.HasValue)
            {
                words = words.Where(w => w.Length == searchLength.Value);
            }

            return View(await words.ToListAsync());
        }

        // GET: WordModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordModel = await _context.WordModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wordModel == null)
            {
                return NotFound();
            }

            return View(wordModel);
        }

        // GET: WordModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WordModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Letters,Length,Created")] WordModel wordModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wordModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wordModel);
        }

        // GET: WordModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordModel = await _context.WordModel.FindAsync(id);
            if (wordModel == null)
            {
                return NotFound();
            }
            return View(wordModel);
        }

        // POST: WordModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Letters,Length,Created")] WordModel wordModel)
        {
            if (id != wordModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wordModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordModelExists(wordModel.Id))
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
            return View(wordModel);
        }

        // GET: WordModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordModel = await _context.WordModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wordModel == null)
            {
                return NotFound();
            }

            return View(wordModel);
        }

        // POST: WordModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wordModel = await _context.WordModel.FindAsync(id);
            if (wordModel != null)
            {
                _context.WordModel.Remove(wordModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> WordleGame()
        {
            var randomWord = await Word();
            return View(randomWord);
        }

        private bool WordModelExists(int id)
        {
            return _context.WordModel.Any(e => e.Id == id);
        }

        public async Task<WordModel?> Word()
        {
            // Get a random word from the database
            return await _context.WordModel
                .OrderBy(w => Guid.NewGuid())
                .FirstOrDefaultAsync();
        }
    }
}
