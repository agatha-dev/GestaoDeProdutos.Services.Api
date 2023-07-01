# Sistema de Estoque

Este é um projeto de API em .NET 7 para um sistema de estoque que gerencia produtos e categorias.

## Tecnologias utilizadas

- .NET 7
- DDD
- TDD
- AutoMapper

## Arquitetura

O projeto segue o padrão de arquitetura DDD (Domain-Driven Design), o que significa que está estruturado em diferentes camadas para separar as responsabilidades e facilitar a manutenção e testabilidade. As principais camadas do projeto são:

- **Domain**: contém as entidades de domínio, interfaces de repositório, exceções personalizadas e serviços de domínio.
- **Application**: contém os comandos, consultas, manipuladores de comando e consultas, bem como os mapeamentos de DTOs (Data Transfer Objects) usando o AutoMapper.
- **Infrastructure**: contém a implementação dos repositórios, banco de dados, configurações de injeção de dependência e outros componentes de infraestrutura.
- **API**: fornece as controllers da API que lidam com as requisições HTTP e orquestram o fluxo de trabalho usando o MediatR para processar os comandos e consultas.

## Funcionalidades

O projeto implementa as seguintes funcionalidades básicas utilizando o padrão CRUD (Create, Read, Update, Delete), além das funções GetById e GetAll:

### Produtos

- **GET /api/produtos**: Retorna todos os produtos cadastrados.
- **GET /api/produtos/{id}**: Retorna um produto específico com base no ID fornecido.
- **POST /api/produtos**: Cria um novo produto com base nos dados fornecidos.
- **PUT /api/produtos/{id}**: Atualiza um produto existente com base no ID fornecido e nos dados fornecidos.
- **DELETE /api/produtos/{id}**: Exclui um produto específico com base no ID fornecido.

### Categorias

- **GET /api/categorias**: Retorna todas as categorias cadastradas.
- **GET /api/categorias/{id}**: Retorna uma categoria específica com base no ID fornecido.
- **POST /api/categorias**: Cria uma nova categoria com base nos dados fornecidos.
- **PUT /api/categorias/{id}**: Atualiza uma categoria existente com base no ID fornecido e nos dados fornecidos.
- **DELETE /api/categorias/{id}**: Exclui uma categoria específica com base no ID fornecido.

## Testes

O projeto segue a abordagem de desenvolvimento orientado a testes (TDD). Os testes unitários foram implementados para garantir o correto funcionamento das funcionalidades implementadas. Os testes podem ser encontrados no diretório `Tests` e foram escritos usando o framework de testes do .NET.

## Configuração e execução

Para configurar e executar o projeto, siga as etapas abaixo:

 1 - Certifique-se de ter o .NET 7 SDK instalado em sua máquina. Você pode fazer o download do SDK mais recente em: https://dotnet.microsoft.com/download/dotnet/7.0.

Clone o repositório do projeto para o seu ambiente local:

shell
Copy code
git clone <URL_DO_REPOSITORIO>
Navegue até o diretório raiz do projeto:

shell
Copy code
cd SistemaDeEstoque
Restaure as dependências do projeto usando o comando dotnet restore:

shell
Copy code
dotnet restore
Configure as variáveis de ambiente necessárias. Certifique-se de configurar a string de conexão com o banco de dados, bem como outras configurações relevantes para o seu ambiente.

Execute as migrações do banco de dados para criar a estrutura necessária:

shell
Copy code
dotnet ef database update
Agora você pode executar o projeto:

shell
Copy code
dotnet run
A API estará disponível localmente em http://localhost:5000 (ou https://localhost:5001 com HTTPS) e você poderá acessar as diferentes rotas mencionadas anteriormente para interagir com as funcionalidades de produtos e categorias.

Certifique-se de personalizar e ajustar essas instruções conforme necessário, dependendo da estrutura específica do seu projeto, como configurações adicionais, autenticação, autorização, entre outros.
