using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloAutenticacao.Classes
{
    // Criando Métodos abaixo
    // internal class NivelDAO quando crio cria este para habilitar o modulo tenho que colocar public
    public class NivelDAO
    {
        public string Inserir(string nome) 
        {
            // ============= INSERINDO DADOS FUNCIONANDO OK ==================
            //Abrindo a conexão com o banco 
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            // no objeto (comando) posso criar banco, tabelas, store procedure e outros
            // definindo tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            // iniciando a DML - O @ é para proteção do nome do atributo  - raquer
            //Definindo DML
            comando.CommandText = "INSERT INTO Nivel(nome)Values(@Nome)";
            //Adicionando paramentro de segurança
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            // Está tudo pronto - vamos executar o comando
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "dados inseridos com sucesso";

        }
        public string Alterar()
        {
            return "dados alterado com sucesso";
            /*
            //Abrindo a conexão com o banco
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            // no objeto (comando) posso criar banco, tabelas, store procedure e outros
            // definindo tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            // iniciando a DML - O @ é para proteção do nome do atributo  - raquer
            //Definindo DML
            comando.CommandText = "SELECT * FROM Nivel(id,nome)Values(@Id,@Nome)";
            //Adicionando paramentro de segurança
            //comando.Parameters.Add(new SqlParameter("@Nome", nome));
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            // Está tudo pronto - vamos executar o comando
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();
            */

        }

        // Sobrecarga de método-mesmo nome
        // Overload
        public string Pesquisar(string nome)
        {
            return $"Olá {nome}";
        }
        public DataTable Pesquisar()
        {
            /*  
             *  return "você vai Pesquisar"; 
            */
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Nivel";

            // DataTable cria o objeto dataTable - Banco de dados na memória
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable; 
        }
        //Pesquisar por nome
        public DataTable PesquisarPorNome(string nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Nivel WHERE Nome=@nome";
            comando.Parameters.AddWithValue("@Nome",nome);
            // DataTable cria o objeto dataTable - Banco de dados na memória
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
        public string Deletar()
        {
            return "você vai deletar";
            /*
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Nivel";
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            */
        }

    }
}
