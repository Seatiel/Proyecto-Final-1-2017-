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

create table Usuarios(
UsuarioId int identity(1,1) primary key,
NombreUsuario varchar(125),
Nombres varchar(125),
Clave varchar(15),
TipoUsuarioId int,
RCliente int,
RFactura int,
RServicio int,
RTipoUsuario int,
RUsuario int,
CCliente int,
CServicio int,
CUsuario int
);

create table Servicios(
ServicioId int identity(1,1) primary key,
Descripcion varchar(125),
Costo decimal
);

create table Facturas(
FacturaId int identity(1,1) primary key,
Fecha date,
ClienteId int,
Total decimal
);

create table FacturasServicios(
FacturaServicioId int identity(1,1) primary key,
FacturaId int,
ServicioId int,
);