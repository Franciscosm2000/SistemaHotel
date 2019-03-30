USE Hotel
GO

CREATE PROCEDURE Mostrar_Clientes
AS
	 c.id_cliente as Id_Cliente,
	 c.p_nom as [Primer Nombre],
	 c.s_nom as [Segundo Nombre],
	 c.p_apell as [Primer Apellido],
	 c.s_apell as [Segundo Apellido],
	 direccion as Dirección,
	 correo as Correo,
	 tel as Teléfono,
	 stat as Estado
	 from Cliente c


CREATE PROCEDURE Insertar_Cliente
@p_nom varchar(15),
@s_nom varchar(15), @p_apell varchar(15),
@s_apell varchar(15), @dir varchar(70),
@tel varchar(10), @corr varchar(25)
AS
	INSERT INTO cliente VALUES(@p_nom,@s_nom,@p_apell,@s_apell,@dir,@tel,@corr, 'HABILITADO');
	SELECT * FROM cliente;

CREATE PROCEDURE Actualizar_Cliente
@id_cl int, @p_nom varchar(15),
@s_nom varchar(15), @p_apell varchar(15),
@s_apell varchar(15), @dir varchar(70),
@tel varchar(10), @corr varchar(25)
AS
	UPDATE cliente SET p_nom=@p_nom,
	s_nom=@s_nom, p_apell=@p_apell,
	s_apell=@s_apell, direccion=@dir,
	tel=@tel, correo=@corr, stat='HABILITADO'
	WHERE id_cliente=@id_cl;


CREATE PROCEDURE Cambiar_Estado
@id_cl int
AS
	if((SELECT stat FROM cliente WHERE id_cliente=@id_cl)='HABILITADO')
	BEGIN
		UPDATE cliente SET stat='DESHABILITADO' WHERE id_cliente=@id_cl;
	END
	ELSE
	BEGIN
		UPDATE cliente SET stat='HABILITADO' WHERE id_cliente=@id_cl;
	END

CREATE PROCEDURE Buscar_Regs
AS
--TODO: CREAR ESTE PROCEDIMIENTO


CREATE PROCEDURE Disponibilidad_Habitacion
AS
--TODO: CREAR ESTE PROCEDIMIENTO



/*TODO: CREAR PROCEDIMIENTOS DE AÑADIR RESERVA, Y DEL EXAMEN 2 Y 3*/