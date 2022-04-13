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
using Microsoft.AspNetCore.Identity;

namespace DigiLearn.Controllers
{
    [Authorize]
    public class MemoryController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public MemoryController(ApplicationDbContext context, UserManager<IdentityUser> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        // GET: Memory
        public async Task<IActionResult> Index()
        {
            return View(await _context.Memory.ToListAsync());
        }

        //POST: Memory/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save([Bind("ActividadId,FechaRealizacion,ProfesionalId,PacienteId")] Memory memory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memory);  
            /*Aca redireccionar a la vista donde asigna tareas sin PARAMETRO
*/
        }



        // GET: Memory/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var memory = await _context.Memory
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (memory == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(memory);
        //}

        // GET: Memory/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Memory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ActividadId,FechaRealizacion,ProfesionalId,PacienteId")] Memory memory)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(memory);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(memory);
        //}


        // GET: Memory/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var memory = await _context.Memory.FindAsync(id);
        //    if (memory == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(memory);
        //}

        // POST: Memory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ActividadId,FechaRealizacion,ProfesionalId,PacienteId")] Memory memory)
        //{
        //    if (id != memory.ActividadId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(memory);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!MemoryExists(memory.ActividadId))
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
        //    return View(memory);
        //}

        // GET: Memory/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var memory = await _context.Memory
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (memory == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(memory);
        //}

        // POST: Memory/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var memory = await _context.Memory.FindAsync(id);
        //    _context.Memory.Remove(memory);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool MemoryExists(int id)
        {
            return _context.Memory.Any(e => e.ActividadId == id);
        }
    }
}
