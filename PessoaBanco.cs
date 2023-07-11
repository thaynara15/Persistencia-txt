using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace persistência_txt
{
    class PessoaBanco
    {
        private string arquivoNome;
        private bool debug;

        public PessoaBanco()
        {
            this.arquivoNome = "banco_pessoas.txt";
            this.debug = true;
        }

        public bool Gravar(Pessoa p)
        {

            try
            {
                //Importamos using System.IO;
                //StremWriter(par_1, par_2)
                //par_1 = Caminho do arquivo com o nome
                //par_2 = false apaga tudo e escreve um nome, true mantém os dados existentes
                StreamWriter sw = new StreamWriter(this.arquivoNome, true);



                //sw.WriteLine(string); //Grava uma informação
                sw.WriteLine(string.Format("Nome: {0} | Email: {1}", p.Nome, p.Email));

                //Fecha o arquivo
                sw.Close();


                return true;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
        }


        public List<string> RetornarDados()
        {
            try
            {
                StreamReader sr = new StreamReader(this.arquivoNome);
                List<string> listaPessoa = new List<string>();

                while (!sr.EndOfStream)
                {
                    listaPessoa.Add(sr.ReadLine());
                }
                sr.Close();

                return listaPessoa;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    Console.WriteLine(ex.Message);
                }
                return null;
            }
        }
    }
}