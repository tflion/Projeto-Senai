using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenai
{
    class ClassEmpresa
    {
        public int aluno_codAluno { get; set; }
        public string nomeEmpresa { get; set; }
        public string telefone { get; set; }
        public string emailContato { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa (nomeEmpresa, telefone, emailContato, cidade, estado, bairro, rua, complemento, numeroCasa, cep) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", nomeEmpresa, telefone, emailContato, cidade, estado, bairro,
                    rua, complemento, numero, cep));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados da empresa. ");
            }

        }
        //Editar 
        public bool Editar(int codEmpresaClicada)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Empresa SET nomeEmpresa = '{0}', telefone ='{1}', emailContato = '{2}', cidade = '{3}', estado = '{4}', bairro = '{5}', "
                    + " rua = '{6}', complemento = '{7}', numeroCasa = '{8}', cep = '{9}' WHERE codEmpresa = {10}", nomeEmpresa, telefone, emailContato, cidade, estado,
                    bairro, rua, complemento, numero, cep, codEmpresaClicada));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados desta empresa" +
                    ". ");
            }
        }

        public bool Excluir(int codEmpresaClicada)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Empresa WHERE codEmpresa LIKE {0}", codEmpresaClicada));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados da empresa. ");
            }
        }
        public DataTable RetEmpresas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetAlunoCidade(string busca)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE cidade LIKE %{0}%", busca));
            bd.Desconectar();

            return dt;
        }

    }
}
