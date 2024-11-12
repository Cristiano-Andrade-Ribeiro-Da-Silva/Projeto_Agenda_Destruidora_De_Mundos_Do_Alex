﻿using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {

                // Cria a conexão, estou utilizando a classe ConexãoDB que está dentro da pasta
                MySqlConnection conexao = ConexãoDB.criador_conexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tb_usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                //Abri a conexão com o banco
                conexao.Open();

                //Linha responsavelpor executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                //Estou trocando o valor "@" pelas informações que serão cadastradas
                //As Informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                //Fecha a conexão
                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;
            try
            {


                //Criando a conexão e usando a ConexãoDB que já foi criado
                conexao = ConexãoDB.criador_conexao();

                //SELECT montado para retornar todas as categorias
                string sql = @"select nome AS 'Nome', usuario AS 'Usuário', telefone AS 'Telefone' from tb_usuarios;";

                //Abrindo Conexão
                conexao.Open();

                //Criado o adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Tabela Vazia Criada
                DataTable tabela = new DataTable();

                //Pedindo Para o adaptador preencher a tabela
                adaptador.Fill(tabela);

                //Retorna a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar os usuários: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }


        }

        public bool ValidarLogin(string usuario, string senha)
        {
            MySqlConnection conexao = null;
            try
            {

                conexao = ConexãoDB.criador_conexao();

                string sql = @"select * from tb_usuarios
                           where usuario = @usuario 
                           and binary senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }

                else
                {
                    conexao.Close();
                    return false;
                }
            }

            catch
            {
                MessageBox.Show("Erro  ao verificar o usuário");
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}