using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities
{
    public class TextField:EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы(заголовок)")]
        public override string Name { get; set; } = "Информационная страница";

        [Display(Name = "Содержание страницы")]
        public override string LongDesk { get; set; } = "Содержание заполняется администратором";
    }
}
