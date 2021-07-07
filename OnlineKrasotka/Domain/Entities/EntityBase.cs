using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => DataAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название(Заголовок)")]
        public virtual string Name { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string ShortDesk { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string LongDesk { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagesPath { get; set; }

        [Display(Name = "Размер")]
        public virtual string Size { get; set; }

        [Display(Name = "Цена")]
        public virtual uint Price { get; set; }

        [Display(Name = "SEO метатег Name")]
        public virtual string MetaName { get; set; }

        [Display(Name = "SEO метатег Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DataAdded { get; set; }
    }
}
