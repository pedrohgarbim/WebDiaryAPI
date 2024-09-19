# 📖 WebDiaryAPI

## 📚 Visão Geral

Este projeto é uma Web API chamada **WebDiaryAPI**, desenvolvida usando ASP.NET Core. A API permite aos usuários realizar operações CRUD em entradas de diário, possibilitando funcionalidades para criar, ler, atualizar e excluir entradas. A API também integra o Swagger para documentação e teste.

## 🗂 Estrutura do Projeto

- **Controllers/DiaryEntriesController.cs** 📄  
  Este é o controlador principal que lida com todos os endpoints da API para gerenciar entradas de diário. Ele inclui métodos para:
  - **GET** `/api/DiaryEntries` 📝: Recupera todas as entradas de diário do banco de dados.
  - **GET** `/api/DiaryEntries/{id}` 🔍: Recupera uma entrada específica do diário com base em seu ID.
  - **POST** `/api/DiaryEntries` ➕: Cria uma nova entrada de diário e a adiciona ao banco de dados.
  - **PUT** `/api/DiaryEntries/{id}` ✏️: Atualiza uma entrada existente no banco de dados com base em seu ID.
  - **DELETE** `/api/DiaryEntries/{id}` 🗑️: Exclui uma entrada de diário específica do banco de dados com base em seu ID.

  Este controlador faz uso da injeção de dependência para acessar o `ApplicationDbContext`, que gerencia a interação com o banco de dados.

- **Data/ApplicationDbContext.cs** 🗄️  
  Esta classe define o contexto do banco de dados utilizando o Entity Framework Core. Ela herda de `DbContext` e expõe um `DbSet<DiaryEntry>` que representa a coleção de entradas de diário na base de dados. É aqui que a conexão com o banco de dados é configurada e onde as tabelas são definidas.

- **Models/DiaryEntry.cs** 📋  
  Esta classe representa o modelo de dados para uma entrada de diário. Cada entrada tem um `Id` (chave primária), um `Title` (título da entrada), `Content` (conteúdo da entrada) e uma data de criação (`Created`). Atributos como `[Required]` são usados para validar os campos obrigatórios, garantindo a integridade dos dados antes de serem persistidos no banco de dados.

- **Program.cs** 🚀  
  Este é o ponto de entrada da aplicação. Ele configura os serviços necessários, como o Entity Framework Core e o Swagger, e define o pipeline de processamento de solicitações HTTP. No modo de desenvolvimento, ele configura o Swagger para fornecer uma interface gráfica para testar e documentar a API. Além disso, configura o roteamento dos controladores, permitindo que as solicitações HTTP sejam direcionadas para os métodos correspondentes.

- **appsettings.json** ⚙️  
  Este arquivo contém configurações essenciais da aplicação, incluindo a string de conexão com o banco de dados. A string de conexão é crucial para o Entity Framework Core saber para qual banco de dados se conectar e onde armazenar ou recuperar dados.

- **WebDiaryAPI.http** 🌐  
  Este é um arquivo que pode ser utilizado para testar a API diretamente do editor de código (como o Visual Studio Code) utilizando as funcionalidades de requisições HTTP. Ele contém exemplos de solicitações que podem ser enviadas à API, como GET, POST, PUT e DELETE, facilitando o teste das funcionalidades implementadas.

## 🛠 Configuração e Uso

1. **Configuração do Banco de Dados** 🗃️: Certifique-se de configurar a string de conexão no `appsettings.json` para apontar para o seu banco de dados SQL Server.

2. **Swagger** 🧩: O Swagger está configurado e pode ser acessado através do caminho `/swagger`. Ele fornece uma interface para testar e interagir com os endpoints da API.

## 🧭 Uso do Swagger

