using Bussiness.Abstract;

using Entity.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;
      

        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet("GetListAllFilm")]
        public IActionResult GetList()
        {
            var result = _filmService.GetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("DeleteFilmGet")]
        public IActionResult Delete (int id)
        {
            var result = _filmService.GetById(id);
            _filmService.Delete(result);
            return Ok(id+" Numaralı Id'ye Ait Bilgiler Silindi.");
        }
        [HttpGet("UpdateFilmGet")]
        public IActionResult Update(int id, string name, string genre, string director, int year)
        {
            Film film = new Film()
            {
                Name = name,
                Genre = genre,
                Director = director,
                Year = year

            };
            var result = _filmService.GetById(id);
            _filmService.Update(film);
            return Ok("Güncelleştirme İşlemi Gerçekleşti Güncelleme Id=" + id);
        }
        [HttpGet("CreateFilmGet")]
        public IActionResult Add(string name, string genre, string director, int year,int cinemaId)
        {
            Film film = new Film()
            {
                Name = name,
                Genre = genre,
                Director = director,
                Year = year,
                CinemaId=cinemaId
            };
            _filmService.Add(film);
            return Ok("Girmiş Olduğunuz Parametreler Eklendi");
        }
        [HttpPost("CreateFilmPost")]
        public IActionResult Add(Film film)
        {
            _filmService.Add(film);

             return Ok("Parametreler Eklendi");
        }
        [HttpPost("UpdateFilmPost")]
        public IActionResult Update(Film film)
        {
            _filmService.Update(film);
            return Ok("Güncelleme İşlemi Tamamlandı");
        }
        [HttpPost("DeleteFilmPost")]
        public IActionResult Delete(Film film)
        {
            _filmService.Delete(film);
            return Ok("Film Başarıyla Silindi");
        }

        [HttpGet("Search")]
        public IActionResult Search(string field)
        {
            var result=_filmService.Search(field);
            return Ok(result);
        }
        

    }
}
