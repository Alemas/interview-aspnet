# Entrevista | Exercício .NET
Esse projeto contém um repositório que implementa os métodos `Get` e `GetAll`.

O método `GetAll` retorna uma coleção de instâncias do modelo `Product`. O método `Get` recebe uma `Id` por parâmetro e retorna uma única instancia do modelo com aquela `Id` ou `null` no caso de ser um Id inexistente.

## Exercício
Implemente as actions `Index` e `Details` no `ProductController` e os métodos `Get` e `GetAll` para retorno em formato JSON.

Realize um *fork* do repositório e peça um *pull-request* para enviar sua resposta.

### Index
A action `Index` deve retornar uma view contendo uma lista com o nome de todos os modelos e um botão para visualizar os detalhes de cada modelo.

### Details
A action `Details` deve retornar uma view mostrando todas as propriedades do modelo selecionado.

### JSON
Implemente também os métodos `Get` e `GetAll` que devem retornar os dados em formato JSON.
