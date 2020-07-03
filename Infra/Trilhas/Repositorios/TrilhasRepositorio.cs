using Dominio.Trilhas.Entidades;
using Dominio.Trilhas.Repositorios;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Trilhas.Repositorios
{
    public class TrilhasRepositorio : ITrilhasRepositorio
    {
        private readonly ISession session;
        
        public TrilhasRepositorio(ISession session)
        {
            this.session = session;
        }
        public void Deletar(Trilha trilha)
        {
            ITransaction transaction = session.BeginTransaction();
            try
            {
                session.Delete(trilha);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }

        public object Inserir(Trilha trilha)
        {
            return this.session.Save(trilha);
        }

        public IQueryable<Trilha> Query()
        {
            return session.Query<Trilha>();
        }

        public Trilha Recupera(int codigo)
        {
            return session.Get<Trilha>(codigo);
        }
    }
}
