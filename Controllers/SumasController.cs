using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiLearn.Data;
using DigiLearn.Models;
using Microsoft.AspNetCore.Authorization;

namespace DigiLearn.Controllers
{
    [Authorize]
    public class SumasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SumasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sumas
        public async Task<IActionResult> Index(int? id)
        {
            ViewData["PacienteId"] = id;
            return View(await _context.Sumas.ToListAsync());
        }


        //POST: Sumas/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save([Bind("ActividadId,FechaRealizacion,ProfesionalId,PacienteId")] Sumas sumas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sumas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sumas);
        }

        // GET: Sumas/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sumas = await _context.Sumas
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (sumas == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sumas);
        //}

        // GET: Sumas/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Sumas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ActividadId,FechaRealizacion,ProfesionalId,PacienteId")] Sumas sumas)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(sumas);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(sumas);
        //}

        // GET: Sumas/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sumas = await _context.Sumas.FindAsync(id);
        //    if (sumas == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(sumas);
        //}

        // POST: Sumas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ActividadId,FechaRealizacion,ProfesionalId,PacienteId")] Sumas sumas)
        //{
        //    if (id != sumas.ActividadId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(sumas);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SumasExists(sumas.ActividadId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(sumas);
        //}

        // GET: Sumas/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sumas = await _context.Sumas
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (sumas == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sumas);
        //}

        // POST: Sumas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var sumas = await _context.Sumas.FindAsync(id);
        //    _context.Sumas.Remove(sumas);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SumasExists(int id)
        {
            return _context.Sumas.Any(e => e.ActividadId == id);
        }
    }
}
