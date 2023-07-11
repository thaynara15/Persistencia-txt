using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace persistência_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe o seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe o seu e-mail: ");
            pessoa.Email = Console.ReadLine();

            PessoaBanco banco = new PessoaBanco();
            banco.Gravar(pessoa);
            //-----------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            Console.ResetColor();

            foreach (string p in banco.RetornarDados())
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}

        

       
            
