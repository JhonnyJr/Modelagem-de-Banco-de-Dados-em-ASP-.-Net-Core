using DataTransfer.Cursos.Requests;
using DataTransfer.Cursos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Cursos.Servicos.Interfaces
{
    public interface ICursoAppServico
    {
        List<CursoResponse> Listar();
        CursoResponse Inserir(CursoInserirRequest request);
        void Deletar(int codigo);
    }
}
