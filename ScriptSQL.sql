CREATE TABLE public.cliente (
	id serial NOT NULL,
	id_banco serial NOT NULL,
	nombre varchar(50) NOT NULL,
	apellido varchar(50) NOT NULL,
	documento varchar(15) NOT NULL,
	direccion varchar(50) NULL,
	mail varchar(100) NULL,
	celular varchar(50) NULL,
	estado varchar(10) NOT NULL,
	CONSTRAINT cliente_pk PRIMARY KEY (id),
	CONSTRAINT cliente_unique UNIQUE (nombre,apellido,documento)
);

CREATE TABLE public.factura (
	id serial NOT NULL,
	id_banco serial NOT NULL,
	nro_factura varchar(20) NULL,
	fecha_hora date NULL,
	total decimal(6, 2) NULL,
	total_iva5 decimal(6, 2) NULL,
	total_iva10 decimal(6, 2) NULL,
	total_iva decimal(6, 2) NULL,
	total_letras varchar(50) NULL,
	sucursal integer NULL,
	CONSTRAINT factura_pk PRIMARY KEY (id),
	CONSTRAINT factura_unique UNIQUE (id_banco)
);

CREATE TABLE public.sucursal (
	id int4 NOT NULL,
	descripcion varchar(50) NULL,
	direccion varchar(50) NULL,
	telefono varchar(50) NULL,
	whatsapp varchar(50) NULL,
	mail varchar(50) NULL,
	estado varchar(50) NULL,
	CONSTRAINT sucursal_pk PRIMARY KEY (id)
);

CREATE TABLE public.detalles (
	id integer NOT NULL,
	id_factura integer NOT NULL,
	id_producto integer NOT NULL,
	cantidad_producto numeric NOT NULL,
	subtotal numeric NOT NULL,
	CONSTRAINT detalles_pk PRIMARY KEY (id)
);

CREATE TABLE public.productos (
	id integer NOT NULL,
	descripcion varchar(100) NOT NULL,
	cantidad_minima integer NOT NULL,
	cantidad_stock integer NOT NULL,
	precio_compra integer NOT NULL,
	precio_venta integer NULL,
	categoria varchar(20) NOT NULL,
	marca varchar(20) NOT NULL,
	estado varchar(15) NOT NULL,
	CONSTRAINT productos_pk PRIMARY KEY (id)
);
