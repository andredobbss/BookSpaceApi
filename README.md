# 📚 BookSpaceApi

API construída com **.NET Core + GraphQL** para gerenciamento de livros, autores e editoras. Ideal para estudos e experimentos com queries complexas, relacionamentos e geração de dados falsos via `Bogus`.

---

## ⚙️ Tecnologias Utilizadas

- [.NET 9 WebAPI](https://dotnet.microsoft.com/)
- [HotChocolate GraphQL](https://chillicream.com/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/)
- [SQLite](https://www.sqlite.org/?utm_source=chatgpt.com)
- [Bogus](https://github.com/bchavez/Bogus) (geração de dados fake)

---

## 🧱 Estrutura das Entidades

- **Book**
  - `Title`, `Year`, `Pages`, `Author`, `Publisher`
- **Author**
  - `Name`, `BirthDate`, `Books`
- **Publisher**
  - `Name`, `Country`, `Books`

---

## 🚀 Como Executar

### Pré-requisitos

- .NET 9 SDK
- Visual Studio ou VS Code

### Rodando localmente

```bash
git clone https://github.com/andredobbss/BookSpaceApi.git
cd BookSpaceApi

dotnet restore
dotnet ef database update
dotnet run
```

---

## 🔎 Exemplos de Query (GraphQL)

### Consultar todos os livros com autor e editora:

```bash
query {
  books {
    title
    year
    pages
    author {
      name
    }
    publisher {
      name
    }
  }
}
```

### Consultar autores e seus livros:
```bash
query {
  authors {
    name
    birthDate
    books {
      title
    }
  }
}
```
## 📄 Licença
Este projeto está licenciado sob a MIT License.
Desenvolvido por André Dobbss
