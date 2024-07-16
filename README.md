
# ClienteManagement

Este projeto é um sistema de gerenciamento de clientes desenvolvido utilizando .NET Core para o backend e Vue.js para o frontend. O projeto segue os princípios de Domain-Driven Design (DDD) e aplica o padrão CQRS (Command Query Responsibility Segregation).

## Tecnologias Utilizadas

- **Backend**: .NET Core 8
- **Frontend**: Vue.js
- **Banco de Dados**: SQL Server (LocalDB)

## Estrutura do Projeto

O projeto é dividido em várias camadas para separar as responsabilidades:

- **Presentation**: Contém a interface do usuário e os controladores de API.
- **Application**: Contém a lógica de aplicação, interfaces de serviços e DTOs.
- **Domain**: Contém as entidades de domínio e as interfaces de repositório.
- **Infrastructure**: Contém a implementação dos repositórios e o contexto do banco de dados.

## Princípios e Padrões

- **Domain-Driven Design (DDD)**: O projeto é estruturado seguindo os princípios do DDD, onde a lógica de negócio é centralizada no domínio.
- **CQRS**: Aplicação do padrão CQRS para separar as operações de leitura (queries) das operações de escrita (commands).
- **Validação de Dados**: As requisições são validadas para garantir que os dados recebidos estejam corretos antes de serem processados.

## Configuração e Execução

### Backend

1. **Configurar as Migrations**:
   Execute os seguintes comandos para aplicar as migrations e criar o banco de dados:

   ```bash
   dotnet ef migrations add InitialCreate --context ClienteDbContext
   dotnet ef database update --context ClienteDbContext
   ```

2. **Iniciar o Backend**:
   Navegue até o diretório `src/ClienteManagement.Api` e execute o comando:

   ```bash
   dotnet run
   ```

### Frontend

1. **Instalar Dependências**:
   Navegue até o diretório `src/ClienteManagement.Web` e execute o comando:

   ```bash
   npm install
   ```

2. **Iniciar o Frontend**:
   Ainda no diretório `src/ClienteManagement.Web`, execute o comando:

   ```bash
   npm start
   ```

### Executar Ambos Simultaneamente

Para executar o backend e o frontend ao mesmo tempo, navegue até o diretório principal do projeto e execute:

```bash
npm run dev
```

## Screenshots

### Tela de Listagem

![Tela de Listagem](https://github.com/user-attachments/assets/2627fc36-7ba1-4515-80fb-01199f41e4d7)

### Tela de Criação

![Tela de Criação](https://github.com/user-attachments/assets/337af4b1-7d59-4a1b-b2e5-fa600758479e)

## Contato

Para mais informações, entre em contato com Halisson Araujo.
