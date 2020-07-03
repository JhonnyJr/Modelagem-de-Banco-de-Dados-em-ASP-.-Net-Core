using Dominio.Cursos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Cursos.Servicos.Interfaces
{
    public interface ICursosServico
    {
        Curso Validar(int codigo);
        Curso Inserir(string nome, int cargahoraria, string ementa, int trilha_id);
        void Deletar(int codigo);
    }
}
