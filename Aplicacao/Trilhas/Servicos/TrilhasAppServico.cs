using Aplicacao.Trilhas.Servicos.Interfaces;
using AutoMapper;
using DataTransfer.Trilhas.Requests;
using DataTransfer.Trilhas.Responses;
using Dominio.Trilhas.Entidades;
using Dominio.Trilhas.Repositorios;
using Dominio.Trilhas.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacao.Trilhas.Servicos
{
    public class TrilhasAppServico : ITrilhasAppServico
    {
        private readonly IMapper mapper;
        private readonly ITrilhasRepositorio trilhasRepositorio;
        private readonly ITrilhasServico trilhasServico;

        public TrilhasAppServico (IMapper mapper, ITrilhasRepositorio trilhasRepositorio, ITrilhasServico trilhasServico)
        {
            this.mapper = mapper;
            this.trilhasRepositorio = trilhasRepositorio;
            this.trilhasServico = trilhasServico;
        }
        public List<TrilhaResponse> Listar()
        {
            List<Trilha> response = trilhasRepositorio.Query().ToList();
            return mapper.Map<List<TrilhaResponse>>(response);
        }
        public Trilha Inserir(TrilhaInserirRequest request)
        {
            return this.trilhasServico.Inserir(request.Nome);
        }
        public void Deletar(int codigo)
        {
            this.trilhasServico.Deletar(codigo);
        }
    }
}
