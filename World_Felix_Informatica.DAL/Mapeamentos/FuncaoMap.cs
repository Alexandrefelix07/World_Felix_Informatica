using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using World_Felix_Informatica.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace World_Felix_Informatica.DAL.Mapeamentos
{
    class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);

            builder.HasData(
                new Funcao
                {
                    Id = 1,
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descricao = "usuario master sitema"

                },
                new Funcao
                {
                    Id = 2,
                    Name = "Suporte",
                    NormalizedName = "SUPORTE",
                    Descricao = "usuario suporte sitema"

                }


                );
                
            builder.ToTable("funcoes");
        }
    }
}
