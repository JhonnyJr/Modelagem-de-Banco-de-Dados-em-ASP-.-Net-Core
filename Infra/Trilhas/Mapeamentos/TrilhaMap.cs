using Dominio.Trilhas.Entidades;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Trilhas.Mapeamentos
{
    public class TrilhaMap : ClassMap<Trilha>
    {
        public TrilhaMap()
        {
            Schema("interdisciplinar");
            Table("Trilha");
            Id(X => X.Id).Column("ID");
            Map(X => X.Nome).Column("NOME");
            Map(X => X.Datacriacao).Column("DATACRIACAO");
            HasMany(X => X.cursos).KeyColumn("TRILHA_ID");
        }
    }
}
