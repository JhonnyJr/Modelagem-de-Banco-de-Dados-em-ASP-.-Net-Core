using Dominio.Cursos.Entidades;
using Dominio.Trilhas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Trilhas.Servicos.Interfaces
{
    public interface ITrilhasServico
    {
        Trilha Validar(int codigo);
        Trilha Inserir(string nome);
        void Deletar(int codigo);
    }
}
