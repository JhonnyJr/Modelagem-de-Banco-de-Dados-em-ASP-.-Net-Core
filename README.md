# **Modelagem de Banco de Dados com uso de ASP . Net Core e ORM's.**

## ORM's e Frameworks (Pacotes Nuggets) usadas:
  
  - AutoMapper
  - FluentNHibernate
  - Scrutor
  - Swashbuckle
  - AspNetCore
  - Nhibernate
  - Mysql.Data

## Interface gráfica usada:
 
 - Swagger
 
## Projetos

A aplicação foi feita em Projetos separados para seguir a organização de uma aquitetura de software.
Os projetos foram divididos dessa maneira:
  
  > #### API
  >> Responsável pela entrada e saída de dados <br>
  >> **Frameworks da Solução**: AutoMapper, AutoMapperExtensionsMicrosoftDependencies, <br>MicrosoftNETCoreApp
  >> Nhibernate, Ninject, Scrutor, Swashbuckle, MicrosoftAspNetCoreRazorDesign
  >
  > #### Aplicação 
  >> Mapeamento do banco para os dados de saída, filtragem e manipulação dos dados<br>
  >> **Frameworks da Solução**: AutoMapper, MicrosoftNETCoreApp
  >
  > #### DataTransfer 
  >> Dados de entrada e saída da API <br>
  >> **Frameworks da Solução**: MicrosoftNETCoreApp
  >
  > #### Dominio
  >> Entidades do banco de dados, enumeradores do banco criados para a entidade, cabeçalho das funções do serviço <br>
  >> **Frameworks da Solução**: MicrosoftNETCoreApp
  >
  > #### Infra 
  >> Mapeamento das entidades do banco de dados, funções no banco sem ser de filtragem <br>
  >> **Frameworks da Solução**: MicrosoftNETCoreApp, FluentNHibernate
  >
  > #### IOC
  >> Configuração da aplicação à qual software de banco de dados está sendo usado <br>
  >> **Frameworks da Solução**: MicrosoftNETCoreApp, FluentNHibernate, MySqlData, Nhibernate, 
  
  ###### Especificação do seu banco de dados é feito na classe Startup dentro da aplicação API:
  ```cs
  ISessionFactory _sessionFactory = ServiceHelper.CreateSessionFactory("Server=[SEU IP];User Id=[SEU USER]; Password=[SUA SENHA];");
  ```
  
  ## Tabelas no Banco de Dados
  
  ```sql
CREATE TABLE TRILHA(
ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
NOME VARCHAR(50) NOT NULL,
DATACRIACAO DATE
);

CREATE TABLE CURSO (
ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT, 
TRILHA_ID INT NOT NULL,
NOME VARCHAR(30) NOT NULL,
EMENTA VARCHAR(100) NOT NULL,
CARGAHORARIA INT NOT NULL,
CONSTRAINT FK_CURSO_TRILHA FOREIGN KEY (TRILHA_ID) REFERENCES TRILHA(ID)
);
```
  
  
