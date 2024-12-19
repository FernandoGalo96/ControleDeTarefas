Objetivo:
O objetivo desta prova prática é avaliar as habilidades dos candidatos em desenvolvimento de APIs usando C#/.NET. Os candidatos serão solicitados a criar uma API RESTful para gerenciar tarefas (TODOs), com a adição de uma funcionalidade que permite que apenas o usuário que criou uma tarefa possa visualizá-la.

Requisitos:

A API deve permitir a criação, leitura, atualização e exclusão de tarefas (CRUD) de forma que apenas o usuário que criou uma tarefa possa visualizá-la.
Cada tarefa deve ter pelo menos os seguintes campos:

ID: identificador único da tarefa
Título: título da tarefa
Descrição: descrição da tarefa
Data de criação: data e hora em que a tarefa foi criada
Data de conclusão: data e hora em que a tarefa foi concluída (pode ser nulo se a tarefa ainda não foi concluída)
ID do usuário: identificador único do usuário que criou a tarefa


A API deve ser protegida por autenticação JWT (JSON Web Token).
Implemente validações de entrada para os campos obrigatórios.
Utilize padrões de projeto e boas práticas de desenvolvimento.


Endpoints Esperados:

POST /api/todos: Cria uma nova tarefa, associando-a ao usuário autenticado.
GET /api/todos: Retorna todas as tarefas do usuário autenticado.
GET /api/todos/{id}: Retorna uma única tarefa com o ID correspondente, se pertencer ao usuário autenticado.
PUT /api/todos/{id}: Atualiza uma tarefa existente com o ID correspondente, se pertencer ao usuário autenticado.
DELETE /api/todos/{id}: Exclui uma tarefa existente com o ID correspondente, se pertencer ao usuário autenticado.


Instruções Adicionais:
O candidato deve fornecer documentação básica para a API, incluindo como autenticar-se para usar os endpoints protegidos.

Avaliação:
Os candidatos serão avaliados com base nos seguintes critérios:

Funcionalidade completa e correta da API, incluindo a funcionalidade de visualização de tarefas apenas pelo usuário criador.
Qualidade do código, incluindo legibilidade, modularidade e boas práticas de desenvolvimento.
Implementação adequada da autenticação JWT.
Uso adequado de padrões de projeto e estruturação do projeto.


Obs: Adicionei o identity para treinar
