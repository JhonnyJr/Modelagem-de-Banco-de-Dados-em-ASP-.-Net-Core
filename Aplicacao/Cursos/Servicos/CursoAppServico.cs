using Aplicacao.Cursos.Servicos.Interfaces;
using AutoMapper;
using DataTransfer.Cursos.Requests;
using DataTransfer.Cursos.Responses;
using Dominio.Cursos.Entidades;
using Dominio.Cursos.Repositorios;
using Dominio.Cursos.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacao.Cursos.Servicos
{
    public class CursoAppServico : ICursoAppServico
    {
        private readonly IMapper mapper;
        private readonly ICursosRepositorio cursosRepositorio;
        private readonly ICursosServico cursosServico;

        public CursoAppServico(IMapper mapper, ICursosRepositorio cursosRepositorio, ICursosServico cursosServico)
        {
            this.mapper = mapper;
            this.cursosRepositorio = cursosRepositorio;
            this.cursosServico = cursosServico;
        }
        public CursoResponse Inserir(CursoInserirRequest request)
        {
            var curso = this.cursosServico.Inserir(request.Nome, request.Cargahoraria, request.Ementa, request.Trilha_Id);
            return mapper.Map<CursoResponse>(curso);
        }
        public List<CursoResponse> Listar()
        {
            List<Curso> response = cursosRepositorio.Query().ToList();
            return mapper.Map<List<CursoResponse>>(response);
        }
        public void Deletar(int codigo)
        {
            var curso = this.cursosServico.Validar(codigo);
            this.cursosRepositorio.Deletar(curso);
        }
    }
}
