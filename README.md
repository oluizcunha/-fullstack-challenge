# Full Stack Challenge
## _Desenvolvido por Luiz_


O projeto foi desenvolvido com tecnologias de ponta, sendo elas:

- React com Redux
- C# api com EntityFrameworkCore
- MSSQL

## Características

- Inserir e Listar classificados
- Guardar informações de uma forma estruturada


## Execução

### Backend
Requerido [Node.js](https://nodejs.org/) v14 para rodar.
1) Entre na pasta do front-end dentro do repositorio
```sh
cd fullstack-challenge-front
```

2) Instale todas as dependencias do projeto
```sh
npm install
```
3) Inicie o projeto
```sh
npm start
```

1) Por padrão o frontend roda no seguinte caminho:
[localhost:8001](https://localhost:8001/)


### Backend
Requerido [DotNetCore](https://dotnet.microsoft.com/download/dotnet/5.0) v5 para rodar.
Backend foi desenvolvido no Visual Studio 2019 Community Edition.

1) Altere a string de conexão com o banco de dados(é recomendado colocar os dados referentes ao sa, para que no update crie todas as tabelas corretamente). Ela fica no arquivo dentro do projeto fullstack-challenge:
   ```sh
appsettings.json
```
2) Sete fullstack-challenge como projeto de inicialização;


3) Vá ao console de gerenciamento de pacotes altere para o projeto fullstack-challenge.data 
e rode o comando:
```sh
update-database
```

3) Inicie a depuração;
4) Por padrão o backend roda no seguinte caminho:
[localhost:44364](https://localhost:44364/)
****
## Imagens
![Print1](https://user-images.githubusercontent.com/53011340/121126452-2f0a0480-c7f6-11eb-8d10-dab1d0345ab2.png)

![Print2](https://user-images.githubusercontent.com/53011340/121126469-34674f00-c7f6-11eb-9f20-0bca2ce9bce1.png)

![Gif1](https://user-images.githubusercontent.com/53011340/121126480-37623f80-c7f6-11eb-957e-e8030d23e9dc.gif)


