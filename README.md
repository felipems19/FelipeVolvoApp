# Cadastramento Caminhões Volvo
Projeto realizado com a finalidade de concluir uma avaliação técnica emitida para Felipe Marques Santos

## Description

Essa avaliação se trata de uma aplicação em ASP.NET Core capaz de realizar cadastramento/edição/exclusão de caminhões

## Getting Started

### Dependencies

As dependências/pacotes utilizados são:

    "Microsoft.AspNetCore.Authentication.JwtBearer" Version="3.1.17"
    "Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="3.1.17"
    "Microsoft.EntityFrameworkCore" Version="3.1.17"
    "Microsoft.EntityFrameworkCore.Design" Version="3.1.17"
    "Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.17"
    "Microsoft.EntityFrameworkCore.Tools" Version="3.1.17"
    "Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="3.1.5"
    "Swashbuckle.AspNetCore" Version="6.1.4"
    "Swashbuckle.AspNetCore.Swagger" Version="6.1.4"
    "Swashbuckle.AspNetCore.SwaggerUI" Version="6.1.4"


### Installing

* Checar funcionamento/existência Migration/Database
* Inicialmente é preciso criar o database com base na migration já existente. Portanto é preciso rodar o seguinte código:

```
Update-Database
```
* Na existência de algum problema na migration, o comando utilizado é o seguinte:

```
add-migration 'Inital'
```


### Executing program

Para iniciar o projeto basta abrir a solução, selecionar para executar com IIS Express local e observar a criação da base de dados


## Funcionamento

Ao executar o projeto a primera página a ser exibida é a Homepage (de caráter informativo apenas). Logo após torna-se necessário abrir a página Caminhões, que irá basicamente listar
os caminhões existentes e a opção de inserir novo caminhão.

Logo após é possível notar os campos necessários referentes aos caminhões e suas respectivas lógicas de negócio.

Volta para a página inicial é possivel observar o caminhão cadastrado e atualizar/visualizar/deletar o registro


## Authors

Felipe Marques Santos

Email: felipe.marques19@gmail.com

Linkedin: https://www.linkedin.com/in/felipe-marques-santos-679b946b/
