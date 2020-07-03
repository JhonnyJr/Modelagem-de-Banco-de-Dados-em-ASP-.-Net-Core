**Modelagem de Banco de Dados com uso de ASP . Net Core e ORM's.**

ORM's e Frameworks (Pacotes Nuggets) usadas:
  
  - AutoMapper
  - FluentNHibernate
  - Scrutor
  - Swashbuckle
  - AspNetCore
  - Nhibernate
  - Mysql.Data
  
  
A aplicação foi feita em Projetos separados para seguir a organização de uma aquitetura de software.
Os projetos foram divididos dessa maneira:
  
  > API
  >> Responsável pela entrada e saída de dados <br>
  >> Frameworks da Solução: AutoMapper, AutoMapperExtensionsMicrosoftDependencies, <br>MicrosoftNETCoreApp
  >> Nhibernate, Ninject, Scrutor, Swashbuckle, MicrosoftAspNetCoreRazorDesign
  >
  > Aplicação 
  >> Mapeamento do banco para os dados de saída, filtragem e manipulação dos dados<br>
  >> Frameworks da Solução: AutoMapper, MicrosoftNETCoreApp
  >
  > DataTransfer 
  >> Dados de entrada e saída da API <br>
  >> Frameworks da Solução: MicrosoftNETCoreApp
  >
  > Dominio
  >> Entidades do banco de dados, enumeradores do banco criados para a entidade, cabeçalho das funções do serviço <br>
  >> Frameworks da Solução: MicrosoftNETCoreApp
  >
  > Infra 
  >> Mapeamento das entidades do banco de dados, funções no banco sem ser de filtragem <br>
  >> Frameworks da Solução: MicrosoftNETCoreApp, FluentNHibernate
  >
  > IOC
  >> Configuração da aplicação à qual software de banco de dados está sendo usado <br>
  >> Frameworks da Solução: MicrosoftNETCoreApp, FluentNHibernate, MySqlData, Nhibernate, 
  
  
  
  
  
