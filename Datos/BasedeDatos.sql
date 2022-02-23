create database Proyecto_Final

drop database Proyecto_Final;

use Proyecto_Final

create table Usuarios
(

	Id int identity primary key,
	Nombre varchar(50),
	Apellido varchar(50),
	Correo varchar(50),
	Nombre_Usuario varchar(25),
	Contra varchar(50),
	Rol varchar(25)

)

insert into Usuarios (Nombre, Apellido, Correo, Nombre_Usuario, Contra, Rol) values(@nombre, @apellido, @correo, @usuario, @contra, @rol)

update Usuarios set Nombre=@nombre, Apellido=@apellido, Correo=@correo, Nombre_Usuario=@usuario, Contra=@contra, Rol=@rol where Id=@id

delete Usuarios where Id=@id

select Id, Nombre, Apellido, Correo, Nombre_Usuario, Contra, Rol  from Usuarios

select Id, Nombre, Apellido, Correo, Nombre_Usuario, Contra, Rol  from Usuarios where Id=@id

select count(*) as Resultado from Usuarios where Nombre_Usuario=@usuario and Contra=@contra

select Rol from Usuarios where Nombre_Usuario=@usuario

create table Medicos
(

	Id int identity primary key,
	Cedula varchar(50),
	Nombre varchar(50),
	Apellido varchar(50),
	Correo varchar(50),
	Telefono varchar(50),
	Foto varchar(50)

)

insert into Medicos (Cedula, Nombre, Apellido, Correo, Telefono, Foto) values('7645', 'Marcos', 'Perez', 'mar@gmail.com', '809', '')

update Medicos set Cedula=@cedula, Nombre=@nombre, Apellido=@apellido, Correo=@correo, Telefono=@telefono, Foto=@foto where Id=@id

update Medicos set Foto=@foto where Id = @id

delete Medicos where Id=@id

select Id, Cedula, Nombre, Apellido, Correo, Telefono, Foto  from Medicos

select Id, Cedula, Nombre, Apellido, Correo, Telefono, Foto  from Medicos where Id=@id

select max(Id) as Id from Medicos

alter table Medicos add default 'No hay foto' for Foto -- Mane ejecuta esto

create table Pruebas_Laboratorio
(

	Id int identity primary key,
	Nombre varchar(50)

)

insert into Pruebas_Laboratorio (Nombre) values(@nombre)

update Pruebas_Laboratorio set Nombre=@nombre where Id=@id

delete Pruebas_Laboratorio where Id=@id

select Id, Nombre from Pruebas_Laboratorio

select Id, Nombre from Pruebas_Laboratorio where Id=@id

create table Pacientes
(

	Id int identity primary key,
	Cedula varchar(50),
	Nombre varchar(50),
	Apellido varchar(50),
	Telefono varchar(50),
	Direccion varchar(50),
	Fecha_Nacimiento datetime,
	Fumador varchar(50),
	Alergias varchar(50),
	Foto varchar(50)

)

insert into Pacientes (Cedula, Nombre, Apellido, Telefono, Direccion, Fecha_Nacimiento, Fumador, Alergias, Foto) values('2020', 'Eline', 'Castillo', '849', 'Pimentel','2020','Si', 'No', null)

update Pacientes set Cedula=@cedula, Nombre=@nombre, Apellido=@apellido, Telefono=@telefono, Direccion=@direccion, Fecha_Nacimiento=@nacimiento, Fumador=@fumador, Alergias=@alergias, Foto=@foto where Id=@id

update Pacientes set Foto=@foto where Id = @id

delete Pacientes where Id=@id

select Id, Cedula, Nombre, Apellido, Telefono, Direccion, Fecha_Nacimiento, Fumador, Alergias, Foto from Pacientes

select Id, Cedula, Nombre, Apellido, Telefono, Direccion, Fecha_Nacimiento, Fumador, Alergias, Foto from Pacientes where Id=@id

select max(Id) as Id from Pacientes

alter table Pacientes add default 'No hay foto' for Foto -- Mane ejecuta esto

drop table Pacientes;

create table Resultados_Laboratorio
(

	Id int identity primary key,
	Id_Paciente int,
	Id_Cita int,
	Id_PruebaLaboratorio int,
	Id_Medico int,
	Resultado_Prueba varchar(50),
	Estado_Resultado varchar(10) 

)

insert into Resultados_Laboratorio (Id_Paciente, Id_Cita, Id_PruebaLaboratorio, Id_Medico, Resultado_Prueba, Estado_Resultado) values(@resultado, @estado)

select rl.Id, p.Nombre, p.Apellido, p.Cedula, rl.Resultado_Prueba, rl.Estado_Resultado from Resultados_Laboratorio rl inner join Pacientes p on rl.Id_Paciente = p.Id

alter table Resultados_Laboratorio add default 'Pendiente' for Estado_Resultado -- Mane ejecuta esto

create table Citas
(

	Id int identity primary key,
	Id_Paciente int,
	Id_Medico int,
	Fecha_Cita datetime,
	Causa_Cita varchar(50),
	Estado_Cita varchar

)

insert into Citas (Id_Paciente, Id_Medico, Fecha_Cita, Causa_Cita, Estado_Cita) values(@paciente, @medico, @fecha, @causa, @estado)

delete Citas where Id=@id

select p.Id, p.Nombre as 'Paciente', m.Nombre as 'Medico', c.Fecha_Cita, c.Causa_Cita, c.Estado_Cita from Citas c inner join Pacientes p on c.Id_Paciente = p.Id inner join Medicos m on c.Id_Medico = m.Id


alter table Citas add default 'Pendiente de consulta' for Estado_Cita -- Mane ejecuta esto






select Id_Paciente, Id_Cita, Id_PruebaLaboratorio, Id_Medico, Resultado_Prueba, Estado_Resultado from Resultados_Laboratorio where Cedula like '@cedula%' order by Cedula Desc

select Id_Paciente, Id_Medico, Fecha_Cita, Causa_Cita, Estado_Cita from Citas where Cedula like '@cedula%' order by Cedula Desc