using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProdutoViewModel
    {
        [Required(ErrorMessage = "*O campo Descrição é obrigatório")]
        [StringLength(100, ErrorMessage = "A descrição precisa ter no mínimo 5 letras", MinimumLength = 5)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "*O campo Valor é obrigatório")]
        public string Valor { get; set; }
        [Required(ErrorMessage = "*O campo Tipo é obrigatório")]
        public string Tipo { get; set; }
    }
}
