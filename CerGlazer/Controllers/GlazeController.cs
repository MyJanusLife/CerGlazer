using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CerGlazer.Models;

namespace CerGlazer.Controllers
{
    public class GlazesController : Controller
    {

        // GET: GlazeController
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// List of glaze recipes with their details, including ingredients and application methods.
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult GlazeRecipes()
        {
            
            var glazeRecipes = new List<GlazeRecipe>
            {
                new GlazeRecipe
                {
                    Name = "Celadon",
                    Cone = "5",
                    Color = "Green",
                    Ingredients = new List<GlazeMaterial>
                    {
                        new GlazeMaterial { Name = "Feldspar", Amount = 50 },
                        new GlazeMaterial { Name = "Kaolin", Amount = 30 },
                        new GlazeMaterial { Name = "Silica", Amount = 20 }
                    },
                    PreferredApplicationMethod = Models.Enums.ApplicationMethods.Dip,
                    Notes = "A classic green glaze."
                },
                new GlazeRecipe
                {
                    Name = "Shino",
                    Cone = "6",
                    Color = "Orange",
                    Ingredients = new List<GlazeMaterial>
                    {
                        new GlazeMaterial { Name = "Feldspar", Amount = 40 },
                        new GlazeMaterial { Name = "Kaolin", Amount = 40 },
                        new GlazeMaterial { Name = "Iron Oxide", Amount = 20, Notes = "Glaze test using black or red oxide to achieve desired effects." }
                    },
                    PreferredApplicationMethod = Models.Enums.ApplicationMethods.Brush,
                    Notes = "A traditional Japanese glaze."
                }
            };
            return View(glazeRecipes);
        }

        // GET: GlazeController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: GlazeController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GlazeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: GlazeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: GlazeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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
