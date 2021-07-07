using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities.Order
{
    public class Order
    {
        [BindNever]
        public Guid Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string SurName { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса не менее 15 символов")]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера телефона не менее 10 символов")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина email телефона не менее 15 символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

