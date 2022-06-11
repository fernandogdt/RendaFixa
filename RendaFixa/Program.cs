using RendaFixa.Metodos;
using System;

namespace RendaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            string vr_opcao;

            MostraMenu();
            vr_opcao = Console.ReadLine();

            while (vr_opcao != "0")
            {
                
                switch (vr_opcao)
                {
                    case "1":
                        Rotinas.Insereinstituicao();
                        break;
                    case "2":
                        Rotinas.ListaDados(1);
                        break;
                    case "3":
                        Rotinas.InsereModalidade();
                        break;
                    case "4":
                        Rotinas.Inseretipoaplicacao();
                        break;
                    case "5":
                        Rotinas.Insereaplicacao();
                        break;
                    default:
                        break;
                }
                    
              
                MostraMenu();
                vr_opcao = Console.ReadLine();
            }
        }

        public static void MostraMenu()
        {

            Console.Clear();
            Console.WriteLine("1- Incluir Instituicao");
            Console.WriteLine("2- Listar instituicoes");
            Console.WriteLine("3- Incluir modalidade (CDB/LCA/...)");
            Console.WriteLine("4- Incluir tipo (PREFIXADO/POSFIXADO/IPCA)");
            Console.WriteLine("5- Incluir aplicacao");
            Console.WriteLine("0- Sair");
            Console.WriteLine();
            Console.Write("Informe a opcao desejada: ");

        }




        

    }
}
