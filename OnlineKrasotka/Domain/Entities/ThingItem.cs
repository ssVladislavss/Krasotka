using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities
{
    public class ThingItem:EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги")]
        public override string Name { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string ShortDesk { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string LongDesk { get; set; }

        [Display(Name = "Размер")]
        public override string Size { get; set; }

        [Display(Name = "Цена")]
        public override uint Price { get; set; }
    }
}
