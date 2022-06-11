using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace RendaFixa.Metodos
{
    class Rotinas
    {

        public static void ListaDados(int origem)
        {
            using (MySqlConnection cnn = new MySqlConnection())
            {
                cnn.ConnectionString = "server=127.0.0.1;database=rendafixa;uid=root;pwd=123456;port=3306";
                cnn.Open();

                string sqlconsulta = "";
                switch (origem)
                {
                    case 1:
                        sqlconsulta = "select * from  tb_instituicao";
                        break;
                    case 2:
                        sqlconsulta = "select * from  tb_tipoaplicacao";
                        break;
                    case 3:
                        sqlconsulta = "select * from  tb_modalidade";
                        break;
                    case 4:
                        sqlconsulta = "select * from  tb_aplicacao";
                        break;
                    case 5:
                        sqlconsulta = "select * from  tb_posicao";
                        break;
                    default:
                        break;
                }
                // string sqlconsulta = "select * from  tb_instituicao";

                var cmd = new MySqlCommand(sqlconsulta, cnn);

                MySqlCommand cmdconsulta = new MySqlCommand(sqlconsulta, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine("{0}", rdr.GetString(1));
                }
                Console.Read();

            }
        }





        public static void Insereinstituicao()
        {
            string dsinstituicao;

            try
            {
                Console.WriteLine();
                Console.Write("Instituicao: ");
                dsinstituicao = Console.ReadLine().ToUpper();

                using (MySqlConnection cnn = new MySqlConnection())
                {

                    cnn.ConnectionString = "server=127.0.0.1;database=rendafixa;uid=root;pwd=123456;port=3306";
                    cnn.Open();

                    var sql = "insert into tb_instituicao (dsinstituicao) values (@dsinstituicao)";

                    using (var cmd = new MySqlCommand(sql, cnn))
                    {
                        //  cmd.Parameters.AddWithValue("@idinstituicao", idinstituicao);
                        cmd.Parameters.AddWithValue("@dsinstituicao", dsinstituicao);

                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine();
                ListaDados(1);
                Console.WriteLine();
                Console.WriteLine("Registro inserido com sucesso!!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        public static void Inseretipoaplicacao()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Tipo: ");
                string dstipoaplicacao = Console.ReadLine().ToUpper();

                using (MySqlConnection cnn = new MySqlConnection())
                {

                    cnn.ConnectionString = "server=127.0.0.1;database=rendafixa;uid=root;pwd=123456;port=3306";
                    cnn.Open();

                    var sql = "insert into tb_tipoaplicacao (dstipoaplicacao) values (@dstipoaplicacao)";

                    using (var cmd = new MySqlCommand(sql, cnn))
                    {
                        //  cmd.Parameters.AddWithValue("@idinstituicao", idinstituicao);
                        cmd.Parameters.AddWithValue("@dstipoaplicacao", dstipoaplicacao);

                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine();
                ListaDados(2);
                Console.WriteLine();
                Console.WriteLine("Tipo de aplicacao inserido com sucesso!!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        public static void InsereModalidade()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Modalidade: ");
                string dsmodalidade = Console.ReadLine().ToUpper();

                using (MySqlConnection cnn = new MySqlConnection())
                {

                    cnn.ConnectionString = "server=127.0.0.1;database=rendafixa;uid=root;pwd=123456;port=3306";
                    cnn.Open();

                    var sql = "insert into tb_modalidade (dsmodalidade) values (@dsmodalidade)";

                    using (var cmd = new MySqlCommand(sql, cnn))
                    {
                        //  cmd.Parameters.AddWithValue("@idinstituicao", idinstituicao);
                        cmd.Parameters.AddWithValue("@dsmodalidade", dsmodalidade);

                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine();
                ListaDados(3);
                Console.WriteLine();
                Console.WriteLine("Modalidade inserido com sucesso!!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }

        public static void Insereaplicacao()
        {

            int idinstituicao, idtipoaplicacao, idmodalidade, inimposto, inliquidez;
            string dsrendimento;
            DateTime dtvencimento;

            try
            {
                Console.WriteLine();
                Console.Write("Codigo instituicao: ");
                idinstituicao = int.Parse(Console.ReadLine());
                Console.Write("Codigo tipo aplicacao: ");
                idtipoaplicacao = int.Parse(Console.ReadLine());
                Console.Write("Codigo modalidade: ");
                idmodalidade = int.Parse(Console.ReadLine());
                Console.Write("Rendimento: ");
                dsrendimento = Console.ReadLine();
                Console.Write("Vencimento: ");
                dtvencimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Cobra imposto (0-Não / 1-Sim): ");
                inimposto = int.Parse(Console.ReadLine());
                Console.Write("Liquidez diaria (0-Não / 1-Sim): ");
                inliquidez = int.Parse(Console.ReadLine());


                using (MySqlConnection cnn = new MySqlConnection())
                {

                    cnn.ConnectionString = "server=127.0.0.1;database=rendafixa;uid=root;pwd=123456;port=3306";
                    cnn.Open();

                    var sql = "insert into tb_aplicacao (idinstituicao, idtipoaplicacao, idmodalidade, inimposto, dsrendimento, dtvencimento, inliquidez) " +
                        "                                values (@idinstituicao, @idtipoaplicacao, @idmodalidade, @inimposto, @dsrendimento, @dtvencimento, @inliquidez)";

                    using (var cmd = new MySqlCommand(sql, cnn))
                    {

                        cmd.Parameters.AddWithValue("@idinstituicao", idinstituicao);
                        cmd.Parameters.AddWithValue("@idtipoaplicacao", idtipoaplicacao);
                        cmd.Parameters.AddWithValue("@idmodalidade", idmodalidade);
                        cmd.Parameters.AddWithValue("@inimposto", inimposto);
                        cmd.Parameters.AddWithValue("@dsrendimento", dsrendimento);
                        cmd.Parameters.AddWithValue("@dtvencimento", dtvencimento);
                        cmd.Parameters.AddWithValue("@inliquidez", inliquidez);
                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine();
                ListaDados(4);
                Console.WriteLine();
                Console.WriteLine("Registro inserido com sucesso!!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }



        /******
        public static void Insereregistro(int tptabela)
        {
            try
            {
               switch (tptabela)
                {
                    case 1:



                } 
                
                
                
                Console.WriteLine();
                Console.Write("Tipo: ");
                string dstipoaplicacao = Console.ReadLine().ToUpper();

                using (MySqlConnection cnn = new MySqlConnection())
                {

                    cnn.ConnectionString = "server=127.0.0.1;database=rendafixa;uid=root;pwd=123456;port=3306";
                    cnn.Open();

                    var sql = "insert into tb_tipoaplicacao (dsitipoaplicacao) values (@dsitipoaplicacao)";

                    using (var cmd = new MySqlCommand(sql, cnn))
                    {
                        //  cmd.Parameters.AddWithValue("@idinstituicao", idinstituicao);
                        cmd.Parameters.AddWithValue("@dsinstituicao", dstipoaplicacao);

                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine();
                ListaDados();
                Console.WriteLine();
                Console.WriteLine("Tipo de aplicacao inserido com sucesso!!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        ****/

    }
}
