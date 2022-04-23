using Microsoft.AspNetCore.Mvc;
using System;
using DigiLearn.Data;
using DigiLearn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Controllers
{
    [Authorize]
    public class ActividadRelacionImagenPalabraController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ActividadRelacionImagenPalabraController(ApplicationDbContext context, UserManager<IdentityUser> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        // GET: ActividadRelacionImagenPalabraController
        public IActionResult Index(int? id)
        {
            ViewData["PacienteId"] = id;
            return View();
        }

        // ESTO DEBERÍA GUARDARSE DIRECTAMENTE AL SELECCIONAR LA ACTIVIDAD EN LA VISTA DE ACTIVIDADES
        // POST: ActividadReconocimientoAnimales/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(DateTime fechaRealizacion, int pacienteId)              //int actividadId
        {
            string nombre = "Relacion Imagen con Palabra";
            ActividadRelacionImagenPalabra actividadRelacionImagenPalabra = new()
            {
                //ActividadId = actividadId,
                // ¿Nivel de dificultad de la actividad?
                FechaRealizacion = fechaRealizacion,
                PacienteId = pacienteId,
                Nombre = nombre
            };

            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                    actividadRelacionImagenPalabra.ProfesionalId = currentUser.Id;
                    if (currentUser == null)
                    {
                        return BadRequest();
                    }
                    _context.Add(actividadRelacionImagenPalabra);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", new { id = pacienteId });
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View(actividadRelacionImagenPalabra);
        }

        // GET: ActividadRelacionImagenPalabraController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: ActividadRelacionImagenPalabraController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: ActividadRelacionImagenPalabraController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ActividadId,FechaRealizado,PacienteId,ProfesionalId")] ActividadRelacionImagenPalabra actividadRelacionImagenPalabra)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(actividadRelacionImagenPalabra);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(actividadRelacionImagenPalabra);
        //}

        // GET: ActividadRelacionImagenPalabraController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: ActividadRelacionImagenPalabraController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ActividadRelacionImagenPalabraController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: ActividadRelacionImagenPalabraController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //private bool ActividadRelacionImagenPalabraExists(int id)
        //{
        //    return _context.ActividadRelacionImagenPalabra.Any(e => e.ActividadId == id);
        //}

    }
}
