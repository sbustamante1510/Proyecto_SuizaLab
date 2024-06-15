go
use DB_REGISTRO
go
--************************ VALIDAMOS SI EXISTE EL PROCEDIMIENTO ************************--

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_registrar')
DROP PROCEDURE usp_registrar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_modificar')
DROP PROCEDURE usp_modificar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_obtener')
DROP PROCEDURE usp_obtener

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_listar')
DROP PROCEDURE usp_listar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_eliminar')
DROP PROCEDURE usp_eliminar

go

--************************ PROCEDIMIENTOS PARA CREAR ************************--
create procedure usp_registrar(
@nroDocumento varchar(60),
@nombres varchar(60),
@especialidad varchar(60)
)
as
begin

insert into LISTADO_CITAS(NroDocumento,Nombres,Especialidad)
values
(
@nroDocumento,
@nombres,
@especialidad
)

end


go

create procedure usp_modificar(
@idCita int,
@nroDocumento varchar(60),
@nombres varchar(60),
@especialidad varchar(60)
)
as
begin

update LISTADO_CITAS set 
NroDocumento = @nroDocumento,
Nombres = @nombres,
Especialidad = @especialidad
where IdCita = @idCita

end

go

create procedure usp_obtener(@idcita int)
as
begin

select * from usuario where IdCita = @idcita
end

go

create procedure usp_listar
as
begin

select * from LISTADO_CITAS
end


go

go

create procedure usp_eliminar(
@idcita int
)
as
begin

delete from LISTADO_CITAS where Idcita = @idcita

end

go