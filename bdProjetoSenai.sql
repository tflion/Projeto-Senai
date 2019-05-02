CREATE DATABASE dbProjetoSenai

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
idade			   CHAR(10),
sexo			   CHAR(12),
grauInstrucao	   VARCHAR(30),	
nomePai			   VARCHAR(40),
nomeMae			   VARCHAR(40),
telFixo			   VARCHAR(20),
telCelular		   VARCHAR(20),	
telCelular2		   VARCHAR(20),
telCelularPai	   VARCHAR(20),
telCelularMae	   VARCHAR(20),
cidade			   VARCHAR(30),
estado			   VARCHAR(20),
bairro			   VARCHAR(30),
rua				   VARCHAR(35),
complemento		   VARCHAR(15),
numeroCasa		   CHAR(5),
cep				   CHAR (10),
nomeCurso		   CHAR(40),
codigoTurma		   CHAR(20),
statusMatricula	   CHAR(15),
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


