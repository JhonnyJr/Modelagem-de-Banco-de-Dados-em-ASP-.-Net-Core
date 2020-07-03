using AutoMapper;
using DataTransfer.Cursos.Responses;
using Dominio.Cursos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Cursos.Profiles
{
    public class CursoProfile : Profile
    {
        public CursoProfile()
        {
            CreateMap<Curso, CursoResponse>();
        }
    }
}
