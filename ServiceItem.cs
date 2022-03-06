using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLog.Domain.Entities
{
    public class ServiceItem: EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги")] public override string Title { get; set; }
        [Display(Name = "Краткое описание усдуги")] public override string Subtitle { get; set; }
        [Display(Name = "Полное описание услуги")] public override string Text { get; set; }
    }
}
