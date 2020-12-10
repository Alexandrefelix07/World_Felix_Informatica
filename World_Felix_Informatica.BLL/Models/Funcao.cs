using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace World_Felix_Informatica.BLL.Models
{
    public class Funcao : IdentityRole<int>
    {
        public string Descricao { get; set; }
    }
}
