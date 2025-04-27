![](https://imgur.com/nscHnt5.gif)

# Gerador de Diamante

Este projeto em C# gera um diamante no console, baseado em um número ímpar que o usuário fornece.

## Descrição

O programa solicita um número ímpar ao usuário e, a partir disso:

1. **Cria dois arrays**:
   - Um array que define quantos traços (`-`) terão em cada linha.
   - Outro array que define quantos espaços irão empurrar os traços, criando o formato do diamante.

2. **Desenha o diamante**:
   - A **parte de cima** começa com poucos traços e muitos espaços, fazendo o diamante subir.
   - O **meio** tem o maior número de traços e nenhum espaço.
   - A **parte de baixo** faz o diamante descer, com menos traços e mais espaços.

## Como Funciona

1. **Entrada do Usuário**: O usuário fornece um número ímpar, como `5`.
2. **Geração das Linhas**: O programa cria as linhas de traços (`-`), começando com um traço, depois dois, e assim por diante, até chegar ao meio.
3. **Organização dos Espaços**: Os espaços empurram os traços, fazendo a linha parecer estar inclinada. O número de espaços vai diminuindo conforme o diamante sobe, e aumentando quando desce.

Exemplo para o número `5`:

```
COM OS ESPAÇOS:

Espaços = x
Traços = -

xx-
x---
-----
x---
xx-

SEM OS ESPAÇOS:

Traços = -

-
---
----
--
-
```

## Por baixo dos panos
`Não se trata do desenho de um diamante`, se trata da geração de traços que aumentam a cada linha, apenas os espaços dão a sensação que se trata de um diamante 