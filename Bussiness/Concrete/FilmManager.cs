using Bussiness.Abstract;
using Bussiness.ValidationRules.FluentValidation;
using Core.Aspect.ValidationAspect;
using DataAccess.Abstract;
using Entity.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class FilmManager : IFilmService
    {
        private readonly IFilmDal _filmdal;

        public FilmManager(IFilmDal filmdal)
        {
            _filmdal = filmdal;
        }

        [ValidationAspect(typeof(FilmValidator))]
        public void Add(Film film)
        {
            _filmdal.Add(film);
        }

        public void Delete(Film film)
        {
            _filmdal.Delete(film);
        }

        public Film GetById(int id)
        {
            return _filmdal.Get(x => x.Id == id);
        }

        public List<Film> GetList()
        {
            return _filmdal.GetList();
        }

        public IEnumerable<Film> Search(string name)
        {
           return _filmdal.Search(name).ToList();
        }

        public void Update(Film film)
        {
            _filmdal.Update(film);
        }
    }
}
