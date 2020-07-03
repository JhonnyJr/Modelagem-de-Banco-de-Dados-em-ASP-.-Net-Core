using DataTransfer.Trilhas.Requests;
using DataTransfer.Trilhas.Responses;
using Dominio.Trilhas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Trilhas.Servicos.Interfaces
{
    public interface ITrilhasAppServico
    {
        List<TrilhaResponse> Listar();
        Trilha Inserir(TrilhaInserirRequest request);
        void Deletar(int codigo);
    }
}
