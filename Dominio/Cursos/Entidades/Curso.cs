using Dominio.Trilhas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Cursos.Entidades
{
    public class Curso
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual int CargaHoraria { get; set; }
        public virtual string Ementa { get; set; }
        public virtual Trilha Trilha { get; set; }

        public Curso() { }
        public Curso(string nome, int cargahoraria, string ementa, Trilha trilha)
        {
            SetNome(nome);
            SetCarga(cargahoraria);
            SetEmenta(ementa);
            SetTrilha(trilha);
        }
        public virtual void SetId(int id)
        {
            Id = id;
        }
        public virtual void SetTrilha(Trilha trilha)
        {
            Trilha = trilha;
        }
        public virtual void SetNome(string nome)
        {
            if (nome == null)
            {
                throw new Exception("Nome Vazio");
            }
            else
                Nome = nome;
            
        }
        public virtual void SetCarga(int cargahoraria)
        {
            if (cargahoraria <= 0)
            {
                throw new Exception("Carga Horaria invalida");
            }
            else
                CargaHoraria = cargahoraria;
        }
        public virtual void SetEmenta(string ementa)
        {
            if (ementa == null)
            {
                throw new Exception("Ementa vazia");
            }
            else
                Ementa = ementa;
        }
    }
}
