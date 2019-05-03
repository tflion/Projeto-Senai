using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenai
{
    class ClassUsuario
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool InserirUsuario()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Usuario (email,senha,nome) VALUES ('{0}','{1}','{2}')", Email, Senha, Nome));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar usuário. ");
            }

        }

    }
}
