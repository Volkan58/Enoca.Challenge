using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Movietheater : IEntity
    {
        [Key]
        public int CinemaID { get; set; }
        public string Name { get; set; }

    


    }
}
