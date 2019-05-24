using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProjetoSenai
{
    class ClassSolicitarContrato
    {
        ClassAcessoBD bd = new ClassAcessoBD();

        public int empresa_codEmpresa { get; set; }
        public string nomeEmpresa { get; set; }
        public string tipoContrato { get; set; }

        public bool InserirSolicitacao()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO solicitacaoContrato (empresa_codEmpresa, nomeEmpresa, tipoContrato) VALUES ({0},'{1}','{2}')", empresa_codEmpresa, nomeEmpresa, tipoContrato));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao solicitar contrato");
            }

        }

        public bool EditarSolicitacao(int codSolicitacaoClicada)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE solicitacaoContrato SET nomeEmpresa = '{0}', tipoContrato = '{1}' WHERE codContrato = {2}", nomeEmpresa, tipoContrato, codSolicitacaoClicada));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados" +
                    ". ");
            }
        }

        public bool ExcluirSolicitacao(int codSolicitacaoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM solicitacaoContrato WHERE codContrato = {0}", codSolicitacaoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados da empresa. ");
            }
        }

        public DataTable RetSolicitacao()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM solicitacaoContrato"));
            bd.Desconectar();
            return dt;
        }
    }
}
