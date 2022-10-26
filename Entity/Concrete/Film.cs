using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Film:IEntity
    {
        [ForeignKey("Movietheater")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Film Adı Boş Geçilemez")]
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        [Range(1899,2101, ErrorMessage ="Film yılı 1900(dahil) 2100(dahil) arasında olabilir.")]
        public int Year { get; set; }
        [Range(0,10,ErrorMessage = "Sinema Salon Sayısını Temsil ettiği için boş geçilemez ve 1-10 (dahil)olmalıdır")]
        public int CinemaId { get; set; }
        


    }
}
