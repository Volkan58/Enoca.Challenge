using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFilmDal : EntityRepositoryBase<Film, EnocaContext>, IFilmDal
    {
       

        public IEnumerable<Film> Search(string name)
        {
         
            using (var context = new EnocaContext())
            {
                IQueryable<Film> query = context.Films;
                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(x => x.Name.Contains(name) || x.Genre.Contains(name) || x.Director.Contains(name) || x.Year.ToString().Contains(name) ||x.CinemaId.ToString().Contains(name));
                }
                return query.ToList();
            }
        }
        }
    }

