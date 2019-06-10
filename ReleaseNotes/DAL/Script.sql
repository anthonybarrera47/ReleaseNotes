create schema Actualizaciones
go
use Actualizaciones;

create table Actualizaciones.Usuarios
(
	IdUsuario int primary key identity(1,1),
	Nombre varchar(max)
);

create table Actualizaciones.Cambios 
(
	IdCambio int primary key identity(1,1),
	Descripcion varchar(max),
	InformacionDetallada Varchar(max), --Aqui estara la informacion que se mostrara.
	Fecha datetime,
	Version varchar(15)
);
--Esta tabla permite conocer cuales usuarios vieron la ventana de informacion de la actualizacion dentro del sistema.
create table Actualizaciones.CambiosLeidos
(
	Secuencia int primary key identity(1,1),
	IdCambio int,--FK
	IdUsuario int,--FK
	Fecha datetime, --Fecha en la que el Usuario vio la ventana de informacion de la actualizacion.
	CONSTRAINT FK_IdUsuario foreign key(IdUsuario) references dbo.Usuarios(IdUsuario),
	CONSTRAINT FK_IdCambios foreign key(IdCambio) references Cambios(IdCambio)
);