using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProjetoSenai
{
    class ClassStatusEmprego
    {
        ClassAcessoBD bd = new ClassAcessoBD();

        public string nomeEmpresa { get; set; }
        public string nomeAluno { get; set; }
        public string statusAluno { get; set; }
        public string descricao { get; set; }
        public string periodoContrato { get; set; }
        public string dataInicio { get; set; }
        public string dataFim { get; set; }

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO statusAluno (nomeEmpresa, nomeAluno, statusAluno, descricao, periodoContrato, dataInicio, dataFim) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nomeEmpresa, nomeAluno, statusAluno, descricao, periodoContrato, dataInicio, dataFim));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados da empresa. ");
            }

        }

        public bool Editar(int codAlunoAlocadoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE statusAluno SET statusAluno = '{0}', descricao = '{1}', periodoContrato = '{2}', dataInicio = '{3}', dataFim = '{4}' WHERE codStatus = {5}", statusAluno, descricao, periodoContrato, dataInicio, dataFim, codAlunoAlocadoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados desta empresa" +
                    ". ");
            }
        }
    }
}
