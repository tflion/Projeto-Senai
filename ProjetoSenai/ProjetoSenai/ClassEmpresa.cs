﻿using System;
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
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string emailContato { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string responsavelContrato { get; set; }
        public string telefoneResponsavel { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa (nomeEmpresa, cnpj, razaoSocial, telefone, emailContato, cidade, estado, bairro, rua, complemento, numeroCasa, cep, responsavelContrato, telefoneResponsavel) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", nomeEmpresa, cnpj, razaoSocial, telefone, emailContato, cidade, estado, bairro,
                    rua, complemento, numero, cep, responsavelContrato, telefoneResponsavel));
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
                bd.ExecutarComandosSql(String.Format("UPDATE Empresa SET nomeEmpresa = '{0}', cnpj = '{1}', razaoSocial = '{2}', telefone ='{3}', emailContato = '{4}', cidade = '{5}', estado = '{6}', bairro = '{7}', "
                    + " rua = '{8}', complemento = '{9}', numeroCasa = '{10}', cep = '{11}', responsavelContrato = '{12}', telefoneResponsavel = '{13}' WHERE codEmpresa = {14}", nomeEmpresa, cnpj, razaoSocial, telefone, emailContato, cidade, estado,
                    bairro, rua, complemento, numero, cep, responsavelContrato, telefoneResponsavel, codEmpresaClicada));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados desta empresa" +
                    ". ");
            }
        }
        public bool AlocarAluno(int codEmpresaClicada)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Emprego (aluno_codAluno, empresa_codEmpresa) VALUES({0},{1})", aluno_codAluno, codEmpresaClicada));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados desta empresa" +
                    ". ");
            }
        }
        public DataTable RetAlunosAlocados()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Emprego"));
            bd.Desconectar();
            return dt;
        }
        public DataTable RetAlunosAlocadosInnerJoin()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT Ep.codEmprego,Emp.nomeEmpresa,Emp.cnpj,Emp.telefoneResponsavel,A.nomeAluno,A.cpf,A.idade FROM Emprego AS Ep INNER JOIN Empresa AS Emp ON Ep.empresa_codEmpresa = Emp.codEmpresa INNER JOIN Aluno AS A ON Ep.aluno_codAluno = A.codAluno"));
            bd.Desconectar();
            return dt;
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
