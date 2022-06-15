create database WTDNWYTK;
GO

USE WTDNWYTK;
GO

CREATE TABLE usuario(
   idUsuario smallint PRIMARY KEY IDENTITY(1,1),
   nome varchar(100) not null,
   email varchar(100) unique not null,
   senha varchar(50) not null
);
go

CREATE TABLE tipo(
   idTipo smallint PRIMARY KEY IDENTITY(1,1),
   nomeTipo varchar(100) unique not null
);
go

CREATE TABLE regiao(
   idRegiao smallint PRIMARY KEY IDENTITY(1,1),
   nomeRegiao varchar(100) unique not null
);
go

CREATE TABLE historia(
   idHistoria smallint PRIMARY KEY IDENTITY(1,1),
   idUsuario smallint FOREIGN KEY REFERENCES usuario(idUsuario) not null,
   titulo varchar(100) not null,
   texto varchar(5000) not null,
   imagem1 varchar(100),
   imagem2 varchar(100)
);
go

CREATE TABLE tipoHistoria(
   idTipoHistoria smallint PRIMARY KEY IDENTITY(1,1),
   idHistoria smallint FOREIGN KEY REFERENCES historia(idHistoria) not null,
   idTipo smallint FOREIGN KEY REFERENCES tipo(idTipo) not null
);
go

CREATE TABLE regiaoHistoria(
   idRegiaoHistoria smallint PRIMARY KEY IDENTITY(1,1),
   idHistoria smallint FOREIGN KEY REFERENCES historia(idHistoria) not null,
   idRegiao smallint FOREIGN KEY REFERENCES regiao(idRegiao) not null
);
go