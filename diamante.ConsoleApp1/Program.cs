﻿internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            // função responsavel pela filtragem do valor que sera inserido pelo usuario
            int valorUsuarioDigitou = ValorUsuarioDigitou(0);

            Diamante(valorUsuarioDigitou);

            Console.ReadLine();
        }
    }

    static int ValorUsuarioDigitou(int valor)
    {

        do
        {
            Console.Clear();
            Console.WriteLine("Digite um valor impar: ");
            string strValor = Console.ReadLine()!;

            // Criacao da linha de codigo responsavel por verificar se o valor é um numero
            bool sucesso = int.TryParse(strValor, out valor);

            if (!sucesso)
            {
                Console.WriteLine("Isso não é um numero impar. Clique ENTER para tentar novamente");
                Console.ReadLine();
                continue;
            }

            else
            {
                // criacao do comparador responsavel por verificar se um numero é par
                if (valor % 2 == 0)
                {
                    Console.WriteLine("Isso não é um valor impar. Digite novamente: ");
                    Console.ReadLine();
                }
            }
        } while (valor % 2 == 0);
        return valor;
    }

    static void Diamante(int desenhoDasLinhas)
    {
        // Armazenadores das linhas, o quantidade maximo desses armazenadores
        // serao o valor impar que o usuario digitou
        string[] geradorDeLinhas = new string[(desenhoDasLinhas / 2) + 1]; // essa divisao com a soma da +1 é para que o contador não saia do range
        string[] espacosNaEsquerda = new string[(desenhoDasLinhas / 2) + 1];

        string meio = "-";


        // Parte de cima do diamante. 
        //- a quantidade de espacos do lado esquerdo é o que dará a impressao que sera um desenho de um diamante
        for (int contadorLinhas = 0, contadorEspaco = (desenhoDasLinhas) / 2; contadorEspaco >= 0; contadorLinhas++, contadorEspaco--)
        {
            espacosNaEsquerda[contadorEspaco] = new string(' ', contadorEspaco);
            geradorDeLinhas[contadorLinhas] = new string('-', contadorLinhas);

            Console.WriteLine($"{espacosNaEsquerda[contadorEspaco]}{geradorDeLinhas[contadorLinhas]}{meio}{geradorDeLinhas[contadorLinhas]}");
        }
        // Parte de baixo do diamante. 
        //- a quantidade de espacos estara aumentando, diferente do for de cima 
        for (int contadorLinhas = (desenhoDasLinhas / 2) - 1, contadorEspaco = 1; contadorLinhas >= 0; contadorLinhas--, contadorEspaco++)
        {
            espacosNaEsquerda[contadorEspaco] = new string(' ', contadorEspaco);
            geradorDeLinhas[contadorLinhas] = new string('-', contadorLinhas);

            Console.WriteLine($"{espacosNaEsquerda[contadorEspaco]}{geradorDeLinhas[contadorLinhas]}{meio}{geradorDeLinhas[contadorLinhas]}");
        }

        Console.ReadLine();
    }
}