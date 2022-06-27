using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DESAFIO_HERANÇA___POLIMORFISMO
{
    public class ContratoPJ : Contrato
    {
        public string Cnpj { get; set; }
        public string Inscricao { get; set; }


        public override void coletarInfo()
        {
            base.coletarInfo();
            Console.WriteLine("Digite o CNPJ do contratante:");
            validateCNPJ();
            Console.WriteLine("Digite a inscrição estadual da empresa");
            validateIE();

        }

        public override void exibirInfo()
        {
            base.exibirInfo();
            Console.WriteLine($"O CNPJ do contratante é: {Cnpj}");
            Console.WriteLine($"A inscrição do contratante é: {Inscricao}");
        }

        public override void calcularPrestação()
        {
            var prestacao = (Valor / Prazo) + 3;
            Console.WriteLine($"O valor da prestação é de R${prestacao}\r\n");
        }

        public void validateCNPJ()
        {
            var typedCNPJ = Console.ReadLine();
            string formattedCNPJ = Regex.Replace(typedCNPJ, "[^0-9]+", string.Empty);

            if (formattedCNPJ.Length == 14)
            {
                Cnpj = formattedCNPJ;
            }

            else
            {
                Console.WriteLine("CNPJ inválido. Por favor digitar novamente:");
                validateCNPJ();
            }

        }

        public void validateIE()
        {
            var typedIE = Console.ReadLine();
            var formattedIE =  Regex.Replace(typedIE, "[^0-9]+", string.Empty);

            if (formattedIE.Length == 9)
            {
                Inscricao = formattedIE;
            }

            else
            {
                Console.WriteLine("Insrição estadual inválida, por favor digite novamente:");
                validateIE();
            }
        }
    }
}