- **Swagger UI** 🎨: O Swagger UI permite que você visualize e teste os endpoints da API diretamente do navegador. Ele exibe todos os endpoints disponíveis e permite enviar solicitações diretamente para a API.
  
  ![image](https://github.com/user-attachments/assets/991b3c4d-1a02-4041-bb66-083b743e56d7)
  ### Exemplo com get
  ![image](https://github.com/user-attachments/assets/d24d737e-35d1-49f9-b549-72287462596f)



- **Execução dos Endpoints** 🚀:
  - **GET**: Recupera todas ou uma entrada específica.
  - **POST**: Adiciona uma nova entrada ao diário.
  - **PUT**: Atualiza uma entrada existente.
  - **DELETE**: Remove uma entrada do diário.

## 📜 O que é Swagger?

O **Swagger** é um conjunto de ferramentas para projetar, construir, documentar e consumir APIs REST. Ele gera automaticamente uma documentação visual para a API, facilita o teste dos endpoints e pode ser usado para geração de código em diferentes linguagens. O Swagger facilita a comunicação e entendimento entre os desenvolvedores e consumidores da API, proporcionando uma forma interativa de explorar a API.

## 📂 Estrutura de Arquivos

- `Controllers/DiaryEntriesController.cs` 📂: Lida com as operações CRUD.
- `Data/ApplicationDbContext.cs` 🗄️: Configura o contexto do banco de dados.
- `Models/DiaryEntry.cs` 📋: Define a estrutura de dados das entradas de diário.
- `Program.cs` 🚀: Configuração e inicialização da aplicação.
- `appsettings.json` ⚙️: Configurações da aplicação, incluindo a string de conexão do banco de dados.
- `WebDiaryAPI.http` 🌐: Arquivo para testar requisições HTTP diretamente no editor de código.

---

### Para completa fabricação do projeto os seguintes Tópicos foram estudados 
# 📝 Aplicação dos Tópicos no Desenvolvimento do WebDiaryAPI
1. **52. Restful API Intro** 📖  
   Este tópico foi estudado para compreender os fundamentos de APIs RESTful. Foi essencial para estruturar a WebDiaryAPI de acordo com os princípios REST, definindo claramente os métodos HTTP (GET, POST, PUT, DELETE) para realizar operações de CRUD nas entradas do diário.

2. **Understanding RESTful APIs** 📝  
   O teste ajudou a consolidar o entendimento sobre como implementar APIs RESTful corretamente. Isso garantiu que a API fosse desenvolvida de forma consistente, seguindo princípios como Stateless, Client-Server, e Uniform Interface, contribuindo para a escalabilidade e manutenção da API.

3. **Understanding CRUD in ASP.NET API and Project Steps** 🛠️  
   Este tópico foi crucial para a implementação das operações CRUD na WebDiaryAPI. A partir dele, aprendi como criar controladores e métodos de ação em uma API ASP.NET Core para realizar operações de criação, leitura, atualização e exclusão de registros, o que foi aplicado diretamente no `DiaryEntriesController`.

4. **Implementing CRUD Operations** 🔄  
   O teste foi usado para praticar a implementação de operações CRUD. A prática obtida aqui foi fundamental para a construção dos métodos no `DiaryEntriesController`, garantindo que as operações fossem implementadas corretamente e testadas.

5. **Creating our Web API Project** 🚀  
   Este tópico guiou a criação do projeto WebDiaryAPI. Ele forneceu as etapas necessárias para configurar um novo projeto ASP.NET Core Web API, incluindo a configuração do Entity Framework Core, o que facilitou o início do desenvolvimento.

6. **Creating a Basic RESTful API Assignment** 📘  
   Esta tarefa ajudou a reforçar a criação de uma API básica, fornecendo a base para o desenvolvimento da WebDiaryAPI. A partir dela, foi possível compreender a importância de uma boa estruturação e organização do projeto.

7. **Understanding the Web API Template Project** 📦  
   Este tópico forneceu uma compreensão do projeto modelo de uma Web API em ASP.NET Core. Isso ajudou a entender como o template é estruturado, quais bibliotecas são incluídas por padrão, e como aproveitá-lo ao máximo para acelerar o desenvolvimento do WebDiaryAPI.

8. **Looking at the Default WeatherForecastController** 🌦️  
   A análise deste controlador padrão ajudou a entender a estrutura básica de um controlador em ASP.NET Core. Ele serviu como referência para criar o `DiaryEntriesController`, adaptando os métodos de ação para as operações necessárias.

9. **Setting up everything so we can access the DB again** 🗄️  
   Este tópico foi essencial para configurar o acesso ao banco de dados na WebDiaryAPI. A partir dele, foram configurados o `ApplicationDbContext` e a string de conexão, garantindo que a aplicação pudesse se comunicar com o banco de dados SQL Server corretamente.

10. **Setting Up Database Access** 🔧  
    O teste auxiliou na prática de configuração do acesso ao banco de dados. Isso incluiu configurar corretamente o `DbContext` e a string de conexão no `appsettings.json`, o que foi crucial para o funcionamento da API.

11. **Web API Features Overview** 🌐  
    Este tópico forneceu uma visão geral dos recursos da Web API, como roteamento, model binding e validação. Isso foi aplicado ao configurar o roteamento para o `DiaryEntriesController` e validar os modelos de entrada.

12. **Implementing Pagination for API Results** 📏  
    Embora não tenha sido detalhada no código fornecido, a implementação da paginação foi estudada para ser adicionada na API. A ideia é permitir que os usuários obtenham os resultados das entradas do diário em páginas, melhorando a eficiência ao lidar com grandes volumes de dados.

13. **Swagger Overview** 📄  
    Este tópico introduziu o Swagger e sua integração com a Web API. A partir dele, foi possível configurar o Swagger no projeto para fornecer uma documentação interativa da API, facilitando o teste e a compreensão dos endpoints disponíveis.

14. **HTTP GET - CRUD - Reading all entries via API** 📥  
    Este tópico foi fundamental para implementar o método GET na API, permitindo a leitura de todas as entradas do diário. Ele mostrou como retornar uma lista de entradas como resposta a uma solicitação GET.

15. **IEnumerable** 📋  
    Este tópico foi utilizado para compreender como retornar coleções de dados nas respostas da API. A interface `IEnumerable` foi usada nos métodos GET para retornar a lista de entradas do diário, proporcionando uma iteração eficiente.

16. **Asynchronous Programming** ⚡  
    Este tópico foi crucial para entender como usar operações assíncronas na API, melhorando a escalabilidade e a capacidade de resposta da aplicação. A maioria dos métodos na API foram implementados de forma assíncrona usando `async` e `await`.

17. **Understanding Task** 🧩  
    Este tópico complementou o entendimento de programação assíncrona. Aprender sobre `Task` foi essencial para implementar métodos assíncronos nos controladores, garantindo uma melhor gestão de recursos e desempenho.

18. **Understanding ActionResult** 🎯  
    Este tópico forneceu uma compreensão do retorno de tipos de ações nos controladores. `ActionResult` foi utilizado para retornar diferentes tipos de respostas HTTP (como 200 OK, 404 NotFound, etc.), dependendo do resultado das operações.

19. **Implementing a Custom ActionResult** 🛠️  
    Esta tarefa auxiliou na criação de resultados personalizados para as ações da API. Embora não detalhada diretamente, a compreensão de como personalizar `ActionResult` foi importante para fornecer respostas mais significativas ao cliente.

20. **HTTP GET but Asynchronously** 🔄  
    Este tópico reforçou a importância de implementar métodos GET de forma assíncrona, melhorando o desempenho da API e a experiência do usuário, especialmente em operações de leitura que podem envolver grandes volumes de dados.

21. **HTTP GET by ID** 🔍  
    O aprendizado deste tópico foi aplicado ao criar o método GET que recupera uma entrada específica por ID. Ele mostrou como lidar com parâmetros de rota e retornar a resposta correta dependendo se a entrada foi encontrada ou não.

22. **CRUD: Creating an Item in the DB** ➕  
    Este tópico foi aplicado ao implementar o método POST, que permite a criação de novas entradas no diário. Ele detalhou como receber dados do cliente, validá-los e salvá-los no banco de dados.

23. **CRUD: HttpPut request to update items in the DB** ✏️  
    Este tópico ajudou na implementação do método PUT, que permite a atualização de entradas existentes no diário. Ele mostrou como verificar se uma entrada existe antes de atualizá-la e como lidar com as diferentes respostas HTTP.

24. **CRUD: HttpDelete** 🗑️  
    Este tópico foi usado para implementar o método DELETE, permitindo a exclusão de entradas do diário. Ele ensinou como buscar uma entrada pelo ID e removê-la do banco de dados, retornando a resposta apropriada.

---

O estudo e aplicação desses tópicos foram fundamentais para o desenvolvimento do WebDiaryAPI, garantindo uma implementação robusta, eficiente e seguindo as melhores práticas para APIs RESTful.






