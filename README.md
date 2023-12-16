# ERP Básico para Pequenos Negócios

Este é um sistema ERP  básico projetado para atender às necessidades de pequenos negócios. O sistema é desenvolvido usando C# com Entity Framework para a lógica do servidor e PostgreSQL para a persistência dos dados. No frontend, utilizamos Angular para uma interface de usuário rica e responsiva.

## Características (Até o momento foi implementada apenas a transação e registro de itens)

- **Controle de Estoque:** Gerencie seu inventário, controle níveis de estoque e receba alertas quando for hora de reabastecer.
  
## Tecnologias Utilizadas

- **Backend:** C# com ASP.NET Core e Entity Framework.
- **Frontend:** Angular com PrimeNG para componentes de UI.
- **Banco de Dados:** PostgreSQL.
- **API:** RESTful API design.

## Requisitos

- .NET 5.0 ou superior.
- Node.js 12.0 ou superior.
- PostgreSQL 12 ou superior.

## Configuração

1. Clone o repositório para sua máquina local.
2. Configure a string de conexão para o PostgreSQL no arquivo `appsettings.json` no projeto do backend.
3. Execute as migrações do Entity Framework para configurar o banco de dados.
4. Instale as dependências do projeto Angular executando `npm install` na pasta do frontend.
5. Inicie o servidor backend e o servidor de desenvolvimento do Angular.

## Executando o Projeto

Para executar o backend:
- Instale o Entity Framwork .
- Instale o Postgrsql.
```bash
cd Backend
dotnet restore
dotnet build
dotnet run
cd Frontend
npm start
