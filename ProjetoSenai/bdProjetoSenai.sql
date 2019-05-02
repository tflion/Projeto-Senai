CREATE DATABASE dbProjetoSenai

GO

USE dbProjetoSenai

GO

CREATE TABLE Aluno
(
codAluno		   INT PRIMARY KEY NOT NULL,
nomeAluno		   VARCHAR(40),
cpf				   VARCHAR(20),
rg				   VARCHAR(20),
nomePai			   VARCHAR(40),
nomeMae			   VARCHAR(40),
telFixo			   VARCHAR(20),
telCelular		   VARCHAR(20),	
telCelularPai	   VARCHAR(20),
telCelularMae	   VARCHAR(20),
cidade			   VARCHAR(30),
estado			   VARCHAR(30),
bairro			   VARCHAR(30),
rua				   VARCHAR(35),
numeroCasa		   CHAR(5),
empresa_codEmpresa INT,

);

