using System;

namespace AULA05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixadoDia = new Caixa();

            caixadoDia.AbrirCaixa();

            Console.WriteLine($"Caixa aberto em: {caixadoDia.DataCaixa}");
            caixadoDia.Deposita();
            caixadoDia.Saca();

            Console.WriteLine(caixadoDia.Saldo);

            caixadoDia.CalcularTroco();

            caixadoDia.DevolverTroco();
        }
    }
}
