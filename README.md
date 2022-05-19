# APP
O APP permite o cadastro de Orders
## Orders
possuem:
- id: gerado por um gerador de id que gera um identificador único dentro do contexto desse app e é usado para inicializar o id
- exclude: ao excluir uma Order ela não e removida, apenas marcada como excluída
- name: o nome da Order
- price: o preço da Order

Orders são abstrações generalistas, podem representar desde um pedido de comida até um carro, dado que a contextualização do que Order significa se dá no atributo name

## Funcionamento do APP

Ao iniciar o APP temos algumas opções no menu
### Opções CRUD
- Adicionar uma Order: Passa pelo processo de coleta de dados do usuario e armazena a Order na memória 
- Excluir uma Order: Coleta o id da Order a ser deletada, se a mesma existir é maracada como deletada. A Order não é removida da memória
- Atualizar uma Order: Coleta os dados e id da Order a ser atualizada, se a mesma existir é atualizada
- Printar todas as Orders: Printa todas as Orders que estão aramzenadas na mememória
- Printar Order por ID: Printa a Order com mesmo ID, caso nem uma exista um Pseudo-Null-Object-Pattern é aplicado e um Null Object Order é printado

# Código

## class Menu
- Pensada para criação dinamicas de menus. Registra opções no menu, sendo que cada 
opção registrada deve ter:
  1. Um número inteiro que representa a opção escolhida
  2. Uma callback para ser executada caso a opção seja escolhida
  3. Uma mensagem a ser exibida no menu

## class Option
- Deve ser herdada por todas classes que representam uma opção válida para o menu

## grupo de entidades-classes OrderOptions
- Herdam da class Option, cada uma das classes representam uma ação a ser realizada em cima das Orders

## class OrderMemoryDB
- É o DB especifico com operações CRUD em cima das Orders, armazena e realiza operações em cima das mesmas

## class Program
- Ponto de entrada do programa, onde as opções do menu são criadas e registradas no menu e então o menu inicia o programa
