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
            validateValue();
            Console.WriteLine("Digite o prazo em meses do contrato:");
            validateDeadLine();
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

        public void validateValue()
        {
            var valueRS = Console.ReadLine();
            var valueRS2 = valueRS.Trim();
            decimal val;
            if (decimal.TryParse(valueRS2, out val))
            {
                Valor = val;
            }

            else
            {
                Console.WriteLine("Valor inválido, por favor digite novamente:");
                validateValue();
            }
        }

        public void validateDeadLine()
        {
            var deadLine = Console.ReadLine();
            var deadLine2 = deadLine.Trim();
            int deadLineINT;
            if (int.TryParse(deadLine2, out deadLineINT) && deadLineINT > 0)
            {
                Prazo = deadLineINT;
            }

            else
            {
                Console.WriteLine("Prazo inválido, por favor digite novamente:");
                validateDeadLine();
            }
        }
    }
}
