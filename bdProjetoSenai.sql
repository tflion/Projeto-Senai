﻿
CREATE DATABASE dbProjetoSenai

GO

USE dbProjetoSenai

GO

CREATE TABLE Aluno
(
	codAluno		   INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	RegistroAluno	   VARCHAR(100),
	nomeAluno		   VARCHAR(100),
	nascimento		   VARCHAR(100),
	idade			   VARCHAR(100),
	sexo			   VARCHAR(100),
	grauInstrucao	   VARCHAR(100),
	rua				   VARCHAR(100),
	numeroCasa		   VARCHAR(100),
	complemento		   VARCHAR(100),
	bairro			   VARCHAR(100),
	estado			   VARCHAR(100),
	cidade			   VARCHAR(100),
	cep				   VARCHAR(100),
	telCelular		   VARCHAR(100),
	identidade		   VARCHAR(100),
	cpf				   VARCHAR(100),
	email			   VARCHAR(100),
	carteiraTrabalho   VARCHAR(100),
	serieCartTrabalho  VARCHAR(100),
	dataExpCartTrabalho VARCHAR(100),
	estadoCartTrabalho VARCHAR(100),
	certidaoNumero     VARCHAR(100),
	certidaoLivro      VARCHAR(100),
	certidaoFolha	   VARCHAR(100),
	certidaoEstado	   VARCHAR(100),
	certidaoDistrito   VARCHAR(100),
	certidaoData	   VARCHAR(100),
	certidaoCartorio   VARCHAR(100),
	certidaoComarca    VARCHAR(100),
	corRaca			   VARCHAR(100),
	codPai			   VARCHAR(100),	 
	nomePai			   VARCHAR(100),
	telCelularPai	   VARCHAR(100),
	cpfPai			   VARCHAR(100),
	pisPai			   VARCHAR(100),
	emailPai		   VARCHAR(100),
	codMae			   VARCHAR(100),
	nomeMae			   VARCHAR(100),
	telCelularMae	   VARCHAR(100),
	cpfMae			   VARCHAR(100),
	pisMae			   VARCHAR(100),
	emailMae	       VARCHAR(100),
	codRespFinanceiro  VARCHAR(100),
	nomeRespFinanceiro VARCHAR(100),
	cpfRespFinanceiro  VARCHAR(100),
	cepRespFinanceiro  VARCHAR(100),
	ruaRespFinanceiro  VARCHAR(100),
	numEndRespFinanceiro VARCHAR(100),
	compEndRespFinanceiro VARCHAR(100),
	bairroRespFinanceiro VARCHAR(100),
	celularRespFinanceiro VARCHAR(100),
	telRespFinanceiro VARCHAR(100),
	codRespAcademico   VARCHAR(100),
	nomeRespAcademico  VARCHAR(100),
	telRespAcademico1  VARCHAR(100),
	telRespAcademico2  VARCHAR(100),
	cpfRespAcademico   VARCHAR(100),
	emailRespAcademico VARCHAR(100),
	nomeCurso		   VARCHAR(100),
	nomeHabilitacao    VARCHAR(100),
	codigoTurma		   VARCHAR(100),
	tipoMatricula      VARCHAR(100),
	statusMatricula	   VARCHAR(100),
	categoria		   VARCHAR(100),
	articulado         VARCHAR(100),
	empresa			   VARCHAR(100),
	unidade			   VARCHAR(100),
	irmaoRa			   VARCHAR(100),
	irmaoNome		   VARCHAR(100),
	periodoLetivo	   VARCHAR(100),		
	filial             VARCHAR(100),
	bolsaParcInicial   VARCHAR(100),
	bolsaParcFinal	   VARCHAR(100),
	nomeServico		   VARCHAR(100),
	dataMatricula	   VARCHAR(100),
	codTurma1		   VARCHAR(100),
	bolsaNome		   VARCHAR(100),
	bolsaDataInicial   VARCHAR(100),
	bolsaDataFinal	   VARCHAR(100),
	nomeTurma		   VARCHAR(100),
	nomeReduzidoTurma  VARCHAR(100),
	motivoAlteracao    VARCHAR(100),
	dataAlteracao	   VARCHAR(100),
	historicoStatus	   VARCHAR(100),
	telCelular2		   VARCHAR(100),
	cartIdentidadeMae  VARCHAR(100),
	cartIdentidadePai  VARCHAR(100),
	naturalidadeAluno  VARCHAR(100),
	nacionalidadeAluno VARCHAR(100),
	nomeInstituicao	   VARCHAR(100),
	pcd				   VARCHAR(100), 
	auditiva		   VARCHAR(100),
	fala			   VARCHAR(100),
	visual			   VARCHAR(100),
	mental			   VARCHAR(100),
	valorBolsa		   VARCHAR(100),
	articuladoSesi	   VARCHAR(100),
);
-- DROP TABLE Usuario

