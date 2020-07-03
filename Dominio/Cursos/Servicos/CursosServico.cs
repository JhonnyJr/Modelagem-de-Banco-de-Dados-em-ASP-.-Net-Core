using Dominio.Cursos.Entidades;
using Dominio.Cursos.Repositorios;
using Dominio.Cursos.Servicos.Interfaces;
using Dominio.Trilhas.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Cursos.Servicos
{
    public class CursosServico : ICursosServico
    {
        private readonly ICursosRepositorio cursosRepositorio;
        private readonly ITrilhasServico trilhasServico;
        public CursosServico(ICursosRepositorio cursosRepositorio, ITrilhasServico trilhasServico)
        {
            this.cursosRepositorio = cursosRepositorio;
            this.trilhasServico = trilhasServico;
        }

        public Curso Inserir(string nome, int cargahoraria, string ementa, int trilha_id)
        {
            var trilha = this.trilhasServico.Validar(trilha_id);
            Curso entidade = new Curso(nome, cargahoraria, ementa, trilha);
            entidade.Id = this.cursosRepositorio.Inserir(entidade);
            return entidade;
        }

        public Curso Validar(int codigo)
        {
            var entidade = this.cursosRepositorio.Recupera(codigo);
            if (entidade == null)
            {
                throw new Exception("Curso Invalido");
            }
            return entidade;
        }
        public void Deletar(int codigo)
        {
            var entidade = Validar(codigo);
            this.cursosRepositorio.Deletar(entidade);
        }
    }
}
