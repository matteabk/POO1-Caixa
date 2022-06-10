using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA05
{
    internal class Caixa
    {
        public DateTime DataCaixa { get; private set; }

        //public decimal Saldo { get; set; } //COM O SET PUBLICO, FICA ABERTO PARA ALTERAR O VALOR DO SALDO EXTERNAMENTE (NO PROGRAM) E NÃO QUEREMOS ISSO.

        public decimal Saldo { get; private set; } //COM PRIVATE SET O VALOR DO SALDO SÓ É DEFINIDO VIA MÉTODO!

        public decimal Venda { get; private set; }
        public decimal ValorPago { get; private set; }
        public decimal Troco { get; private set; }

        public void AbrirCaixa (decimal saldoInicial = 0)
        {
            DataCaixa = DateTime.Now;
            saldoInicial = Saldo;
        }

        public void Deposita()
        {
            Console.WriteLine("Digite o valor que você deseja depositar:");
            var valorDepositado = decimal.Parse(Console.ReadLine());
            Saldo += valorDepositado;
        }

        public void Saca()
        {
            Console.WriteLine("Digite o valor que você deseja sacar:");
            var valor = decimal.Parse(Console.ReadLine());
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Você não tem saldo suficiente para sacar.");
            }
        }

        public void CalcularTroco()
        {
            Console.WriteLine("Valor total dos produtos foi de:");
            Venda = decimal.Parse(Console.ReadLine());

            Console.WriteLine("O cliente pagou:");
            ValorPago = decimal.Parse(Console.ReadLine());

            Troco = ValorPago - Venda;

            if (Troco > 0)
            {
                Console.WriteLine($"O troco total do cliente foi de {Troco} reais.");
            }
            else if (Troco == 0)
            {
                Console.WriteLine($"Não é necessário troco.");
            }
            else
            {
                Console.WriteLine($"O cliente falta pagar {Venda - ValorPago} reais. Insira novamente os valores.");
                CalcularTroco();
            }
        }

        public void DevolverTroco()
        {
            Saldo += ValorPago; //SOMANDO AO SALDO O VALOR PAGO PELO CLIENTE
            Saldo -= Troco; //SUBTRAINDO DO SALDO O VALOR DO TROCO DEVOLVIDO PARA O CLIENTE

            Console.WriteLine($"Seu saldo atual é de {Saldo} reais");
        }

    }
}
