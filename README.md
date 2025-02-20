# Jogo da Adivinhação

Este é um jogo simples de adivinhação, onde o usuário escolhe um número de 1 a 100 e tenta adivinhar o número gerado aleatoriamente pela máquina. O jogo oferece opções para reiniciar ou encerrar após cada tentativa.

## Funcionalidades

- Tela inicial com opções para iniciar o jogo ou sair.
- O usuário escolhe um número de 1 a 100.
- A máquina gera um número aleatório entre 1 e 100.
- O jogo valida se o número do usuário é válido (dentro do intervalo de 1 a 100).
- O jogo informa se o usuário ganhou ou perdeu.
- O jogo oferece a opção de jogar novamente ou sair após o resultado de cada rodada.

## Estrutura do Código

### Função `TelaInicial()`

Esta função exibe o menu inicial do jogo e aguarda a escolha do usuário. Ela retorna o número escolhido (1 para iniciar o jogo, 2 para sair).

### Função `GameAdivinhação()`

Esta função contém o fluxo principal do jogo de adivinhação. Ela inclui:
- A escolha do número pelo usuário.
- A validação do número, garantindo que esteja no intervalo correto (1 a 100).
- A comparação entre o número do usuário e o número gerado aleatoriamente pela máquina.
- Exibição de uma mensagem de vitória ou derrota, com a opção de jogar novamente ou encerrar.

### Função `ValidarResultado()`

Esta função compara o número do usuário com o número gerado pela máquina e determina o resultado:
- Se o número da máquina for maior, o usuário perde.
- Se o número do usuário for maior, o usuário ganha.

## Como Jogar

1. Ao iniciar o jogo, escolha a opção "1" para começar a adivinhar.
2. O jogo irá pedir para você escolher um número entre 1 e 100.
3. Após escolher o número, o jogo comparará sua escolha com o número gerado pela máquina e exibirá se você ganhou ou perdeu.
4. Você pode escolher entre jogar novamente ou encerrar o jogo.

## Exemplo de Execução
```bash
Jogo da Adivinhação
1: Iniciar Partida
2: Sair do Game
Escolha uma alternativa: 1
Iniciando Partida

Escolha um número de 1 a 100: 50
VOCÊ PERDEU!
A Máquina é a Vencedora!
Número escolhido pela máquina: 62 vs Seu número: 50

1: Jogar denovo
2: Encerrar Game
Qual a sua alternativa: 1

Escolha um número de 1 a 100: 75
PARABÉNS, VOCÊ GANHOU!
Número escolhido por você: 75 vs Número da máquina: 62

1: Jogar denovo
2: Encerrar Game
Qual a sua alternativa: 2

Até Logo
```
## Considerações

- O código valida a entrada do usuário, garantindo que o número esteja entre 1 e 100.
- Caso o número do usuário seja maior ou menor do que o número gerado pela máquina, o jogo indicará se o usuário venceu ou perdeu.
- O usuário pode jogar novamente ou encerrar o jogo a qualquer momento.

## Tecnologias

Este jogo foi desenvolvido utilizando C# e pode ser executado em qualquer ambiente que suporte o .NET.

## Melhorias Futuras

- Adicionar limites de tentativas para o usuário.
- Melhorar a interface gráfica, substituindo a interface de console por uma visual.
- Implementar níveis de dificuldade (fácil, médio, difícil) com intervalos diferentes para os números.



