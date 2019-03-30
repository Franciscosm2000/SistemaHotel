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
@dato varchar(30)
AS
	Select
	id_cliente as Id_Cliente,
	c.p_nom as [Primer Nombre],
	c.s_nom as [Segundo Nombre],
	c.p_apell as [Primer Apellido],
	c.s_apell as [Segundo Apellido],
	direccion as Dirección,
	correo as Correo,
	tel as Teléfono
	from Cliente c
	where c.p_nom like @dato + '%' 
	or  c.s_nom like @dato + '%' 
	or  c.p_apell like @dato + '%' 
	or c.s_apell like @dato + '%';



CREATE PROCEDURE Disponibilidad_Habitacion
AS
@IdHabitación int, @Fechaentrada date, @Fechasalida date
as

Create table #TFecha 
(IdTFecha int primary key identity(1,1),
 Fecha date,
 Estado varchar(60))

  Declare @Contador int, @Fecha date, @Días int
 Set @Contador = 1
 set @Fecha = @Fechaentrada
 Set @Días = datediff(day,@Fechaentrada, @Fechasalida)
 while (@Contador <= (datediff(day,@Fechaentrada, @Fechasalida)+1))
 begin
 insert into #TFecha (Fecha) values (@Fecha)
 set @Fecha = dateadd(day,1, @Fecha )
 Set @Contador = @Contador +1 
 end

 Set @Contador = 1

while(@Contador <= ((Select count(*) from #TFecha)) )
begin
set @Fecha = (Select Fecha from #TFecha where IdTFecha = @Contador)
if not exists(Select * from habitacion_reserva hr
              where @Fecha >= hr.fecha_entrada and @Fecha < hr.fecha_salida
			  and hr.id_habitacion = @IdHabitación
			   )
			   begin
	          update #TFecha set Estado = 'Disponible' 
	          where IdTFecha = @Contador
	          end
			  else
			  begin
			  update #TFecha set Estado = 'Reservado' 
	          where IdTFecha = @Contador
			  end

			 
			  if(@Contador = (Select count(*) from #TFecha))
			    begin
			  update #TFecha set Estado = 'Salida' 
	          where IdTFecha = @Contador
			  end
			   Set @Contador = @Contador +1
			  

end

Select * from #TFecha
Drop table #TFecha

--TODO: Procedimientos 2 y 3 del examen y Procedimiento para reserva