# High-Low  ♣️ ♠️ ♥️ ♦️

## Descrição
High-Low é um sistema de contagem de cartas que leva em consideração o número de cartas altas e baixas do baralho, implementei usando C# e Windows Forms. O objetivo é acompanhar a contagem das cartas jogadas a partir de um total de 8 baralhos. O projeto indica visualmente a vantagem ou desvantagem do jogador com base na contagem atual.

## Funcionalidades

- **Contador:** Contagem das cartas jogadas em um setup de 8 baralhos.
- **Cor Dinâmica:** A cor do contador muda automaticamente com base no valor:
  - ⚪ **Branco:** Valor exato 24 (neutro).
  - 🔴 **Vermelho:** Valor abaixo de 24 (vantagem da mesa).
  - 🟡 **Amarelo:** Valor entre 25 e 31 (pouca vantagem ao jogador).
  - 🟢 **Verde:** Valor igual ou superior a 32 (vantagem do jogador).

- **Botões:** Cada carta possue um botão que realiza uma ação no contador, seja aumentando, diminuindo ou mantendo o valor:
  - **Botão de reset:** Reseta o contador para 24.
  - **Fechar e Minimizar:** O aplicativo possui botões para fechar e minimizar a janela da aplicação.

## Dependências:

- **.NET Framework:** O projeto é construído usando o .NET Framework. Certifique-se de que você tem a versão correta do framework instalada.
