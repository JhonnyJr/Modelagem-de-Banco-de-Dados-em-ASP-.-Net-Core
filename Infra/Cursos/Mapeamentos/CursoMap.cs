using Dominio.Cursos.Entidades;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Cursos.Mapeamentos
{
    public class CursoMap : ClassMap<Curso>
    {
        public CursoMap()
        {
            Schema("interdisciplinar");
            Table("Curso");
            Id(X => X.Id).Column("ID");
            Map(X => X.Nome).Column("NOME");
            Map(X => X.Ementa).Column("EMENTA");
            Map(X => X.CargaHoraria).Column("CARGAHORARIA");
            References(X => X.Trilha).Column("TRILHA_ID");
        }
    }
}
