using DigiLearn.Data;
using DigiLearn.ModelsView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Controllers
{
    public class PacienteController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public PacienteController(ApplicationDbContext context, UserManager<IdentityUser> UserManager) 
        {
            _context = context;
            _userManager = UserManager;
        }
        // GET: PacienteController
        public async Task<ActionResult> Index()
        {
            List<PacienteView> LisPacientes = new List<PacienteView>();
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var LP = _context.Pacientes.Where(z=> z.ProfesionalId.Equals(currentUser) && z.Estado.Equals(true));
            foreach (var item in LP)
            {
                PacienteView PacV = new PacienteView();
                PacV.PacienteId = item.PacienteId;
                PacV.Nombre = item.Nombre;
                PacV.Apellido = item.Apellido;
                PacV.Edad = item.Edad;
                PacV.Diagnostico = item.Diagnostico;
                PacV.FechaCreacion = item.FechaCreacion;
                PacV.Estado = item.Estado;
                LisPacientes.Add(PacV);
            }
            return View(LisPacientes);
        }

        // GET: PacienteController/Details/5
        public ActionResult DetallePaciente(int id)
        {

            return View();
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PacienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
