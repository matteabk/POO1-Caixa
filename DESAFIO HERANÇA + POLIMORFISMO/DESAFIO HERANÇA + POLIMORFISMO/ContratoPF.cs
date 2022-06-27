using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DESAFIO_HERANÇA___POLIMORFISMO
{
    public class ContratoPF : Contrato
    {
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public int Idade { get { return IdadeCalculada(); } }

        private int IdadeCalculada()
        {
            if (Nascimento.Month > DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year) - 1;
            }
            else if (Nascimento.Month < DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year);
            }
            else
            {
                if (Nascimento.Day < DateTime.Now.Day)
                {
                    return (DateTime.Now.Year - Nascimento.Year);
                }
                else
                {
                    return (DateTime.Now.Year - Nascimento.Year) - 1;
                }
            }
        }

        public override void coletarInfo()
        {
            base.coletarInfo();
            Console.WriteLine("Digite o CPF do contratante:");
            validateCPF();
            Console.WriteLine("Digite o nascimento do contratante:");
            validateBirth();
        }

        public override void exibirInfo()
        {
            base.exibirInfo();
            Console.WriteLine($"O CPF do contratante é: {Cpf}");
            Console.WriteLine($"A idade do contratante é: {Idade} anos.");
        }

        public override void calcularPrestação()
        {
            if (Idade <= 30)
            {
                var prestacao = (Valor / Prazo) + 1;
                Console.WriteLine($"O valor da prestação é de R$ {prestacao}\r\n");
            }
            else if (Idade <= 40)
            {
                var prestacao = (Valor / Prazo) + 2;
                Console.WriteLine($"O valor da prestação é de R$ {prestacao}\r\n");
            }
            else if (Idade <= 50)
            {
                var prestacao = (Valor / Prazo) + 3;
                Console.WriteLine($"O valor da prestação é de R$ {prestacao}\r\n");
            }
            else 
            {
                var prestacao = (Valor / Prazo) + 4;
                Console.WriteLine($"O valor da prestação é de R$ {prestacao}\r\n");
            }

        }

        public void validateCPF()
        {
            var typedCPF = Console.ReadLine();
            var formattedCPF = Regex.Replace(typedCPF, "[^0-9]+", string.Empty);

            if (formattedCPF.Length == 11)
            {
                Cpf = formattedCPF;
            }

            else
            {
                Console.WriteLine("CPF inválido, por favor digite novamente:");
                validateCPF();
            }
        }

        public void validateBirth()
        {
            DateTime birthDate;
            if (DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Nascimento = birthDate;
            }

            else
            {
                Console.WriteLine("Por favor, digite uma data válida:");
                validateBirth();
            }

        }

    }
}
