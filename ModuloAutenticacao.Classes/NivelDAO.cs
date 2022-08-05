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

            //================ INSERINDO DADOS FUNCIONANDO OK ==================
            //================ Usando o Evento *** btnInserir_Click(object sender, EventArgs e)

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

            return "Registro Cadastrado com sucesso ...";

        }

        //================ ALTERANDO DADOS FUNCIONANDO OK ==================
        //================ Usando o Evento *** btnAlterar_Click(object sender, EventArgs e)
        public string Alterar(string id, string nome)
        {
         
             if (nome.Equals(""))
             {
                 return "Alteração invalida ...";
            }
            else 
            {
                //Abrindo a conexão com o banco
                Conexao.MinhaInstancia.Open();
                //Definindo o comando
                SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
                // no objeto (comando) posso criar banco, tabelas, store procedure e outros
                // definindo tipo de comando
                comando.CommandType = System.Data.CommandType.Text;
                // iniciando a DML - O @ é para proteção do nome do atributo  - raquer
                //Definindo DML

                comando.CommandText = ("update Nivel set Nome=@Nome where Id=@Id;");
                //Adicionando paramentro de segurança
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nome", nome);
                // Está tudo pronto - vamos executar o comando
                comando.ExecuteNonQuery();

                Conexao.MinhaInstancia.Close();

                return "Registro Alterado com sucesso ...";
            }

         

        }


        public string Pesquisar(string nome)
        {
            return $"Olá {nome}";
        }

        //================ Quando eu chamo a TelaNivel ele já carrega esta pesquisa
        //================ Usando o Método *** CarregarTabelaNive()
        //================ PESQUISANDO DADOS FUNCIONANDO OK ==================
        public DataTable Pesquisar()
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Nivel ORDER BY Id";
            // DataTable cria o objeto dataTable - Banco de dados na memória
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable; 
        }


        // Pesquisar por nome
        // Sobrecarga de método-mesmo nome
        // Overload
        //================ PESQUISANDO DADOS POR NOME FUNCIONANDO OK ==================
        //================ Usando o Evento *** btnPesquisar_Click(object sender, EventArgs e)
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

        //================ DELETANDO DADOS FUNCIONANDO OK ==================
        //================ Usando o Evento *** btnDeletar_Click(object sender, EventArgs e)
        public string Deletar(string id)
        {

            //Abrindo a conexão com o banco
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            // no objeto (comando) posso criar banco, tabelas, store procedure e outros
            // definindo tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            // iniciando a DML - O @ é para proteção do nome do atributo  - raquer
            //Definindo DML

            comando.CommandText = ("DELETE Nivel WHERE Id=@Id;");
            //Adicionando paramentro de segurança
            comando.Parameters.AddWithValue("@Id", id);
            // Está tudo pronto - vamos executar o comando
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Registro Deletado com sucesso ...";
  
        }

    }
}
