namespace CalculadoraConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do

            {


                Console.WriteLine("Calculadora Toppeeson");

                Console.WriteLine("Digite 1 para adição");

                Console.WriteLine("Digite 2 para subtração ");

                Console.WriteLine("Digite 3 para multiplicação");

                Console.WriteLine("Digita 4 para divisão ");

                Console.WriteLine("Digite S para sair"!);

                string operacao = Console.ReadLine();
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operacao Invalida tente novamente...");
                    Console.ReadLine();
                    continue;


                }
                if (operacao == "S" || operacao == "s")
                {
                    break;
                }
                Console.WriteLine();
                Console.Write("Digite o primeiro Numero: ");
                decimal primeironumero = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Digite o segundo Numero: ");
                decimal segundonumero = Convert.ToDecimal(Console.ReadLine());
                decimal resultado = 0;
                bool ehadicao = operacao == "1";
                bool ehsubtraçao = operacao == "2";
                bool ehmultiplicacao = operacao == "3";
                bool ehdivisao = operacao == "4";
                if (ehadicao) 
                    {
                    resultado = primeironumero + segundonumero;

                     
                 
                }
                else if (ehsubtraçao)
                {
                    resultado = primeironumero - segundonumero;
                }
                else if (ehmultiplicacao)
                {
                    resultado = primeironumero * segundonumero;

                }
                else if (ehdivisao)
                {
                    while(segundonumero == 0)
                    {
                        Console.WriteLine("Segundo numero não pode ser 0 ");
                        Console.ReadLine();
                        Console.WriteLine("Digite novamente o Segundo Numero ");
                        segundonumero = Convert.ToDecimal(Console.ReadLine());
                    }
                    resultado = primeironumero / segundonumero;
                }
                decimal resultadoformatado = Math.Round(resultado, 2);
                Console.WriteLine("O seu resultado é: " + resultadoformatado);
                Console.ReadLine();








    } while (true);
        }
    }
}