USE master
go

IF DB_ID('BDCINE') IS NOT NULL
BEGIN
	ALTER DATABASE BDCINE
	SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	
	DROP DATABASE BDCINE
END	
GO

CREATE DATABASE BDCINE
COLLATE MODERN_SPANISH_CI_AI
GO

USE BDCINE
go
SET LANGUAGE SPANISH
GO
SET NOCOUNT ON
GO
---TABLA SEDE
CREATE TABLE SEDE
(
	id_sede int primary key,
	nom_sede varchar(30) not null
)
INSERT INTO SEDE VALUES (1,'ANCON')
INSERT INTO SEDE VALUES (2,'MANCHAY')
INSERT INTO SEDE VALUES (3,'COMAS')
INSERT INTO SEDE VALUES (4,'SAN JUAN LURIGANCHO')
INSERT INTO SEDE VALUES (5,'EL CERRO DE MORALES')
INSERT INTO SEDE VALUES (6,'SAN MARTIN DE PORRES')

-- TABLA SALA
CREATE TABLE SALA
(
id_sala INT PRIMARY KEY,
num_sala int,
aforo int NOT NULL ,
id_sede int REFERENCES SEDE
)
INSERT INTO SALA  VALUES(1,1,100,1)
INSERT INTO  SALA VALUES (2,1,200,2)
INSERT INTO SALA VALUES(3,2,234,1)
INSERT INTO SALA  VALUES(4,2,123,2)
INSERT INTO  SALA VALUES (5,3,190,2)
INSERT INTO SALA VALUES(6,4,190,2)
SELECT * FROM SALA
----TABLA FUNCION
d
----TABLA PELICULA
 CREATE TABLE  PELICULA
