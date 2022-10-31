using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CRONÔMETRO:");
            Console.WriteLine("S = SEGUNDOS => 10s = 10 segundos");
            Console.WriteLine("M = MINUTOS => 1m = 1 minuto");
            Console.WriteLine("0 = SAIR");
            Console.WriteLine("QUANTO TEMPO DESEJA CONTAR?");

            string dados = Console.ReadLine().ToLower();
            char tipo = char.Parse(dados.Substring(dados.Length - 1, 1));
            int tempo = int.Parse(dados.Substring(0, dados.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            PreInicio(tempo * multiplicador);

        }

        static void PreInicio(int tempo)
        {
            Console.Clear();
            Console.WriteLine("PREPARAR...");
            Thread.Sleep(1000);
            Console.WriteLine("APONTAR...");
            Thread.Sleep(1000);
            Console.WriteLine("FOGO!!!");
            Thread.Sleep(2000);

            Inicio(tempo);
        }

        static void Inicio(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                tempoAtual++;
                Console.Clear();
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2000);
            Menu();

        }


    }
}
