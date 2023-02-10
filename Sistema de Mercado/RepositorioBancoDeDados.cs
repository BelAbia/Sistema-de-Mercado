﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Sistema_de_Mercado
{
    internal class RepositorioBancoDeDados : IRepositorio
    {
        ListaSingleton listaSingleton = ListaSingleton.GetInstance();
        string strConexao = ConfigurationManager.ConnectionStrings["ConexaoSistemaDeMercado"].ConnectionString;
        SqlConnection? conexao;
        SqlCommand? comando;
        SqlDataReader? reader;
        string? querySQL;

        public void AtualizarProduto(Produto produto)
        {
            try
            {
                querySQL = "UPDATE tb_produto SET nome = @nome, marca = @marca, codigo_barras = @codigo_barras, data_vencimento = @data_vencimento, data_cadastro = @data_cadastro WHERE Id = @Id;";

                conexao = new(strConexao);
                comando = new SqlCommand(querySQL, conexao);

                comando.Parameters.AddWithValue("@Id", produto.Id);
                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@marca", produto.Marca);
                comando.Parameters.AddWithValue("@codigo_barras", produto.CodigoBarras);
                comando.Parameters.AddWithValue("@data_vencimento", produto.DataVencimento);
                comando.Parameters.AddWithValue("@data_cadastro", produto.DataCadastro);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
                comando.Clone();

            }
        }

        public void DeletarProduto(int LinhaSelecionada)
        {
            throw new NotImplementedException();
        }

        public void NovoProduto(Produto produto)
        {
            try
            {
                querySQL = "INSERT INTO tb_produto(nome, marca, codigo_barras, data_vencimento, data_cadastro)" +
                    " values (@nome, @marca, @codigo_barras, @data_vencimento, @data_cadastro);";

                conexao = new(strConexao);
                comando = new SqlCommand(querySQL, conexao);

                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@marca", produto.Marca);
                comando.Parameters.AddWithValue("@codigo_barras", produto.CodigoBarras);
                comando.Parameters.AddWithValue("@data_vencimento", produto.DataVencimento);
                comando.Parameters.AddWithValue("@data_cadastro", produto.DataCadastro);

                conexao.Open();
                comando.ExecuteNonQuery();

            } catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
                comando.Clone();
                
            }
        }

        public Produto ObterPorId(int Id)
        {
            Produto produto = null;
            querySQL = "SELECT * FROM tb_produto WHERE Id = @Id;";

            try
            {
                conexao = new SqlConnection(strConexao);
                comando = new SqlCommand(querySQL, conexao);
                comando.Parameters.AddWithValue("@Id", Id);

                conexao.Open();

                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    produto = new Produto();
                    produto.Id = (int)reader.GetInt64(0);
                    produto.Nome = reader.GetString(1);
                    produto.Marca = reader.GetString(2);
                    produto.CodigoBarras = reader.GetString(3);
                    produto.DataCadastro = reader.GetDateTime(4);
                    produto.DataVencimento = reader.GetDateTime(5);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter produto pelo ID: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            return produto;
        }


        public List<Produto> ObterTodos()
        {
            try
            {
                querySQL = "SELECT * FROM tb_produto;";
                conexao = new(strConexao);
                comando = new SqlCommand(querySQL, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = (int)reader.GetInt64(0);
                        produto.Nome = reader.GetString(1);
                        produto.Marca = reader.GetString(2);
                        produto.CodigoBarras = reader.GetString(3);
                        produto.DataCadastro = reader.GetDateTime(4);
                        produto.DataVencimento = reader.GetDateTime(5);
                        listaSingleton.ListaProdutos.Add(produto);
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao obter produtos." , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
                reader.Close();

            }

            return listaSingleton.ListaProdutos;


        }
    }
}
