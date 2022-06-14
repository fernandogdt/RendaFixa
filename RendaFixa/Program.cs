using RendaFixa.Metodos;
using System;

namespace RendaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int cdmenuprincipal = 0;
            string cdmenuopcao = "C";


            try
            {



                Rotinas.MenuPrincipal();
                cdmenuprincipal = int.Parse(Console.ReadLine());
                while (cdmenuprincipal != 0)
                {
                    switch (cdmenuprincipal)
                    {
                        case 1:  //Instituicao

                            Rotinas.MenuOpcao(cdmenuprincipal);

                            cdmenuopcao = Console.ReadLine().ToUpper();

                            while (cdmenuopcao != "0")
                            {
                                switch (cdmenuopcao)
                                {
                                    case "C":
                                        Rotinas.ListaDados(cdmenuprincipal);
                                        break;
                                    case "I":
                                        Rotinas.Insereinstituicao(); 
                                        break;
                                    case "A":
                                        break;
                                    case "E":
                                        break;
                                    default:
                                        break;
                                }
                                Rotinas.MenuOpcao(cdmenuprincipal);

                                cdmenuopcao = Console.ReadLine().ToUpper();
                            }
                            break;

                        case 2: // Tipo Aplicacao 
                            Rotinas.MenuOpcao(cdmenuprincipal);

                            cdmenuopcao = Console.ReadLine().ToUpper();

                            while (cdmenuopcao != "0")
                            {
                                switch (cdmenuopcao)
                                {
                                    case "C":
                                        Rotinas.ListaDados(cdmenuprincipal);
                                        break;
                                    case "I":
                                        Rotinas.Inseretipoaplicacao();
                                        break;
                                    case "A":
                                        break;
                                    case "E":
                                        break;
                                    default:
                                        break;
                                }
                                Rotinas.MenuOpcao(cdmenuprincipal);

                                cdmenuopcao = Console.ReadLine().ToUpper();
                            }
                            break;
                        case 3: // Modalidade
                            Rotinas.MenuOpcao(cdmenuprincipal);

                            cdmenuopcao = Console.ReadLine().ToUpper();

                            while (cdmenuopcao != "0")
                            {
                                switch (cdmenuopcao)
                                {
                                    case "C":
                                        Rotinas.ListaDados(cdmenuprincipal);
                                        break;
                                    case "I":
                                        Rotinas.InsereModalidade();
                                        break;
                                    case "A":
                                        break;
                                    case "E":
                                        break;
                                    default:
                                        break;
                                }
                                Rotinas.MenuOpcao(cdmenuprincipal);

                                cdmenuopcao = Console.ReadLine().ToUpper();
                            }
                            break;
                        case 4: //aplicacao
                            Rotinas.MenuOpcao(cdmenuprincipal);

                            cdmenuopcao = Console.ReadLine().ToUpper();

                            while (cdmenuopcao != "0")
                            {
                                switch (cdmenuopcao)
                                {
                                    case "C":
                                        Rotinas.ListaDados(cdmenuprincipal);
                                        break;
                                    case "I":
                                        Rotinas.Insereaplicacao();
                                        break;
                                    case "A":
                                        break;
                                    case "E":
                                        break;
                                    default:
                                        break;
                                }
                                Rotinas.MenuOpcao(cdmenuprincipal);

                                cdmenuopcao = Console.ReadLine().ToUpper();
                            }
                            break;
                        case 5: // Lancamentos
                            Rotinas.MenuOpcao(cdmenuprincipal);

                            cdmenuopcao = Console.ReadLine().ToUpper();

                            while (cdmenuopcao != "0")
                            {
                                switch (cdmenuopcao)
                                {
                                    case "C":
                                        Rotinas.ListaDados(cdmenuprincipal);
                                        break;
                                    case "I":
                                     //   Rotinas.Inserelancamento();
                                        break;
                                    case "A":
                                        break;
                                    case "E":
                                        break;
                                    default:
                                        break;
                                }
                                Rotinas.MenuOpcao(cdmenuprincipal);

                                cdmenuopcao = Console.ReadLine().ToUpper();
                            }
                            break;
                        default:
                            break;


                    }

                    Rotinas.MenuPrincipal();
                    cdmenuprincipal = int.Parse(Console.ReadLine());
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Deu ruim:" + e.Message);
            }
        }





    }
}
