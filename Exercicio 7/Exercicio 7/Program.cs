using System;

namespace VerificaData
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            // leitura dos valores de dia, mês e ano
            Console.Write("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            // verifica se o ano é válido
            if (ano < 1900 || ano > 2999)
            {
                Console.WriteLine("Data inválida.");
            }
            else
            {
                // verifica o número de dias do mês
                int numDias;
                switch (mes)
                {
                    case 2:
                        if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) // ano bissexto: div por 4, e não div por 100, ou se for div por 400 ele é bissexto
                        {
                            numDias = 29;
                        }
                        else
                        {
                            numDias = 28;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        numDias = 30;
                        break;
                    default:
                        numDias = 31;
                        break;
                }

                // verifica se o dia é válido
                if (dia < 1 || dia > numDias)
                {
                    Console.WriteLine("Data inválida.");
                }
                else
                {
                    Console.WriteLine("Data válida.");
                }
            }

            Console.ReadKey();
        }
    }
}