using Dominio.Trilhas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Trilhas.Repositorios
{
    public interface ITrilhasRepositorio
    {
        IQueryable<Trilha> Query();
        Object Inserir(Trilha trilha);
        Trilha Recupera(int codigo);
        void Deletar(Trilha trilha);
    }
}
