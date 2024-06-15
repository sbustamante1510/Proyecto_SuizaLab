use master
go
IF NOT EXISTS(SELECT name FROM master.dbo.sysdatabases WHERE NAME = 'DB_REGISTRO')
CREATE DATABASE DB_REGISTRO

GO 

USE DB_REGISTRO

GO

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'LISTADO_CITAS')
create table LISTADO_CITAS(
IdCita int primary key identity(1,1),
NroDocumento varchar(60),
Nombres varchar(60),
Especialidad varchar(60),
Fecha datetime default getdate()
)

go

select * from dbo.LISTADO_CITAS