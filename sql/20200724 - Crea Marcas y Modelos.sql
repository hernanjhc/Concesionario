use Concesionarios

create table Marcas(
	MarcaId int not	null primary key,
	Marca	varchar(50)	null
)

create table Modelos(
	ModeloId 	int not null primary key,
	MarcaId 	int not null,
	Modelo		varchar(50)	not	null
)