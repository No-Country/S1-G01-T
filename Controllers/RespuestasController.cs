using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiLearn.Controllers
{
    public class RespuestasController : Controller
    {
        // GET: RespuestasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RespuestasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RespuestasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RespuestasController/Create
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

        // GET: RespuestasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RespuestasController/Edit/5
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

        // GET: RespuestasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RespuestasController/Delete/5
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
