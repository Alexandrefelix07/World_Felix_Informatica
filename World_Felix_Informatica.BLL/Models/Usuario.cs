using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace World_Felix_Informatica.BLL.Models
{
    public class Usuario :IdentityUser<int>
    {
        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        [MaxLength(60,ErrorMessage = "Este Campo {0} Deve Conter entre 10 e 80 caracteres")]
        [MinLength(10, ErrorMessage = "Este Campo {0} Deve Conter entre 10 e 80 caracteres")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        public DateTime DataNasc { get; set; }
        
        public string Foto { get; set; }

        [Required(ErrorMessage = "O Campo {0} e Obrigatorio")]
        public string E_mail { get; set; }

        public bool PromeiroAcesso { get; set; }
     
        public virtual ICollection<Funcao> TipoUsuario { get; set; }
    }
}
