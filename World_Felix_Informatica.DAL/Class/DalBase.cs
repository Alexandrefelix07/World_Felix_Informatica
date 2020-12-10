using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using World_Felix_Informatica.BLL.Models;
using World_Felix_Informatica.DAL.Mapeamentos;

namespace World_Felix_Informatica.DAL.Class
{
    public class DalBase : IdentityDbContext<Usuario,Funcao,int>
    {
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DalBase(DbContextOptions<DalBase> opcoes) : base(opcoes)

        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new UsuarioMap());

        }
    }
}
