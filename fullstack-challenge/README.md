### BackEnd
Requerido [DotNetCore](https://dotnet.microsoft.com/download/dotnet/5.0) v5 para rodar.
Backend foi desenvolvido no Visual Studio 2019 Community Edition.

1) Altere a string de conexão com o banco de dados(é recomendado colocar os dados referentes ao sa, para que no update crie todas as tabelas corretamente). Ela fica no arquivo dentro do projeto fullstack-challenge:
```sh
appsettings.json
```

2) Sete fullstack-challenge como projeto de inicialização;


3) Vá ao console de gerenciamento de pacotes, altere para o projeto fullstack-challenge.data 
e rode o comando:
```sh
update-database
```

3) Inicie a depuração;
4) Por padrão o backend roda no seguinte caminho:
[localhost:44364](https://localhost:44364/)