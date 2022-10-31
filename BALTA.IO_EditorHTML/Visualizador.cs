using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Visualizador
    {
        public static void Mostrar(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZADOR");
            Console.WriteLine("------------");
            Substituir(texto);
            Console.WriteLine("------------");
            Console.ReadKey();
        }

        public static void Substituir(string texto)
        {

            var strong = new Regex(@"<\s*azul[^>]*>(.*?)<\s*/\s*azul>");
            var words = texto.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" \n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(' ');

                }
            }
        }

    }
}
