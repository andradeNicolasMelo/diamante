internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            int valorUsuarioDigitou = ValorUsuarioDigitou(0);

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
}