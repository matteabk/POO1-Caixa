using System;

namespace AULA_04_e_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorretaEspecie = false;
            bool respostaCorretaPorte = false;
            bool apresentaDoenca = true;

            Animal novoAnimal = new Animal(); //TRANSFORMAR A CLASSE EM UM OBJETO, INSTANCIAR.//
            Console.WriteLine("-- CADASTRO DO ANIMAL --");
            Console.WriteLine("Qual o nome do seu animal?");
            novoAnimal.Nome = Console.ReadLine(); //LER INPUT E POR NO OBJETO//

            Console.WriteLine("Qual a espécie do seu animal? (Cachorro / Gato)");
            while (respostaCorretaEspecie == false)
            {
                var respostaEspecie = Console.ReadLine();
                if (Enum.IsDefined(typeof(Especie), respostaEspecie))
                {
                    novoAnimal.Especie = Enum.Parse<Especie>(respostaEspecie);
                    respostaCorretaEspecie = true;
                }
                else
                {
                    Console.WriteLine("Digite uma espécie válida (Cachorro / Gato):");
                    continue;
                }
            }

            Console.WriteLine("Qual a raça do seu animal?");
            novoAnimal.Raca = Console.ReadLine();

            Console.WriteLine("Qual a cor do seu animal?");
            novoAnimal.Cor = Console.ReadLine();

            Console.WriteLine("Qual é o porte do seu animal?");
            while (respostaCorretaPorte == false)
            {
                var respostaPorte = Console.ReadLine();
                if (Enum.IsDefined(typeof(Porte), respostaPorte))
                {
                    novoAnimal.Porte = Enum.Parse<Porte>(respostaPorte);
                    respostaCorretaPorte = true;
                }
                else
                {
                    Console.WriteLine("Digite um porte (Pequeno / Grande):");
                    continue;
                }
            }

            Console.WriteLine("Qual é o peso do seu animal?");
            novoAnimal.Peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a data de nascimento do seu animal?"); //VALIDAR DATA PÓS AULA
            novoAnimal.Nascimento = DateTime.Parse(Console.ReadLine()); //SÓ ATENDER ANIMAIS COM 2 MESES DE IDADE NO MINIMO

            Console.WriteLine("Seu animal possui alguma doença ou alergia? (Sim / Não)");
            var possuiAlergiaDoenca = Console.ReadLine();
            if (possuiAlergiaDoenca == "Sim" || possuiAlergiaDoenca == "sim")
            {
                while (apresentaDoenca == true)
                {
                    Console.WriteLine("Qual tipo de alergia ou doença ele apresenta?");
                    novoAnimal.AdicionarDoencaAlergia(Console.ReadLine());

                    Console.WriteLine("Deseja continuar adicionando doenças / alergias?");
                    if (Console.ReadLine() == "Não" || Console.ReadLine() == "não")
                    {
                        apresentaDoenca = false;
                    }
                    else
                    {
                        apresentaDoenca = true;
                    }
                }
            }

            Console.WriteLine("Seu animal é agressivo?");
            novoAnimal.Agressivo = bool.Parse(Console.ReadLine());

            Console.WriteLine("Qual o sexo do seu animal? (M / F)");
            novoAnimal.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Seu animal é castrado?");
            novoAnimal.Castrado = bool.Parse(Console.ReadLine());

            novoAnimal.ImprimirAnimal();
        }
    }
}
