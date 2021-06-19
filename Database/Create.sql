CREATE DATABASE Sorteio;
GO
USE Sorteio;
GO

CREATE TABLE SituacoesSorteio (
	SituacaoSorteioId INT IDENTITY(1,1),
	Descricao VARCHAR(30) NOT NULL,

	CONSTRAINT PK_SituacoesSorteio_SituacaoSorteioId PRIMARY KEY CLUSTERED (SituacaoSorteioId)
);

CREATE TABLE Usuarios (
	UsuarioId INT IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(200) NOT NULL,
	Senha VARCHAR(MAX) NOT NULL,
    CEP VARCHAR(8) NOT NULL,
	DataCadastro DATETIME

	CONSTRAINT PK_Usuarios_UsuarioId       PRIMARY KEY CLUSTERED (UsuarioId)
);

CREATE TABLE Sorteios (
	SorteioId INT IDENTITY(1,1),
	Titulo VARCHAR(100) NOT NULL,
	Descricao VARCHAR(200) NOT NULL,
    SituacaoSorteioId INT NOT NULL,
	UsuarioId INT NOT NULL,
	DataInicio DATETIME,
	DataFim DATETIME

	CONSTRAINT PK_Sorteios_SorteioId                PRIMARY KEY CLUSTERED (SorteioId),
	CONSTRAINT FK_Sorteios_SituacoesSorteio         FOREIGN KEY (SituacaoSorteioId)   REFERENCES SituacoesSorteio(SituacaoSorteioId),
	CONSTRAINT FK_Sorteios_Usuarios                 FOREIGN KEY (UsuarioId)           REFERENCES Usuarios(UsuarioId),
);


CREATE TABLE ParticipantesSorteio (
	UsuarioId INT,
	SorteioId INT,
	   
	CONSTRAINT FK_ParticipantesSorteio_Usuarios      FOREIGN KEY (UsuarioId)    REFERENCES Usuarios(UsuarioId),
	CONSTRAINT FK_ParticipantesSorteio_Sorteios      FOREIGN KEY (SorteioId)    REFERENCES Sorteios(SorteioId)
);

CREATE TABLE PremiosSorteio (
	PremioSorteioId INT,
	Descricao VARCHAR(100),

	CONSTRAINT PK_PremiosSorteio_PremioSorteioId PRIMARY KEY CLUSTERED (PremioSorteioId)
);


CREATE TABLE GanhadoresSorteio (
	UsuarioId INT,
	SorteioId INT,
	PremioSorteioId INT
	   
	CONSTRAINT FK_GanhadoresSorteio_Usuarios          FOREIGN KEY (UsuarioId)          REFERENCES Usuarios(UsuarioId),
	CONSTRAINT FK_GanhadoresSorteio_Sorteios          FOREIGN KEY (SorteioId)          REFERENCES Sorteios(SorteioId),
	CONSTRAINT FK_GanhadoresSorteio_PremiosSorteio    FOREIGN KEY (PremioSorteioId)    REFERENCES PremiosSorteio(PremioSorteioId)
);

INSERT INTO SituacoesSorteio VALUES('Em aberto');
INSERT INTO SituacoesSorteio VALUES('Finalizado');
INSERT INTO SituacoesSorteio VALUES('Cancelado');