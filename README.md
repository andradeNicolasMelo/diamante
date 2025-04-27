![](https://imgur.com/nscHnt5.gif)

# Gerador de Diamante

Este projeto em C# gera um diamante no console, baseado em um n�mero �mpar que o usu�rio fornece.

## Descri��o

O programa solicita um n�mero �mpar ao usu�rio e, a partir disso:

1. **Cria dois arrays**:
   - Um array que define quantos tra�os (`-`) ter�o em cada linha.
   - Outro array que define quantos espa�os ir�o empurrar os tra�os, criando o formato do diamante.

2. **Desenha o diamante**:
   - A **parte de cima** come�a com poucos tra�os e muitos espa�os, fazendo o diamante subir.
   - O **meio** tem o maior n�mero de tra�os e nenhum espa�o.
   - A **parte de baixo** faz o diamante descer, com menos tra�os e mais espa�os.

## Como Funciona

1. **Entrada do Usu�rio**: O usu�rio fornece um n�mero �mpar, como `5`.
2. **Gera��o das Linhas**: O programa cria as linhas de tra�os (`-`), come�ando com um tra�o, depois dois, e assim por diante, at� chegar ao meio.
3. **Organiza��o dos Espa�os**: Os espa�os empurram os tra�os, fazendo a linha parecer estar inclinada. O n�mero de espa�os vai diminuindo conforme o diamante sobe, e aumentando quando desce.

Exemplo para o n�mero `5`:

```
COM OS ESPA�OS:

Espa�os = x
Tra�os = -

xx-
x---
-----
x---
xx-

SEM OS ESPA�OS:

Tra�os = -

-
---
----
--
-
```

## Por baixo dos panos
`N�o se trata do desenho de um diamante`, se trata da gera��o de tra�os que aumentam a cada linha, apenas os espa�os d�o a sensa��o que se trata de um diamante 