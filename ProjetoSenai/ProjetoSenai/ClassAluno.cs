using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoSenai
{

    class ClassAluno
    {
        public int CodAluno { get; set; }
        public int RegistroAluno { get; set; }
        public string NomeAluno { get; set; }
        public string Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Identidade { get; set; }
        public string CarteiraTrabalho { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string GrauInstrucao { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string TelCelular { get; set; }
        public string TelCelular2 { get; set; }
        public string TelCelularPai { get; set; }
        public string TelCelularMae { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string NumeroCasa { get; set; }
        public string Cep { get; set; }
        public string NomeCurso { get; set; }
        public string CodigoTurma { get; set; }
        public string StatusMatricula { get; set; }
        public int Empresa_codEmpresa { get; set; }

        int codAlunoclicado = 0;

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno ( RegistroAluno, nomeAluno, nascimento, cpf, email, identidade, carteiraTrabalho, idade, sexo, grauInstrucao, nomePai, nomeMae, telCelular,telCelular2, telCelularPai, telCelularMae, cidade, estado, bairro, rua, complemento, numeroCasa, cep, nomeCurso , codigoTurma, "
                    + " statusMatricula, empresa_codEmpresa) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}',{26})", RegistroAluno, NomeAluno, Nascimento, Cpf, Email, Identidade, CarteiraTrabalho, Idade, Sexo, GrauInstrucao
                    , NomePai, NomeMae, TelCelular, TelCelular2, TelCelularPai, TelCelularMae, Cidade, Estado, Bairro, Rua, Complemento, NumeroCasa, Cep, NomeCurso, CodigoTurma, StatusMatricula, Empresa_codEmpresa));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do aluno. ");
            }

        }
        public bool Editar(int codAlunoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Aluno SET RegistroAluno = {0}, nomeAluno = '{1}', nascimento ='{2}', cpf = '{3}', email = '{4}', identidade = '{5}', carteiraTrabalho = '{6}', "
                    + " idade = '{7}', sexo = '{8}', grauInstrucao = '{9}', nomePai = '{10}' , nomeMae = '{11}', telCelular = '{12}', telCelular2 = '{13}', telCelularPai = '{14}', telCelularMae = '{15}', cidade = '{16}', "
                    + "estado = '{17}', bairro = '{18}', rua = '{19}' complemento = '{20}', numeroCasa = '{21}', cep = '{22}', nomeCurso = '{23}', codigoTurma = '{24}', statusMatricula = '{25}', empresa_codEmpresa = {26} WHERE codAluno = {27}", RegistroAluno, NomeAluno, Nascimento, Cpf, Email, Identidade, CarteiraTrabalho, Idade, Sexo, GrauInstrucao, NomePai, NomeMae, TelCelular, TelCelular2, TelCelularPai, TelCelularMae, Cidade, Estado, Bairro, Rua, Complemento, NumeroCasa, Cep, NomeCurso, CodigoTurma, StatusMatricula, Empresa_codEmpresa, codAlunoclicado));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste aluno" +
                    ". ");
            }
        }
        public bool Excluir(int codAlunoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Aluno WHERE codAluno LIKE %{0}%", codAlunoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do aluno. ");
            }
        }
        public bool ExcluirTudo()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Aluno"));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do aluno. ");
            }

        }
        public DataTable retAlunos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno"));
            bd.Desconectar();
            return dt;
        }

        public DataTable verificarRA(string ra)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE registroAluno LIKE '{0}'", ra));
            bd.Desconectar();
            return dt;
        }
    }
}