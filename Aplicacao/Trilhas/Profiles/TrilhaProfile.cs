using AutoMapper;
using DataTransfer.Trilhas.Responses;
using Dominio.Trilhas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Trilhas.Profiles
{
    public class TrilhaProfile : Profile
    {
        public TrilhaProfile()
        {
            CreateMap<Trilha, TrilhaResponse>();
        }
    }
}
