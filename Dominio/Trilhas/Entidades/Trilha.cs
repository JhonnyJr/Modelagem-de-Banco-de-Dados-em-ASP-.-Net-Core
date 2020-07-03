using Dominio.Cursos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dominio.Trilhas.Entidades
{
    public class Trilha
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Curso> cursos { get; set; }
        public virtual DateTime Datacriacao { get; set; }

        public Trilha(){  }
        public Trilha(string nome) 
        {
            SetNome(nome);
            SetData(DateTime.Now);
        }

        public virtual void SetId(int id)
        {
            Id = id;
        }
        public virtual void SetNome(string nome)
        {
            if (nome == null)
            {
                throw new Exception("Nome Inválido");
            }
            Nome = nome;
        }

        public virtual void SetData(DateTime datetime)
        {
            if (datetime == null)
            {
                throw new Exception("Data Invalida");
            }
            Datacriacao = datetime;
        }
    }
}
