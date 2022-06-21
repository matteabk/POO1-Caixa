using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_HERANÇA___POLIMORFISMO
{
    public class Contrato
    {
        public Guid IdContrato { get; private set; } = Guid.NewGuid();
        public string Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }

        public virtual void coletarInfo()
        {
            Console.WriteLine("Digite o nome da contratante:");
            Contratante = Console.ReadLine();
            Console.WriteLine("Digite o valor do contrato:");
            Valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o prazo em meses do contrato:");
            Prazo = int.Parse(Console.ReadLine());
        }


        public virtual void calcularPrestação()
        {
        }

        public virtual void exibirInfo()
        {
            Console.WriteLine($"\r\nO código do contrato é: {IdContrato}");
            Console.WriteLine($"O nome do contratante é: {Contratante}");
            Console.WriteLine($"O valor do contrato é: R${Valor}");
            Console.WriteLine($"O prazo do contrato é: {Prazo} mes(es)");
        }
    }
}
