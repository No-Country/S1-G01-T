using DigiLearn.Data;
using DigiLearn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Controllers
{
    public class FrasesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public FrasesController(ApplicationDbContext context, UserManager<IdentityUser> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        // GET: Frases
        public IActionResult Index(int? id)
        {
            ViewData["PacienteId"] = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(DateTime fechaRealizacion, int pacienteId)
        {
            string nombre = "Actividad de Frases";
            Frases frases = new()
            {
                //ActividadId = actividadId,
                FechaRealizacion = fechaRealizacion,
                PacienteId = pacienteId,
                Nombre = nombre
            };

            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                    frases.ProfesionalId = currentUser.Id;
                    if (currentUser == null)
                    {
                        return BadRequest();
                    }
                    _context.Add(frases);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", new { id = pacienteId });
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View(frases);
        }
        //// GET: FrasesController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: FrasesController/Edit/5
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

        //// GET: FrasesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: FrasesController/Delete/5
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

        //private bool FrasesExists(int id)
        //{
        //    return _context.Frases.Any(e => e.ActividadId == id);
        //}
    }
}
