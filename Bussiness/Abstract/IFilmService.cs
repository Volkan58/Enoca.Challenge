
using Entity.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IFilmService
    {
       List<Film> GetList();
        void Add(Film film);
        void Update(Film film);
        void Delete(Film film);
        Film GetById(int id);
        IEnumerable<Film> Search(string name);

    }
}
