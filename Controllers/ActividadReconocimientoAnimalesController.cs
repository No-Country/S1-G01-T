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
    public class ActividadReconocimientoAnimalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActividadReconocimientoAnimalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ActividadReconocimientoAnimales
        public IActionResult Index()
        {
            return View();
        }

        // ESTO DEBERÍA GUARDARSE DIRECTAMENTE AL SELECCIONAR LA ACTIVIDAD EN LA VISTA DE ACTIVIDADES
        // POST: ActividadReconocimientoAnimales/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save([Bind("ActividadId,FechaRealizado,PacienteId,ProfesionalId")] ActividadReconocimientoAnimales actividadReconocimientoAnimales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividadReconocimientoAnimales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actividadReconocimientoAnimales);    // ACÁ HAY QUE REDIRECCIONAR A LA VISTA DONDE SE SELECCIONAN LAS ACTIVIDADES y SIN el parámetro.
        }

        // GET: ActividadReconocimientoAnimales/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actividadReconocimientoAnimales = await _context.ActividadReconocimientoAnimales
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (actividadReconocimientoAnimales == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actividadReconocimientoAnimales);
        //}

        // GET: ActividadReconocimientoAnimales/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: ActividadReconocimientoAnimales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActividadId,FechaRealizado,PacienteId,ProfesionalId")] ActividadReconocimientoAnimales actividadReconocimientoAnimales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividadReconocimientoAnimales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actividadReconocimientoAnimales);
        }

        // GET: ActividadReconocimientoAnimales/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actividadReconocimientoAnimales = await _context.ActividadReconocimientoAnimales.FindAsync(id);
        //    if (actividadReconocimientoAnimales == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(actividadReconocimientoAnimales);
        //}

        // POST: ActividadReconocimientoAnimales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ActividadId,FechaRealizado,PacienteId,ProfesionalId")] ActividadReconocimientoAnimales actividadReconocimientoAnimales)
        //{
        //    if (id != actividadReconocimientoAnimales.ActividadId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(actividadReconocimientoAnimales);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ActividadReconocimientoAnimalesExists(actividadReconocimientoAnimales.ActividadId))
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
        //    return View(actividadReconocimientoAnimales);
        //}

        // GET: ActividadReconocimientoAnimales/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actividadReconocimientoAnimales = await _context.ActividadReconocimientoAnimales
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (actividadReconocimientoAnimales == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actividadReconocimientoAnimales);
        //}

        // POST: ActividadReconocimientoAnimales/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var actividadReconocimientoAnimales = await _context.ActividadReconocimientoAnimales.FindAsync(id);
        //    _context.ActividadReconocimientoAnimales.Remove(actividadReconocimientoAnimales);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ActividadReconocimientoAnimalesExists(int id)
        {
            return _context.ActividadReconocimientoAnimales.Any(e => e.ActividadId == id);
        }
    }
}
