# Requisitos

- Banco de dados: número do sorteio, resultado do sorteio, data do sorteio (inicio e fim), nome, tipo, quantidade de ganhadores e seus nomes, status do sorteio

- (pensar sobre) Hospedar o banco na internet 

- função que gere números aleatórios, e conferir quais são os modelos de sorteio

- protótipo de baixa fidelidade e de alta fidelidade

- (a pensar) Exibição da quantidade de ganhadores, e seus nomes

- (a pensar) Página de estatísticas com informações como: números mais jogados, múmeros mais sorteados, etc. Além disso, definir como vai ser o banco de dados nesse requisito


## Padrão de arquitetura em camadas:

- Presentation Layer: Interface utilizando ferramentas como WPF e XAML (front end)

- Application Layer: Definição dos serviços da aplicação

- Business Layer: Camada intermediária entre a Application Layer e a Database Layer

- Database Layer: Servidor SQL

link: https://www.youtube.com/watch?v=V4RDMV0L-JM&t=89s


