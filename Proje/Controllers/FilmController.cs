using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager(new EfFilmDal());

        public IActionResult Index()
        {
            var values = filmManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Addfilm()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Addfilm(Film film)
        {
            filmManager.Add(film);
            return RedirectToAction("Index");
        }
  
        public IActionResult Deletefilm (int id)
        {
            var values = filmManager.GetById(id);
            filmManager.Delete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditFilm(int id)
        {
            var values = filmManager.GetById(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditFilm(Film film)
        {
            filmManager.Update(film);

            return RedirectToAction("Index");
        }

    }
}
