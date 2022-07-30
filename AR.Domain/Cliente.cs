using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Idade { get; set; }
    }
}
