using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_MVC.Models;
namespace Basic_MVC.Controllers
{
    public class PokemonController : Controller
    {
        List<IPokemon> poke;

        public PokemonController()
        {
            poke = new List<IPokemon>()
            {
                new Squirtle(),
                new Charmander()
            };
            var hostName = string.Format("http://{0}.azurewebsites.net", Environment.ExpandEnvironmentVariables("%WEBSITE_SITE_NAME%"));
        }

        // GET: PokemonController
        public ActionResult Index()
        {
            return View(poke);
        }

        // GET: PokemonController/Details/5
        public ActionResult Details(string Name)
        {
            return View(poke.Where(n=>n.Name==Name).FirstOrDefault());
        }

        // GET: PokemonController/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: PokemonController/Create
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

        // GET: PokemonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(poke[id]);
        }

        // POST: PokemonController/Edit/5
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

        // GET: PokemonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PokemonController/Delete/5
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
