using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace World_Felix_Informatica.BLL.Models
{
    public class Usuario : IdentityUser<string>
    {
        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]       
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        public string CPF { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        public DateTime DataNasc { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        public string Foto { get; set; }
        
        public bool PromeiroAcesso { get; set; }
     

    }
}
