# sp-taxa-juros-api

API simples com apenas um endpoint:
  * /TaxaJuros: retorna 0.01 (1%) fixo.

# Estrutura
 
 Projeto contruído em Asp.Net Core, sem nenhuma camada. Utilizado para testes de integração no projeto  <a href="https://github.com/Douuuglas/sp-calculadora-juros-api">🔗 sp-calculadora-juros-api</a>;

# Requisitos para rodar a aplicação
  * .Net 5;
  * Docker 20+;

# Documentação em ambiente Windows

Acessar o terminal do windows e:

Baixar o projeto
```
git clone https://github.com/Douuuglas/sp-taxa-juros-api.git
```

Entrar na pasta do projeto
```
cd sp-taxa-juros-api
```

Buildar o projeto
```
dotnet build
```

Rodar os testes
```
dotnet test
```

Rodar o projeto
```
dotnet run --project .\WebApi\WebApi.csproj
```

Buildar o projeto em container
```
docker build -t taxa-juros-api -f .\WebApi\Dockerfile .
```

Rodar o projeto em container
```
docker run --name taxa-juros-api -dp 8080:80 taxa-juros-api
```


