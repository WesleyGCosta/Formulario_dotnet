using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ConteudoViewModel
    {
        [Required(ErrorMessage = "*O Campo Título é obrigatório")]
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "*O Campo Data de Cadastro é obrigatório")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataDoCadastro { get; set; }
        [Required(ErrorMessage = "*O Campo Texto é obrigatório")]
        public string Texto { get; set; }
        [Required(ErrorMessage = "*O Campo Link é obrigatório")]
        public string Link { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
