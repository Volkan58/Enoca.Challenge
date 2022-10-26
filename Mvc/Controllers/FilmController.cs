using Bussiness.Concrete;
using Bussiness.ValidationRules.FluentValidation;
using Core.Aspect.ValidationAspect;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager(new EfFilmDal());
        public IActionResult Index()
        {

            var values = filmManager.GetList();
            
            return View(values);
        }

        [ValidationAspect(typeof(FilmValidator))]
        [HttpGet]
        public IActionResult Addfilm()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Addfilm(Film film)
        {
            if (!ModelState.IsValid)
            {
                return View("Addfilm");
            }
            filmManager.Add(film);
            return RedirectToAction("Index");
        }
  

        public IActionResult Deletefilm(Film film)
        {
            var values = filmManager.GetById(film.Id);
            filmManager.Delete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult FilmDetail(int id)
        {
            var values = filmManager.GetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult FilmDetail(Film film)
        {
            filmManager.Update(film);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Search(string p)
        {
            filmManager.Search(p);
            return RedirectToAction("Index");
        }
    }
    
    
}
