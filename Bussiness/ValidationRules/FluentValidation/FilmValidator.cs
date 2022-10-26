using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class FilmValidator:AbstractValidator<Film>
    {
        public FilmValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name Alanı Boş Geçilemez");
            RuleFor(p => p.Year).GreaterThanOrEqualTo(1900).WithMessage("Girdiğiniz yıl 1900'den Küçük Olamaz!");
            RuleFor(p => p.Year).LessThanOrEqualTo(2100).WithMessage("Girdiğiniz Yıl 2100 Sayısından Büyük Olamaz!");
            RuleFor(p => p.CinemaId).NotEmpty().WithMessage("Sinema Id Alanı Sinema Salonlarını Temsil Etmektedir Sıfır Değerini Alamaz");
            RuleFor(p => p.CinemaId).GreaterThanOrEqualTo(0).WithMessage("Girdiğiniz Değer Sıfır Olamaz");

            RuleFor(p => p.Year).LessThanOrEqualTo(10).WithMessage("Girdiğiniz Sayı Sinema Salonlarını Temsil Ettiği İçin 10 dan büyük Olamaz.");
        }
    }
}
