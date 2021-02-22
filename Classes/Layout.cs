using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            Console.WriteLine("                                     ");
            Console.WriteLine("     Digite a Opção desejada :       ");
            Console.WriteLine("    ============================     ");
            Console.WriteLine("     1 - Criar Conta                 ");
            Console.WriteLine("    ============================     ");
            Console.WriteLine("     2 - Entrar com CPF e Senha      ");
            Console.WriteLine("    ============================     ");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: 
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
            }
        }
    }

}
