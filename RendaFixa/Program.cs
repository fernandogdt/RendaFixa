using RendaFixa.Metodos;
using System;

namespace RendaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            string vr_opcao;

            Rotinas.MenuPrincipal();
            vr_opcao = Console.ReadLine();
            while (vr_opcao != "0")
            {
                switch (vr_opcao)
                {
                    case "1":

                        Rotinas.MenuGerencial();
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
                                    Rotinas.ListaDados(2);
                                    break;
                                case "5":
                                    Rotinas.Inseretipoaplicacao();
                                    break;
                                case "6":
                                    Rotinas.ListaDados(3);
                                    break;
                                case "7":
                                    Rotinas.Insereaplicacao();
                                    break;
                                case "8":
                                    Rotinas.ListaDados(4);
                                    break;
                                default:
                                    break;
                            }
                            Rotinas.MenuGerencial();
                            vr_opcao = Console.ReadLine();
                            

                        }
                        break;

                    /*          case "2":
                                  Rotinas.MenuAplicacao();
                                  break;*/
                    default:
                        break;
                }
                Rotinas.MenuPrincipal();
                vr_opcao = Console.ReadLine();

            }
            }


              
               

    }
}
