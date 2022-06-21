using System;
using DESAFIO_HERANÇA___POLIMORFISMO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_HERANÇA___POLIMORFISMO
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool tipoContaCorreta = false;
            List<ContratoPF> contasPF = new List<ContratoPF>();
            List<ContratoPJ> contasPJ = new List<ContratoPJ>();

            while (tipoContaCorreta == false)
            {
                Console.WriteLine("Digite a opção desejada:\r\n1 - Registrar conta PF;\r\n2 - Registrar conta PJ;\r\n3 - Conferir contas PF cadastradas;\r\n4 - Conferir contas PJ cadastradas;\r\n5 - Encerrar programa.");
                var tipoContrato = Console.ReadLine();
                var tipoContrato1 = tipoContrato.ToUpper();

                switch (tipoContrato1)
                {
                    case "1":
                        var contaPF = new ContratoPF();

                        contaPF.coletarInfo();
                        contaPF.exibirInfo();
                        contaPF.calcularPrestação();
                        contasPF.Add(contaPF);
                        break;

                    case "2":
                        var contaPJ = new ContratoPJ();

                        contaPJ.coletarInfo();
                        contaPJ.exibirInfo();
                        contaPJ.calcularPrestação();
                        contasPJ.Add(contaPJ);
                        break;

                    case "3":
                        exibirListaPF();
                        break;

                    case "4":
                        exibirListaPJ();
                        break;

                    case "5":
                        Console.WriteLine("Encerrando programa.");
                        tipoContaCorreta = true;
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }
            }

            void exibirListaPF()
            {
                Console.Write($"Há {contasPF.Count} contratos de Pessoas Física registrados:\r\n");
                foreach (var contaPF in contasPF)
                {
                    contaPF.exibirInfo();
                    contaPF.calcularPrestação();
                }
            }

            void exibirListaPJ()
            {
                Console.Write($"Há {contasPJ.Count} contratos de Pessoa Jurídica registrados:\r\n");
                foreach (var contaPJ in contasPJ)
                {
                    contaPJ.exibirInfo();
                    contaPJ.calcularPrestação();
                }
            }
        }
    }
}
