using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CerGlazer.Controllers
{
    public class GlazeController : Controller
    {
        // GET: GlazeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GlazeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GlazeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GlazeController/Create
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

        // GET: GlazeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GlazeController/Edit/5
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

        // GET: GlazeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GlazeController/Delete/5
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
