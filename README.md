Esse projeto contém um repositório que implementa os métodos Get e GetAll.
O método GetAll retorna uma coleção de instâncias do modelo Product. O método Get
recebe uma Id por parâmetro e retorna uma única instancia do modelo com aquela Id ou
null no caso de ser um Id inexistente.
Implemente as actions Index e Details no ProductController.
A action index deve retornar uma view contendo uma lista com o nome de todos os modelos e um botão para visualizar
os detalhes de cada modelo.
A action Details deve retornar uma view mostrando todas as propriedades do modelo selecionado.
Implemente também as Actions Get e GetAll que devem retornar os dados em formato JSON.