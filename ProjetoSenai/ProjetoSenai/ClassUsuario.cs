using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoSenai
{
    class ClassUsuario
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Tipo { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool InserirUsuario()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Usuario (email,senha,nome,tipo) VALUES ('{0}','{1}','{2}',{3})", Email, Senha, Nome, Tipo));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar usuário. ");
            }

        }

        public DataTable VerificarUsu(string login, string senha)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}' AND senha = '{1}'", login, senha));
            bd.Conectar();
            bd.Desconectar();

            return dt;
        }

        public int VerificarLogin(string email)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}'", email));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
        public DataTable RetSenha(string email)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT senha FROM Usuario WHERE email = '{0}'", email));
            bd.Desconectar();

            return dt;
        }

        

        //Função para validar Email
        public bool validarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                if (Email.IndexOf("@", indexArr + 1) > 0)
                {
                    return ValidEmail;
                }

                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }

    }
}
