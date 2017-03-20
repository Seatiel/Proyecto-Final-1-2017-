create table Clientes(
ClienteId int identity(1,1) primary key,
UsuarioId int,
Nombres varchar(125),
Direccion varchar(125),
Telefono varchar(11),
FechaCreacion date,
Email varchar(125)
);

create table TiposUsuarios(
TipoUsuarioId int identity(1,1) primary key,
TipoUsuario varchar(50)
);
