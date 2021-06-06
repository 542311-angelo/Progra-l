create database gustitosBD

create table comida(
id int identity(1,1) primary key,
nombre nvarchar(50),
Descripcion nvarchar(200)
)

insert into comida values ('helado', 'Pizza de jamon con ingredientes secretos')

select * from comida