CREATE TABLE Usuario
(
	codUsuario	INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	email		VARCHAR(30),
	senha	    VARCHAR(25),
	nome		VARCHAR(40),
	tipo	    INT,
);

CREATE TABLE Empresa
(
	codEmpresa		   INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nomeEmpresa		   VARCHAR(40),
	cnpj				   CHAR(20),
	razaoSocial		   CHAR(40),
	telefone		   VARCHAR(20),
	emailContato	   VARCHAR(40),
	cidade			   VARCHAR(30),
	estado			   VARCHAR(20),
	bairro			   VARCHAR(30),
	rua				   VARCHAR(35),
	complemento		   VARCHAR(15),
	numeroCasa		   CHAR(5),
	cep				   CHAR (10),
	responsavelContrato		CHAR(40),
	telefoneResponsavel		CHAR(20),
);
--Quando desalocar o aluno o delete irá ser nesta tabela
CREATE TABLE Emprego
(
	codEmprego			INT PRIMARY KEY IDENTITY (1,1),
	aluno_codAluno		INT,
	empresa_codEmpresa	INT,
	nomeAluno			VARCHAR(100),
	nomeEmpresa			VARCHAR(100),
	cpfAluno			VARCHAR(100),
	cnpjEmpresa			VARCHAR(100),
	idadeAluno			VARCHAR(100),
	FOREIGN KEY (empresa_codEmpresa) REFERENCES Empresa (codEmpresa),
	FOREIGN KEY (aluno_codAluno) REFERENCES Aluno (codAluno),
);
--SELECT * FROM Emprego
--SELECT * FROM Emprego WHERE aluno_codAluno LIKE 3
--Todas as informações irão ficar aqui
CREATE TABLE HistoricoEmprego
(
	codEmprego			INT PRIMARY KEY IDENTITY (1,1),
	aluno_codAluno		INT,
	empresa_codEmpresa	INT,
	nomeAluno			VARCHAR(100),
	nomeEmpresa			VARCHAR(100),
	cpfAluno			VARCHAR(100),
	cnpjEmpresa			VARCHAR(100),
	idadeAluno			VARCHAR(100),
	FOREIGN KEY (empresa_codEmpresa) REFERENCES Empresa (codEmpresa),
	FOREIGN KEY (aluno_codAluno) REFERENCES Aluno (codAluno),
);

CREATE TABLE solicitacaoContrato
(
	codContrato			INT PRIMARY KEY IDENTITY(1,1),
	empresa_codEmpresa	INT,
	nomeEmpresa			VARCHAR(100),
	tipoContrato		VARCHAR(20),
	FOREIGN KEY (empresa_codEmpresa) REFERENCES Empresa (codEmpresa),
);

CREATE TABLE statusAluno
(
	codStatus			INT PRIMARY KEY IDENTITY(1,1),
	nomeEmpresa			VARCHAR(100),
	nomeAluno			VARCHAR(100),
	statusAluno			VARCHAR(40),
	descricao			VARCHAR(255),
	periodoContrato		VARCHAR(50),
	dataInicio			CHAR(10),
	dataFim				CHAR(10),
);