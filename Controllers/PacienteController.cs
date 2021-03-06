using DigiLearn.Data;
using DigiLearn.Models;
using DigiLearn.ModelsView;
using Microsoft.AspNetCore.Authorization;
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
    
    [Authorize]
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
        [Route("~/")]
        [Route("Paciente")]
        [Route("Paciente/Index/")]
        public async Task<ActionResult> Index()
        {
            List<PacienteView> LisPacientes = new();
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var LP = _context.Pacientes.Where(z => z.ProfesionalId.Equals(currentUser.Id) && z.Estado.Equals(true));
            foreach (var item in LP)
            {
                PacienteView PacV = new();
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
            
            List<ActividadReconocimientoAnimales> LActRAnim = null;
            List<ActividadReconocimientoVocales> LActRVocales = null;
            List<Memory> LActMemory = null;
            List<Sumas> LActSumas = null;
            List<Frases> LActFrases = null;
            List<ActividadRelacionImagenPalabra> LActImgsWords = null;
            List<ActividadesView> All = new();

            LActRAnim = _context.ActividadReconocimientoAnimales.Where
               (z => z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).ToList();
           
            LActRVocales = _context.ActividadReconocimientoVocales.Where
               (z => z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).ToList();

            LActMemory = _context.Memory.Where
               (z => z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).ToList();
                   
            LActSumas = _context.Sumas.Where
               (z => z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).ToList();

            LActFrases = _context.Frases.Where
               (z => z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).ToList();

            LActImgsWords = _context.ActividadRelacionImagenPalabra.Where
               (z => z.ProfesionalId.Equals(currentUser.Id) && z.PacienteId.Equals(id)).ToList();

            foreach (var item in LActRAnim)
            {
                ActividadesView act = new ();
                act.Fecha = item.FechaRealizacion.ToString();
                act.Actividad = item.ActividadId.ToString();
                act.Nombre = item.Nombre;
                All.Add(act);
            }
            foreach (var item in LActRVocales)
            {
                ActividadesView act = new ();
                act.Fecha = item.FechaRealizacion.ToString();
                act.Actividad = item.ActividadId.ToString();
                act.Nombre = item.Nombre;
                All.Add(act);
            }
            foreach (var item in LActMemory)
            {
                ActividadesView act = new ();
                act.Fecha = item.FechaRealizacion.ToString();
                act.Actividad = item.ActividadId.ToString();
                act.Nombre = item.Nombre;
                All.Add(act);
            }
            foreach (var item in LActSumas)
            {
                ActividadesView act = new ();
                act.Fecha = item.FechaRealizacion.ToString();
                act.Actividad = item.ActividadId.ToString();
                act.Nombre = item.Nombre;
                All.Add(act);
            }
            foreach (var item in LActFrases)
            {
                ActividadesView act = new ();
                act.Fecha = item.FechaRealizacion.ToString();
                act.Actividad = item.ActividadId.ToString();
                act.Nombre = item.Nombre;
                All.Add(act);
            }
            foreach (var item in LActImgsWords)
            {
                ActividadesView act = new();
                act.Fecha = item.FechaRealizacion.ToString();
                act.Actividad = item.ActividadId.ToString();
                act.Nombre = item.Nombre;
                All.Add(act);
            }
            ViewBag.actFull = All;

            int cont = 0;
            foreach(var item in All)
            {
                cont++;
                
            }
            if (cont > 0)
            {
                ViewBag.Vacio = 1;
              
            }
            else
            {
                ViewBag.Vacio = null;
            }
          
             if (paci != null)
            {
                PacienteView pacView = new();
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
        public async Task<ActionResult> CrearPaciente(Paciente model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                    if (currentUser == null)
                    {
                        return BadRequest();
                    }
                    Paciente Pac = new();
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
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View("Create", model);
        }

        // GET: PacienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var paci = await _context.Pacientes.Where(z => z.ProfesionalId.Equals(currentUser) && z.PacienteId.Equals(id)).FirstOrDefaultAsync();

            if (paci != null)
            {
                PacienteView pacView = new();
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
