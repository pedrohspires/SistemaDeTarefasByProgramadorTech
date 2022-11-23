# SistemaDeTarefasByProgramadorTech
## Desenvolvedor: Acaciano Neves (Programador Tech)<br/>Aluno: Pedro Henrique<br/><br/>

## Sumário
### <a href="#secao1">Seção 1.0 - Sobre o projeto</a>
### <a href="#secao2">Seção 2.0 - Vídeo base</a>
### <a href="#secao3">Seção 3.0 - O que o projeto faz</a>
### <a href="#secao4">Seção 4.0 - Futuro do projeto</a>
### <a href="#secao5">Seção 5.0 - Funções do projeto</a>
### <a href="#secao6">Seção 6.0 - Como executar o projeto</a>
### <a href="#secao7">Seção 7.0 - Implementações após o vídeo base</a>
<br><br>

## <div id="secao1">1.0 - Sobre o projeto</div>

Este projeto foi criado pelo Acaciano Neves através de video aulas do canal Programador Tech no YouTube. Desenvolvi este projeto seguindo as aulas dele.

O projeto consiste em um CRUD que realiza as operações básicas deste tipo de aplicação: Create, Read, Update e Delete. Tais operações são bases para projetos de aplicações que utilizam bancos de dados para permanencia de seus dados.<br/><br/>

## <div id="secao2">2.0 - Vídeo base</div>
O vídeo base utilizado nesse projeto foi o vídeo: <b>ASP.Net Web API - C# - Criando uma API do Zero - CRUD</b><br>
Link: https://www.youtube.com/watch?v=2TxePNK0kc8

## <div id="secao3">3.0 - O que o projeto faz</div>
O projeto gerencia um sistema de tarefas, onde usuários podem realizar o cadastro, edição, deleção e leitura de tarefas, além de se associarem à uma dessas tarefas, indicando a execução da mesma.<br/><br/>

## <div id="secao4">4.0 - Futuro do projeto</div>
Até o momento da criação desse README.md, existe apenas UM vídeo no canal do Programador Tech, em que ele cria este código deste repositório. Logo, a aplicação ainda não está terminada. Vídeos futuros podem concluir o projeto, porém eu, Pedro Henrique, desejo terminar ele por mim mesmo, além de criar um frontend que consuma a API do projeto, o que não é proposto pelo criador.<br><br>
Veja a <a href="#secao7">seção 7.0</a> para verificar funcionalidades implementadas por mim após o vídeo base (seção 2.0) para este projeto.<br/><br/>

## <div id="secao5">5.0 - Funções do projeto</div>
### 5.1 - Usuário
1. Rota para criar um usuário;<br/>
<code>POST - /api/Usuario</code>

2. Editar um usuário por ID;<br/>
<code>PUT - /api/Usuario/{id}</code>

3. Deletar um usuário por ID;<br/>
<code>DELETE - /api/Usuario/{id}</code>

4. Listar um usuário por ID;<br/>
<code>GET - /api/Usuario/{id}</code>

5. Listar todos os usuários<br/>
<code>GET - /api/Usuario</code>

<br/><br/>

## <div id="secao6">6.0 - Como executar o projeto</div>
### 6.1 - Observações
1. Foi utilizado o Visual Studio Community 2019, mas não sei se é obrigatório
2. É necessário instalar alguns pacotes para trabalhar com o ASP.NET core (detalhes no item 6.2 - Requisitos)
3. O SQL server deve ter um banco de dados criado para que o projeto o utilize
### 6.2 - Requisitos
1. Visual Studio Community (utilizei 2019)
2. Git instalado
3. SQL Server (ou banco de sua preferência)
4. Pacotes NuGet: EntityFrameworkCore e seus derivados EntityFrameworkCore.Design, EntityFrameworkCore.SqlServer e EntityFrameworkCore.Tools.
### 6.3 - Passo a passo
1. Com o SQL server instalado e configurado, devemos criar um banco de dados para ser usado no projeto. O nome neste exemplo será "DB_SistemaDeTarefas"
2. Clone o repositório https://github.com/pedrohspires/SistemaDeTarefasByProgramadorTech.git na sua máquina. (É possível clonar atravpes do prório Visual Studio)
3. Abra o projeto no seu Visual Studio
4. Com o banco de dados instalado e configurado, abra o arquivo appsettings.json
5. Antes da propriedade "AllowedHosts", adicione os comandos abaixo:<br>
```
"ConnectionStrings": {<br>
    "DataBase": "Server=./;Database=DB_SistemaDeTarefas;User Id=testes;Password=testes123"
},
```
Este código faz a configuração do seu banco de dados, onde "Server=./" indica banco de dados rodando localmente, "Database=DB_SistemaDeTarefas" é o banco de dados dentro do SQL Server com o nome "DB_SistemaDeTarefas", "User Id=testes" é o usuário "testes" do banco de dados e "Password=teste123" é a senha do usuário "testes".<br>
De acordo com suas configurações, estes dados podem mudar.<br>

6. Com o banco configurado, agora é necessário criar a migration. Migration é um arquivo que gerencia as entidades do banco de dados automaticamente, bastando o programador editar os arquivos da pasta "Data/Map" para definir as propriedades de uma tabela. Abra o "Package Maneger Console" do visual studio e digite o código abaixo:<br>
``` 
Add-Migration InitialDB -Context SistemaDeTarefasDBContext 
```
7. Após criar as migrations, é necessário aplicar as alterações no banco de dados
```
Update-Database -Context SistemaDeTarefasDBContext 
```
8. Seu projeto está pronto. Para rodar clique no botão de executar o projeto no Visual Studio e a tela com o Swagger deverá ser exibida com as rotas.
### 6.4 - Informações úteis
1. O nome do banco de dados definido no appsettings.json deve ser o mesmo que foi criado no passo 1 da seção 6.3
2. O usuário "testes" deve existir no SQL Server, caso não exista deve ser criado ou você pode utilizar um usuário próprio, atendando-se apenas em configurar corretamente o usuário e senha no arquivo appsettings.json
3. Você deve realizar a configuração do usuário e e a criação do banco de dados "DB_SistemaDeTarefas" manualmente no gerenciador do SQL Server<br><br>

## <div id="secao7">7.0 - Implementações após o vídeo base</div>
* Sistema de tarefas
* Relação entre usuário e tarefas
* Frontend web e mobile com React
