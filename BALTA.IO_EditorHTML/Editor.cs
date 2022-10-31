using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Iniciar();
        }
        public static void Iniciar()
        {
            var arquivo = new StringBuilder();
            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Visualizador.Mostrar(arquivo.ToString());

        }
    }
}