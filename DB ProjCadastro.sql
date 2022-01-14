create database ProjCadastro
use ProjCadastro

create login usuario with password = 'senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario'
exec sp_addrolemember 'DB_DATAWRITER', 'usuario'

USE [ProjCadastro]
GO

INSERT INTO [dbo].[Cidadao]
           ([Cpf]
           ,[NomeMae]
           ,[Nome]
           ,[Nascimento])
     VALUES
           ('11122233344',
           'Maria Silva',
           'José Silva',
           '01/01/1990')
GO

INSERT INTO [dbo].[Cidadao]
           ([Cpf]
           ,[NomeMae]
           ,[Nome]
           ,[Nascimento])
     VALUES
           ('55566677788',
           'Joana Souza',
           'Jorge Souza',
           '11/02/1988')
GO

select * from Cidadao

delete from Cidadao
