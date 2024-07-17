--USE TodoApi;  DROP DATABASE ASEGURADORA_HK;
--CREATE DATABASE ASEGURADORA_HK;
GO
USE ASEGURADORA_HK;
--DROP TABLE TIPOS_PRODUCTO;
CREATE TABLE TIPOS_PRODUCTO(
	tipo_producto_id int IDENTITY(1, 1),
	nombre varchar(100),
	CONSTRAINT pk_tipos_producto PRIMARY KEY (tipo_producto_id)
);

CREATE TABLE PRODUCTOS(
	producto_id int IDENTITY(1, 1),
	nombre varchar(200),
	descripcion varchar(1000),
	tipo_producto_id int,
	CONSTRAINT pk_productos PRIMARY KEY (producto_id),
	CONSTRAINT fk_productos_tipos_producto FOREIGN KEY (tipo_producto_id)
		REFERENCES TIPOS_PRODUCTO (tipo_producto_id)
);
INSERT INTO PRODUCTOS
	VALUES('test2', 'descripcion2', 1);

CREATE TABLE POLIZAS(
	poliza_id int IDENTITY(1, 1),
	producto_id int,
	estado varchar(1),
	CONSTRAINT pk_polizas PRIMARY KEY (poliza_id),
	CONSTRAINT fk_polizas_productos FOREIGN KEY (producto_id)
		REFERENCES PRODUCTOS (producto_id)
);
INSERT INTO POLIZAS
	VALUES(2, 'N');

CREATE TABLE ASEGURADOS(
	asegurado_id int IDENTITY(1, 1),
	poliza_id int,
	dni int,
	nombre varchar(200),
	fecha_nacimiento date,
	estado varchar(1),
	CONSTRAINT pk_asegurados PRIMARY KEY (asegurado_id),
	CONSTRAINT fk_asegurados_polizas FOREIGN KEY (poliza_id)
		REFERENCES POLIZAS (poliza_id)
);
GO
INSERT INTO ASEGURADOS
	VALUES(2, 324234, 'Ezequiel Sanchez', '2002/04/04', 'N');
GO

CREATE PROC USP_ASEGURADOS_EN_POLIZA (@poliza_id int)
AS
BEGIN
	SELECT a.asegurado_id 'Id', a.dni 'Dni', a.nombre 'Nombre', YEAR(GETDATE()) - YEAR(a.fecha_nacimiento) 'Edad'
		FROM POLIZAS p JOIN ASEGURADOS a
			ON p.poliza_id = a.poliza_id;
END
GO

EXEC USP_ASEGURADOS_EN_POLIZA 2;

INSERT INTO TIPOS_PRODUCTO
	VALUES('auto');