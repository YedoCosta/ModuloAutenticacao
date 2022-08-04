using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao

    {
        public static SqlConnection _conn;

        //================================================================
        // SqlConnection _conn = new Sqlconnection[]; é como se fosse isto
        public static SqlConnection MinhaInstancia
        { // abre chave da propriedade
            get
            { // abre chave do método get
                if ( _conn == null )
                { // chave do if - Conexão com SQLServero Server eu busco no conectar ao servidor SSMS (nome do servidor)
                  //   _conn = new SqlConnection(@"Server = Lab206_4; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                   _conn = new SqlConnection(@"Server = DESKTOP-TK1T5HD; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");

                } // fecha chave do if
                return _conn;
            } // fecha chave do método get
        } // fecha chave da propriedade

        //=====================================================
        // Propriedade automatica ( prop <tab> <tab> )
        // public int MyProperty { get; set; }
        //=====================================================





    }
}
