﻿CREATE DATABASE dbProjetoSenai

GO

USE dbProjetoSenai

GO

CREATE TABLE Aluno
(
codAluno		   INT PRIMARY KEY IDENTITY NOT NULL,
RegistroAluno	   INT,
nomeAluno		   VARCHAR(40),
nascimento		   VARCHAR(12),
cpf				   VARCHAR(20),
email			   VARCHAR(40),
identidade		   VARCHAR(20),
carteiraTrabalho   CHAR(10),
serieCartTrabalho  INT,
dataExpCartTrabalho VARCHAR(8),
estadoCartTrabalho VARCHAR(2),
certidaoNumero     INT,
certidaoLivro      CHAR(10),
certidaoFolha	   CHAR(10),
certidaoEstado	   VARCHAR(2),
certidaoDistrito   VARCHAR(30),
certidaoData	   VARCHAR(8),
certidaoCartorio   VARCHAR(50),
certidaoComarca    VARCHAR(50),
corRaca			   VARCHAR(10),
codPai			   INT,	 
idade			   CHAR(10),
sexo			   CHAR(12),
grauInstrucao	   VARCHAR(30),	
nomePai			   VARCHAR(40),
nomeMae			   VARCHAR(40),
telCelular		   VARCHAR(20),	
telCelular2		   VARCHAR(20),
cartIdentidadeMae  CHAR(10),
cartIdentidadePai  CHAR(10),
naturalidadeAluno  VARCHAR(30),
nacionalidadeAluno VARCHAR(30),
nomeInstituicao	   VARCHAR(30),
pcd				   VARCHAR(3), 
auditiva		   VARCHAR(3),
fala			   VARCHAR(3),
visual			   VARCHAR(3),
mental			   VARCHAR(3),
valorBolsa		   VARCHAR(50),
articuladoSesi	   VARCHAR(50),
telCelularPai	   VARCHAR(20),
cpfPai			   VARCHAR(20),
pisPai			   INT,
emailPai		   VARCHAR(30),
codMae			   INT,		
telCelularMae	   VARCHAR(20),
cpfMae			   VARCHAR(20),
pisMae			   INT,
emailMae	       VARCHAR(30),	
codRespFinanceiro  INT,
nomeRespFinanceiro VARCHAR(30),
cpfRespFinanceiro  VARCHAR(20),
cepRespFinanceiro  CHAR(10),
ruaRespFinanceiro  VARCHAR(30),
numEndRespFinanceiro INT(5),
compEndRespFinanceiro VARCHAR(15),
bairroRespFinanceiro VARCHAR(40),
celularRespFinanceiro VARCHAR(20),
telRespFinanceiro VARCHAR(20),
codRespAcademico   INT,
nomeRespAcademico  VARCHAR(40),
telRespAcademico1  VARCHAR(20),
telRespAcademico2  VARCHAR(20),
cpfRespAcademico   VARCHAR(20),
emailRespAcademico VARCHAR(30),
cidade			   VARCHAR(30),
estado			   VARCHAR(20),
bairro			   VARCHAR(30),
rua				   VARCHAR(35),
complemento		   VARCHAR(15),
numeroCasa		   CHAR(5),
cep				   CHAR (10),
nomeCurso		   CHAR(40),
nomeHabilitacao    VARCHAR(30),
codigoTurma		   CHAR(20),
tipoMatricula      VARCHAR(20),
statusMatricula	   CHAR(15),
categoria		   VARCHAR(50),
articulado         VARCHAR(50),
empresa			   VARCHAR(50),
unidade			   VARCHAR(50),
irmaoRa			   INT,
irmaoNome		   VARCHAR(30),
periodoLetivo	   VARCHAR(20),		
filial             VARCHAR(50),
bolsaParcInicial   VARCHAR(50),
bolsaParcFinal	   VARCHAR(50),
nomeServico		   VARCHAR(30),
dataMatricula	   VARCHAR(8),
codTurma1		   CHAR(20),
bolsaNome		   VARCHAR(30),
bolsaDataInicial   VARCHAR(8),
bolsaDataFinal	   VARCHAR(8),
nomeTurma		   VARCHAR(30),
nomeReduzidoTurma  CHAR(10),
motivoAlteracao    VARCHAR(20),
dataAlteracao	   VARCHAR(8),
historicoStatus	   VARCHAR(20),
empresa_codEmpresa INT,
FOREIGN KEY (empresa_codEmpresa)
	REFERENCES Empresa (codEmpresa)	
);

-- DROP TABLE Aluno

CREATE TABLE Usuario
(
codUsuario	INT PRIMARY KEY IDENTITY NOT NULL,
email		VARCHAR(30),
senha	    VARCHAR(25),
nome		VARCHAR(40),
);

CREATE TABLE Empresa
(
codEmpresa		   INT PRIMARY KEY IDENTITY NOT NULL,
nomeEmpresa		   VARCHAR(40),
telefone		   VARCHAR(20),
emailContato	   VARCHAR(40),
cidade			   VARCHAR(30),
estado			   VARCHAR(20),
bairro			   VARCHAR(30),
rua				   VARCHAR(35),
complemento		   VARCHAR(15),
numeroCasa		   CHAR(5),
cep				   CHAR (10),
aluno_codAluno	   INT,
FOREIGN KEY (aluno_codAluno)
	REFERENCES aluno (codAluno)
);
create table test(

codAluno int PRIMARY KEY,
nome varchar(20),
curso varchar(20),
telefone varchar(30));



