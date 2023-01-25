using System;
namespace praticaProjeto
{
    internal class MenuHandler
    {
        public static void mainMenu()
        {

            Console.Clear();
            Console.WriteLine("1. Menu admin.");
            Console.WriteLine("2. Menu User.");
            Console.WriteLine("3. Sair.\n");
            Console.WriteLine(".");

        }

        public static void menuAdmin() {

            Console.Clear();
            Console.WriteLine("1. Ver zonas.");
            Console.WriteLine("2. Ver historico.");
            Console.WriteLine("3. Sair.\n");
            Console.WriteLine(".");

        }

        public static void menuCliente() {

            Console.Clear();
            Console.WriteLine("1. Estacionar.");
            Console.WriteLine("2. Ver historico.");
            Console.WriteLine("3. Sair.\n");
            Console.WriteLine(".");

        }


    }
}

