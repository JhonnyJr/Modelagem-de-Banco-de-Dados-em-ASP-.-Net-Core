using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Infra.Cursos.Mapeamentos;
using NHibernate;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public class ServiceHelper

    {
        public static ISessionFactory CreateSessionFactory(string connectionString) // Server=127.0.0.1;User Id=root; Password=senha;
        {
            return Fluently.Configure().Database(MySQLConfiguration.Standard.ConnectionString(connectionString)
                .Driver<MySqlDataDriver>().ShowSql().FormatSql())
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<CursoMap>())
                .BuildConfiguration().BuildSessionFactory();
        }
        //Para alterar o banco é só especificar no instalador do Nhibernate nos Pacotes Nugget
        //E alterar o "MySQLConfiguration" e "MySqlDataDriver" para outros respectivos sistemas de banco
        //LEMBRETE: MySqlDataDriver NÃO é obrigatorio, dependendo do banco
        //FluentNHibernate.Cfg.Db.
    }
}
