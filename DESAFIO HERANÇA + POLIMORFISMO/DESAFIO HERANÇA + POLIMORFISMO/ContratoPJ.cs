using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Cnpj = Console.ReadLine();
            Console.WriteLine("Digite a inscrição estadual da empresa");
            Inscricao = Console.ReadLine();

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
    }
}