(
id_pelicula int primary key,
nom_pelicula varchar (40) not null,
sipnosis varchar(500)not null,
genero varchar(10)not null,
fecha_estreno varchar (5)not null,
duracion_horas varchar(6)  not null,
clasificacion varchar (40) not null,

)
INSERT INTO PELICULA VALUES(1,'The Batman','Cuando Enigma, un sádico asesino en serie, comienza a asesinar a las 
principales figuras políticas de Gotham, Batman se ve obligado a investigar la corrupción oculta de la ciudad 
y a cuestionar la participación de su familia','Accion','2018','2h','R')
INSERT INTO PELICULA VALUES(2,'Harry Potter','Un niño huérfano se inscribe en una escuela de magia y hechicería, 
donde aprende la verdad sobre sí mismo, su familia y el terrible mal que acecha al mundo mágico.','Fantasia','2011','3h','APT')
INSERT INTO PELICULA VALUES(3,'Shrek',' Un malvado señor exilia a las criaturas de los cuentos de hadas al pantano de un ogro gruñón, 
que debe emprender una búsqueda y rescatar a una princesa para el señor con el fin de recuperar sus tierras','Animacion','2012','1h 30m','APT')
INSERT INTO PELICULA VALUES(4,'The Avengers','Los héroes más poderosos de la Tierra deben unirse y aprender a luchar en equipo si 
quieren evitar que Loki y su ejército alienígena esclavicen a la humanidad','Accion','2014','2h','+14')
INSERT INTO PELICULA VALUES(5,'Mostrous vs Alien','Una mujer transformada en gigante después de ser golpeada por un meteorito se convierte 
en parte de un equipo de monstruos enviados por el gobierno de Estados Unidos para derrotar a un alien que 
intenta apoderarse de la Tierra','Animacion','2017','2h','APT')
INSERT INTO PELICULA VALUES(6,'Los Increibles','Una familia de superhéroes encubiertos, mientras intentan 
vivir la tranquila vida suburbana, se ven obligados a entrar en acción para salvar el mundo.','Animacion','2017','2h','APT')
INSERT INTO PELICULA VALUES(7,'Rapidos y Furiosos','Brian O Conner, quien nuevamente trabaja para el FBI en Los Ángeles, se une a
Dominic Toretto para detener a un traficante de heroína infiltrándose en su operación.','Accion','2000','2h','+14' )
INSERT INTO PELICULA VALUES(8,'Contra Fuego','Un grupo de ladrones profesionales de alto nivel empieza a sentir a la policía 
de Los Ángeles en los talones cuando, sin saberlo, deja una pista en su último atraco.','Accion','2011','2h','+14')

CREATE TABLE FUNCION
 (
	id_funcion int primary key,
	hora_funcion  varchar (8) not null,
	fecha_funcion date ,
	id_sala int REFERENCES SALA,
	id_pelicula int REFERENCES PELICULA
 )

 INSERT INTO FUNCION VALUES (1,'4:00 PM','2022/08/20',3,1)
 INSERT INTO FUNCION VALUES (2,'7:00 PM','2022/08/21',3,2)
 INSERT INTO FUNCION VALUES (3,'10:00 PM','2022/08/22',2,3)
 INSERT INTO FUNCION VALUES (4,'8:00 AM','2022/08/23',3,4)
 INSERT INTO FUNCION VALUES (5,'7:00 PM','2022/08/24',5,5)
 INSERT INTO FUNCION VALUES (6,'7:00 PM','2022/08/25',6,6)

---TABLA CLIENTE
create  TABLE CLIENTE
(
  id_cliente int primary key,
  apellido varchar(50) not NULL,
  correo varchar(45) not null,
  dni varchar(25) not null,
  fecha_nacimiento date not null,
  genero varchar(45) not null,
  nombres varchar(45) not null,
  telefono varchar(55) not null,
)
INSERT INTO CLIENTE VALUES(1,'Morales Zevallos','zephir@gmail.com','45454323','08/04/2000','M','Adrian','967812214')
INSERT INTO CLIENTE VALUES(2,'Sanchez Odria','micky@gmail.com','50678909','10/04/2001','M','Miguel','983223121')
INSERT INTO CLIENTE VALUES(3,'Cañamero Valentin','caña@gmail.com','54123221','10/09/2008','M','Antony','987667121')
INSERT INTO CLIENTE VALUES(4,'Contreras Campos','takachi@gmail.com','78906787','10/04/1990','M','Jhanns','978932121')
INSERT INTO CLIENTE VALUES(5,'Bellido Pozo','left4dead@gmail.com','73457854','12/12/1900','M','Adrian','989765341')
INSERT INTO CLIENTE VALUES(6,'Atiro Talla','andres@gmail.com','32126566','10/11/2005','M','Andres','913232451')
INSERT INTO CLIENTE VALUES(7,'Espinoza Tejada','mesplop@gmail.com','45124777','10/04/1999','M','Jesus','987878661')
INSERT INTO CLIENTE VALUES(8,'Lopez Jaramillo','lojae@gmail.com','45997777','10/04/1993','F','Andrea','909090901')
INSERT INTO CLIENTE VALUES(9,'Gonzales Ramirez','gonzales@gmail.com','45678912','10/01/2003','F','Isabel','989123578')
--TABLA EMPLEADO
CREATE TABLE EMPLEADO
(
  id_empleados int primary key,
  apellidos varchar(255) not NULL,
  correo varchar(255) not NULL,
  dni varchar(255) not NULL,
  fecha_nacimiento date not NULL,
  nombres varchar(255) not NULL,
  telefono varchar(255) not NULL,
  turno varchar(255) not NULL,
  id_funcion int REFERENCES FUNCION
)
INSERT INTO EMPLEADO VALUES(1,'Morata Bances','ola@gmail.com','46887865','08/04/2000','Florencio','961212214','Mañana',5)
INSERT INTO EMPLEADO VALUES(2,'Sulca Zevallos','jeff@gmail.com','32458909','10/04/2002','Leo','983223111','Tarde',3)
INSERT INTO EMPLEADO VALUES(3,'Cardenas Ventura','cris@gmail.com','54112321','10/09/2008','Cristina','922667121','Mañana',1)
INSERT INTO EMPLEADO VALUES(4,'Castillo Mora','ann@gmail.com','78126787','10/04/1994','Anngy','9789322221','Mañana',3)
INSERT INTO EMPLEADO VALUES(5,'Ramos Salinas','ale@gmail.com','73777854','12/12/1974','Alejandro','989335341','Mañana',2)
INSERT INTO EMPLEADO VALUES(6,'Talla Cottos','andres@gmail.com','34567566','10/11/2004','Andres','915532451','Mañana',6)
INSERT INTO EMPLEADO VALUES(7,'Pozo Contreras','hanna@gmail.com','451209097','10/04/1999','Hanna','987876781','Tarde',4)
INSERT INTO EMPLEADO VALUES(8,'Toribio Osio','tor@gmail.com','459972127','10/04/1900','Flor','901110901','Tarde',3)
INSERT INTO EMPLEADO VALUES(9,'Ramos Flores','ras@gmail.com','42124521','10/01/2000','Rafaela','989222578','Tarde',4)

select * from CLIENTE--TABLA BOLETA

 CREATE TABLE BOLETA
 (
	id_boleta int primary key,
	total float null,
	id_cliente int REFERENCES CLIENTE,
	id_funcion INT REFERENCES FUNCION
	
 ) 

 INSERT INTO BOLETA VALUES (1,null,1,1)
 INSERT INTO BOLETA VALUES (2,null,2,2)
 INSERT INTO BOLETA VALUES (3,null,3,3)
 INSERT INTO BOLETA VALUES (4,null,4,4)

CREATE TABLE PRODUCTO(
id_producto int primary key,
nom_producto varchar(100),
des_producto varchar(1000),
pre_producto float,
sto_producto int
);

insert into PRODUCTO values(1,'Coca Cola 250 ml','Bebida Coca Cola de 250 ml',3.50,100);
insert into PRODUCTO values(2,'Inka Cola 250 ml','Bebida Inka Cola de 250 ml',3.50,100);
insert into PRODUCTO values(3,'Valde Canchita pequeño','Valde de chanchita Por Corn tamaño pequeño',13.00,100);
insert into PRODUCTO values(4,'Valde Canchita mediano','Valde de chanchita Por Corn tamaño mediano',19.00,100);
insert into PRODUCTO values(5,'Valde Canchita grande','Valde de chanchita Por Corn tamaño grande',23,100);
insert into PRODUCTO values(6,'Valde Canchita gigante','Valde de chanchita Por Corn tamaño gigante',30.00,100);
insert into PRODUCTO values(7,'Nachos mediano','Porción de nachos tamaño mediano',12.00,100);
insert into PRODUCTO values(8,'Nachos grande','Porción de nachos tamaño grande',18.00,100);
insert into PRODUCTO values(9,'Hot Dog','Pan con Hot Dog y cremas',10.00,100);


 SELECT * FROM BOLETA
 ---DETALLE COMPRA
 CREATE TABLE DETALLE_COMPRA
 (
	id_detalle_compra int primary key,
	id_boleta int REFERENCES BOLETA,
	id_producto int REFERENCES PRODUCTO,
	cant_producto int,
	sub_total float
 )
  INSERT INTO DETALLE_COMPRA VALUES (1,1,1,1,null);
  INSERT INTO DETALLE_COMPRA VALUES (5,1,2,2,null);
 INSERT INTO DETALLE_COMPRA VALUES (2,2,2,2,null);
 INSERT INTO DETALLE_COMPRA VALUES(3,3,3,3,null);
 INSERT INTO DETALLE_COMPRA VALUES (4,4,4,4,null);

 
select * from PRODUCTO;
select * from BOLETA
select * from DETALLE_COMPRA
select * from CLIENTE


select * from EMPLEADO
select * from FUNCION
select * from PELICULA
select * from SALA
select * from SEDE

go

-- PROCEDIMIENTO ALMACENADO BELLIDO
CREATE OR ALTER PROCEDURE PeliPorFecha 
@anio char(4)
as
	select * from PELICULA p where YEAR(p.fecha_estreno) =@anio;
go

exec PeliPorFecha '2011'
go

CREATE OR ALTER PROCEDURE AnioPelis
as
	select distinct year(p.fecha_estreno)as anio from PELICULA p
go

exec AnioPelis

select * from PRODUCTO;
select * from BOLETA
select * from DETALLE_COMPRA

go

CREATE OR ALTER PROCEDURE DetalleBoleta1
as
	select distinct b.id_boleta,(c.nombres+' '+c.apellido) as Cliente,c.dni,pe.nom_pelicula,pe.duracion_horas,
					s.num_sala,se.nom_sede,b.total,f.hora_funcion,f.fecha_funcion 
	
	from DETALLE_COMPRA d 
	inner join BOLETA b on d.id_boleta=b.id_boleta
	inner join PRODUCTO p on p.id_producto=d.id_producto
	inner join FUNCION f on f.id_funcion=b.id_funcion
	inner join SALA s on s.id_sala= f.id_sala
	inner join PELICULA pe on pe.id_pelicula= f.id_pelicula
	inner join SEDE se on se.id_sede= s.id_sede
	inner join CLIENTE c on c.id_cliente=b.id_cliente

	order by b.id_boleta
go

CREATE OR ALTER PROCEDURE DetalleBoleta2
as
	select b.id_boleta,p.nom_producto,p.pre_producto,p.des_producto,d.cant_producto,(p.pre_producto*d.cant_producto) as subTotal
	
	from DETALLE_COMPRA d
	inner join BOLETA b on d.id_boleta=b.id_boleta
	inner join PRODUCTO p on p.id_producto=d.id_producto
	inner join FUNCION f on f.id_funcion=b.id_funcion
	inner join SALA s on s.id_sala= f.id_sala
	inner join PELICULA pe on pe.id_pelicula= f.id_pelicula
	inner join SEDE se on se.id_sede= s.id_sede
	inner join CLIENTE c on c.id_cliente=b.id_cliente
	order by b.id_boleta
	
go

CREATE OR ALTER PROCEDURE CLIENTESPORGENERO @GENERO CHAR(1)
as
	if (@GENERO = 'M' or @GENERO = 'F')
		select * from cliente where cliente.genero = @GENERO;
	else
		print 'M o F';
go

exec CLIENTESPORGENERO 'F';
go

CREATE OR ALTER PROCEDURE EMPLEADOSPORTURNO @Turno VARCHAR(10)
as
	IF (@Turno = 'Mañana' or @Turno = 'Tarde')
	Begin
		select * from empleado where empleado.turno = @turno;
	end
	Else
		print 'tarde o mañana';
go

exec EMPLEADOSPORTURNO 'tArDse';
go

CREATE OR ALTER PROCEDURE PA_SEDES
as
	select distinct nom_sede from sede;
go

CREATE OR ALTER PROCEDURE STOCKSPE @SINoCON bit
as

	If(@SINoCON = 1) select id_producto, nom_producto,des_producto,pre_producto,sto_producto from producto where sto_producto > 0;
	else 
	begin
	if (@SINoCON = 0) select id_producto, nom_producto ,des_producto,pre_producto,sto_producto from producto where sto_producto <= 0;
	else print 'El dato es de tipo nulo';
	end
go

exec STOCKSPE 1;