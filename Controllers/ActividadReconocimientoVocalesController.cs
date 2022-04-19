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
    public class ActividadReconocimientoVocalesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ActividadReconocimientoVocalesController(ApplicationDbContext context, UserManager<IdentityUser> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        // GET: ActividadReconocimientoAnimales
        public IActionResult Index(int? id)
        {
            ViewData["PacienteId"] = id;
            return View();
        }

        // ESTO DEBERÍA GUARDARSE DIRECTAMENTE AL SELECCIONAR LA ACTIVIDAD EN LA VISTA DE ACTIVIDADES
        // POST: ActividadReconocimientoAnimales/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(DateTime fechaRealizacion, int pacienteId)
        {
            ActividadReconocimientoVocales actividadReconocimientoVocales = new()
            {
                //ActividadId = actividadId,
                // ¿Nivel de dificultad de la actividad?
                FechaRealizacion = fechaRealizacion,
                PacienteId = pacienteId
            };

            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                    actividadReconocimientoVocales.ProfesionalId = currentUser.Id;
                    if (currentUser == null)
                    {
                        return BadRequest();
                    }
                    _context.Add(actividadReconocimientoVocales);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", new { id = pacienteId });
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }   
            }
            return View(actividadReconocimientoVocales);    // ACÁ HAY QUE REDIRECCIONAR A LA VISTA DONDE SE SELECCIONAN LAS ACTIVIDADES y SIN el parámetro.
        }

        // GET: ActividadReconocimientoVocales/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actividadReconocimientoVocales = await _context.ActividadReconocimientoVocales
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (actividadReconocimientoAnimales == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actividadReconocimientoVocales);
        //}

        // GET: ActividadReconocimientoVocales/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: ActividadReconocimientoVocales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActividadId,FechaRealizado,PacienteId,ProfesionalId")] ActividadReconocimientoVocales actividadReconocimientoVocales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividadReconocimientoVocales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actividadReconocimientoVocales);
        }

        // GET: ActividadReconocimientoVocales/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actividadReconocimientoVocales = await _context.ActividadReconocimientoVocales.FindAsync(id);
        //    if (actividadReconocimientoVocales == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(actividadReconocimientoVocales);
        //}

        // POST: ActividadReconocimientoVocales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ActividadId,FechaRealizado,PacienteId,ProfesionalId")] ActividadReconocimientoVocales actividadReconocimientoVocales)
        //{
        //    if (id != actividadReconocimientoVocales.ActividadId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(actividadReconocimientoVocales);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ActividadReconocimientoVocalesExists(actividadReconocimientoVocales.ActividadId))
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
        //    return View(actividadReconocimientoVocales);
        //}

        // GET: ActividadReconocimientoVocales/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actividadReconocimientoVocales = await _context.ActividadReconocimientoVocales
        //        .FirstOrDefaultAsync(m => m.ActividadId == id);
        //    if (actividadReconocimientoVocales == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actividadReconocimientoVocales);
        //}

        // POST: ActividadReconocimientoVocales/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var actividadReconocimientoVocales = await _context.ActividadReconocimientoVocales.FindAsync(id);
        //    _context.ActividadReconocimientoVocales.Remove(actividadReconocimientoVocales);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ActividadReconocimientoVocalesExists(int id)
        {
            return _context.ActividadReconocimientoVocales.Any(e => e.ActividadId == id);
        }
    }
}