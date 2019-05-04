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
        public string telefone { get; set; }
        public string emailContato { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }

        int codEmpresaClicada = 0;

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa (aluno_codAluno, nomeEmpresa, telefone, emailContato, cidade, estado, bairro, rua, complemento, numero, cep) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", aluno_codAluno, nomeEmpresa, telefone, emailContato, cidade, estado, bairro,
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
                bd.ExecutarComandosSql(String.Format("UPDATE Empresa SET aluno_codAluno = {0}, nomeEmpresa = '{1}', telefone ='{2}', emailContato = '{3}', cidade = '{4}', estado = '{5}', bairro = '{6}', "
                    + " rua = '{7}', complemento = '{8}', numero = '{9}', cep = '{10}' WHERE codEmpresa = {11}", aluno_codAluno, nomeEmpresa, telefone, emailContato, cidade, estado,
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
                bd.ExecutarComandosSql(String.Format("DELETE FROM Empresa WHERE codEmpresa LIKE %{0}%", codEmpresaClicada));
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
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa'"));
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