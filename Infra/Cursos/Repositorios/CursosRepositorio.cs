using Dominio.Cursos.Entidades;
using Dominio.Cursos.Repositorios;
using NHibernate;
using NHibernate.Persister.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Cursos.Repositorios
{
    public class CursosRepositorio : ICursosRepositorio
    {
        private readonly ISession session;

        public CursosRepositorio(ISession session)
        {
            this.session = session;
        }

        public IQueryable<Curso> Query()
        {
            return session.Query<Curso>();
        }
        public void Deletar(Curso curso)
        {
            ITransaction transaction = session.BeginTransaction();
            try
            {
                session.Delete(curso);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }

        public Curso Recupera(int codigo)
        {
            return session.Get<Curso>(codigo);
        }

        public int Inserir(Curso curso)
        {
            ITransaction transaction = session.BeginTransaction();
            try
            {
                var id = session.Save(curso);
                transaction.Commit();
                return (int)id;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
