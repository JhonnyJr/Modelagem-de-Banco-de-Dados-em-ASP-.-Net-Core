using Dominio.Cursos.Entidades;
using Dominio.Trilhas.Entidades;
using Dominio.Trilhas.Repositorios;
using Dominio.Trilhas.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Trilhas.Servicos
{
    public class TrilhasServico : ITrilhasServico
    {
        private readonly ITrilhasRepositorio trilhasRepositorio;
        public TrilhasServico(ITrilhasRepositorio trilhasRepositorio)
        {
            this.trilhasRepositorio = trilhasRepositorio;
        }
        public Trilha Inserir(string Nome)
        {
            Trilha entidade = new Trilha(Nome);
            entidade.Id = (int)this.trilhasRepositorio.Inserir(entidade);

            return entidade;
        }
        public Trilha Validar(int codigo)
        {
            var entidade = this.trilhasRepositorio.Recupera(codigo);
            if (entidade == null)
            {
                throw new Exception("Trilha Invalida");
            }
            return entidade;
        }
        public void Deletar(int codigo)
        {
            var entidade = Validar(codigo);
            if (!entidade.cursos.Any())
            {
                this.trilhasRepositorio.Deletar(entidade);
            }
            else
                throw new Exception("Esvazie os cursos primeiro");
        }
    }
}
