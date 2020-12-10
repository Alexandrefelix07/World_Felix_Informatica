using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using World_Felix_Informatica.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace World_Felix_Informatica.DAL.Mapeamentos
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.CPF).IsRequired().HasMaxLength(11);
            builder.Property(u => u.DataNasc).IsRequired();
            builder.Property(u => u.Foto).IsRequired();
            builder.Property(u => u.E_mail).IsRequired();
            builder.Property(u => u.PromeiroAcesso).IsRequired();

            builder.ToTable("Usuarios");
        }
    }
}
