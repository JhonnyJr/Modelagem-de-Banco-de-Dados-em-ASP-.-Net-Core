using Dominio.Cursos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Cursos.Repositorios
{
    public interface ICursosRepositorio
    {
        IQueryable<Curso> Query();
        int Inserir(Curso curso);
        Curso Recupera(int codigo);
        void Deletar(Curso curso);
    }
}
