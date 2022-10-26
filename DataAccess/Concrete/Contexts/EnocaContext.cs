using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Contexts
{
    public class EnocaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-A532VLH\SQLEXPRESS;Database=Enoca;Integrated Security=true;");
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Movietheater> Movietheaters { get; set; }
    }
}
