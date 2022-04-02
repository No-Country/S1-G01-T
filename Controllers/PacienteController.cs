using DigiLearn.Data;
using DigiLearn.Models;
using DigiLearn.ModelsView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
            var LP = _context.Pacientes.Where(z => z.ProfesionalId.Equals(currentUser.Id) && z.Estado.Equals(true));
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
        //public ActionResult Details(PacienteView model)
        //{
        //    return View(model);
        //}
        // GET: PacienteController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var paci = await _context.Pacientes.Where(z => 
                                z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).FirstOrDefaultAsync();

            if (paci != null)
            {
                PacienteView pacView = new PacienteView();
                pacView.PacienteId = paci.PacienteId;
                pacView.Nombre = paci.Nombre;
                pacView.Apellido = paci.Apellido;
                pacView.Edad = paci.Edad;
                pacView.Diagnostico = paci.Diagnostico;
                pacView.FechaCreacion = paci.FechaCreacion;
                pacView.Estado = paci.Estado;
                //return RedirectToAction("Details",pacView);

                return View(pacView);
            }
            return BadRequest("Paciente no encontrado");
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CrearPaciente(PacienteView model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                if (currentUser == null)
                {
                    return BadRequest();
                }

                Paciente Pac = new Paciente();
                Pac.PacienteId = model.PacienteId;
                Pac.Nombre = model.Nombre;
                Pac.Apellido = model.Apellido;
                Pac.Edad = model.Edad;
                Pac.Diagnostico = model.Diagnostico;
                Pac.FechaCreacion = model.FechaCreacion;
                Pac.Estado = model.Estado;
                Pac.ProfesionalId = currentUser.Id;

                await _context.Pacientes.AddAsync(Pac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var paci = await _context.Pacientes.Where(z => z.ProfesionalId.Equals(currentUser) && z.PacienteId.Equals(id)).FirstOrDefaultAsync();

            if (paci != null)
            {
                PacienteView pacView = new PacienteView();
                pacView.Nombre = paci.Nombre;
                pacView.Apellido = paci.Apellido;
                pacView.Edad = paci.Edad;
                pacView.Diagnostico = paci.Diagnostico;
                pacView.Estado = paci.Estado;
                return View(pacView);
            }
            return BadRequest("Paciente no encontrado");
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditarPaciente(int id, PacienteView model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                if (currentUser == null)
                {
                    return BadRequest();
                }

                Paciente Pac = _context.Pacientes.FirstOrDefault(x =>
                                    x.PacienteId.Equals(model.PacienteId) && x.ProfesionalId.Equals(currentUser));
                Pac.Nombre = model.Nombre;
                Pac.Apellido = model.Apellido;
                Pac.Edad = model.Edad;
                Pac.Diagnostico = model.Diagnostico;
                Pac.Estado = model.Estado;

                _context.Pacientes.Update(Pac);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       
    }
}
