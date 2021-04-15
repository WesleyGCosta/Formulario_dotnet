using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AutorViewModel
    {
        [Required(ErrorMessage = "*O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="*O Campo Linkedin é obrigatório")]
        public string Linkedin { get; set; }
    }
}
