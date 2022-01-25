using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LANCHONETE_LANCHE_BOM
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lanches = { "1 - X-SALADA  R$8,90", "2 - X-BACON   R$10,90", "3 - X-TUDO    R$15,90", "4 - CHURRASCO R$9,90", "5 - HOT DOG   R$7,90", "6 - SALGADOS  R$4,90" };
            string[] bebidas = { "1 - REFRIGERANTE   R$6,90", "2 - SUCO NATURAL   R$8,90", "3 - REFRESCO       R$4,90", "4 - ÁGUA MINERAL   R$3,90", "5 - CAFÉ EXPRESSO  R$2,90", "6 - CHOCOLATE      R$5,90" };
            List<string> pedidoL = new List<string>();
            List<string> pedidoB = new List<string>();
            double somaLanc = 0, somaBeb = 0, somaGL = 0, somaGB = 0;
            int quantLanc, quantBeb, cod;
            string lanche = "NÃO IDENTIFICADO", bebida = "NÃO IDENTIFICADO", resp;
            CultureInfo ci = new CultureInfo("pt-BR");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tLANCHONETE LANCHE BOM");
                Console.WriteLine("\t       LANCHES");
                Console.ResetColor();
                Console.WriteLine("Escolha uma opção e digite o código correspondente");
                Console.WriteLine(" ");
                foreach (string lancs in lanches)
                {
                    Console.WriteLine("\t{0}", lancs);
                }
                Console.WriteLine(" ");
                Console.Write("CÓDIGO: ");
                cod = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Insira a quantidade: ");
                quantLanc = int.Parse(Console.ReadLine());
                switch (cod)
                {
                    case 1:
                        somaLanc = quantLanc * 8.90;
                        lanche = "X-SALADA";
                        break;
                    case 2:
                        somaLanc = quantLanc * 10.90;
                        lanche = "X-BACON";
                        break;
                    case 3:
                        somaLanc = quantLanc * 15.90;
                        lanche = "X-TUDO";
                        break;
                    case 4:
                        somaLanc = quantLanc * 9.90;
                        lanche = "CHURRASCO";
                        break;
                    case 5:
                        somaLanc = quantLanc * 7.90;
                        lanche = "HOT DOG";
                        break;
                    case 6:
                        somaLanc = quantLanc * 4.90;
                        lanche = "SALGADOS";
                        break;
                    default:
                        Console.WriteLine("ERRO! Quantidade ou código de item inválido");
                        break;
                }
                somaGL = somaGL + somaLanc;
                if (lanche == "HOT DOG" || lanche == "X-BACON" || lanche == "X-TUDO")
                {
                    pedidoL.Add("\n" + quantLanc.ToString() + "\t" + lanche + "\t\t" + somaLanc.ToString("c", ci));
                }
                else
                {
                    pedidoL.Add("\n" + quantLanc.ToString() + "\t" + lanche + "\t" + somaLanc.ToString("c", ci));
                }
                Console.WriteLine("Deseja pedir mais um lanche? (S/N)");
                resp = Console.ReadLine();
                Console.Clear();
            } while (resp == "s" || resp == "S");
            do
            {
                Console.WriteLine("\tLANCHONETE LANCHE BOM");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t     BEBIDAS");
                Console.ResetColor();
                Console.WriteLine("Escolha uma opção e digite o código correspondente");
                Console.WriteLine(" ");
                foreach (string bebis in bebidas)
                {
                    Console.WriteLine("\t{0}", bebis);
                }
                Console.WriteLine(" ");
                Console.Write("CÓDIGO: ");
                cod = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Insira a quantidade: ");
                quantBeb = int.Parse(Console.ReadLine());
                switch (cod)
                {
                    case 1:
                        somaBeb = quantBeb * 6.90;
                        bebida = "REFRIGERANTE";
                        break;
                    case 2:
                        somaBeb = quantBeb * 8.90;
                        bebida = "SUCO NATURAL";
                        break;
                    case 3:
                        somaBeb = quantBeb * 4.90;
                        bebida = "REFRESCO";
                        break;
                    case 4:
                        somaBeb = quantBeb * 3.90;
                        bebida = "ÁGUA MINERAL";
                        break;
                    case 5:
                        somaBeb = quantBeb * 2.90;
                        bebida = "CAFÉ EXPRESSO";
                        break;
                    case 6:
                        somaBeb = quantBeb * 5.90;
                        bebida = "CHOCOLATE";
                        break;
                    default:
                        Console.WriteLine("ERRO! Quantidade ou código de item inválido.");
                        break;
                }
                somaGB = somaGB + somaBeb;
                pedidoB.Add("\n" + quantBeb + "\t" + bebida + "\t" + somaBeb.ToString("c", ci));
                Console.WriteLine("Deseja pedir mais uma bebida? (S/N)");
                resp = Console.ReadLine();
                Console.Clear();
            } while (resp == "s" || resp == "S");
            Console.WriteLine("\tPEDIDO:");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tLANCHES");
            Console.ResetColor();
            foreach (string pLanches in pedidoL)
            {
                Console.WriteLine(" " + pLanches);
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tBEBIDAS");
            Console.ResetColor();
            foreach (string pBebidas in pedidoB)
            {
                Console.WriteLine(" " + pBebidas);
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOTAL: {0}", (somaGB + somaGL).ToString("c", ci));
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
