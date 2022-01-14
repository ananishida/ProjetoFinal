create database ProjCadastro
use ProjCadastro

create login usuario with password = 'senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario'
exec sp_addrolemember 'DB_DATAWRITER', 'usuario'
