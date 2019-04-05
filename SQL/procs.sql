USE Hotel
GO

CREATE PROCEDURE Mostrar_Clientes
AS
	 Select
	 id_cliente as Id_Cliente,
	 p_nom as [Primer Nombre],
	 s_nom as [Segundo Nombre],
	 p_apell as [Primer Apellido],
	 s_apell as [Segundo Apellido],
	 direccion as Dirección,
	 correo as Correo,
	 tel as Teléfono,
	 stat as Estado
	 from Cliente;


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



Alter PROCEDURE Disponibilidad_Habitacion
@no_hab int, @f_in date, @f_out date
as

Create table #TFecha 
(IdTFecha int primary key identity(1,1),
 Fecha date,
 Estado varchar(60))

  Declare @Contador int, @Fecha date, @Días int
 Set @Contador = 1
 set @Fecha = @f_in
 Set @Días = datediff(day,@f_in, @f_out)
 while (@Contador <= (datediff(day,@f_in, @f_out)+1))
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
			  and hr.no_habitacion = @no_hab
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

select * from cliente;
select * from empleado;
SELECT * FROM habitacion;
SELECT * FROM reserva;
insert into reserva values(4,3,'20190401','CREDITO', 'USD', 'PAGADO');
INSERT INTO habitacion_reserva VALUES(6,7,'20190407','20190415',250);

exec Disponibilidad_Habitacion 6,'20190402','20190411';

CREATE FUNCTION fn_disponibilidad_habitacion(@no_hab int, @f_in date, @f_out date)
RETURNS VARCHAR(20)
AS BEGIN
		DECLARE @stat varchar(20);
	--si existe reserva para esa habitacion en ese determinado rango de fechas
		IF exists(SELECT * FROM habitacion_reserva hr WHERE hr.no_habitacion=@no_hab and (hr.fecha_salida>=@f_in and hr.fecha_entrada<@f_out))
		BEGIN
			--se actualiza el estado de la tabla temporal a reservado  
			set @stat='OCUPADO';
		END
		ELSE
		BEGIN
			--si no, se deja en disponible (se hace update de todas formas ya que
			-- al tomarse de la tabla original, el estado puede estar en OCUPADO)
			set @stat='DISPONIBLE';
		END
		RETURN @stat;
	END
exec disponibilidad_hab '20190406', '20190416'
Alter PROCEDURE disponibilidad_hab @f_in date, @f_out date
AS
	SELECT h.no_habitacion as [N° Habitación],
	th.nom_tipo as Categoría,
	dbo.fn_disponibilidad_habitacion(h.no_habitacion, @f_in, @f_out)
	as Estado
	FROM habitacion h INNER JOIN tipo_habitacion th ON
	th.cod_tipo=h.cod_tipo;

CREATE PROCEDURE rec_hab
@m int, @yr int
AS
	--recaudaciones por habitacion
	SELECT hr.no_habitacion AS [N° Habitacion], sum(hr.precio) AS [Recaudación total] 
	FROM habitacion_reserva hr
	INNER JOIN reserva r ON r.id_reserva=hr.id_reserva
	WHERE MONTH(r.fecha_reserva)=@m AND YEAR(r.fecha_reserva)=@yr
	GROUP BY hr.no_habitacion;
	--recaudaciones por servicio
CREATE PROCEDURE rec_serv
@m int, @yr int
AS
	SELECT s.descr as [Nombre servicio], sum(cs.precio) as Recaudacion FROM servicio s
	INNER JOIN cargos_servicios cs ON cs.id_servicio=s.id_servicio
	INNER JOIN habitacion_reserva hr ON cs.id_hab_reserva=hr.id_hab_reserva
	INNER JOIN reserva r ON r.id_reserva=hr.id_reserva
	WHERE MONTH(r.fecha_reserva)= @m AND YEAR(r.fecha_reserva)=@yr
	GROUP BY s.descr; 
CREATE PROCEDURE bonif_empl
@m int, @yr int
AS	
	--comisiones
	SELECT (em.p_nom+' '+em.p_apell) as [Nombre Empleado],
	ROUND((sum(hr.precio)*0.15),2) as Comision
	FROM reserva r 
	INNER JOIN habitacion_reserva hr ON hr.id_reserva=r.id_reserva
	INNER JOIN empleado em ON em.id_empleado=r.id_empleado
	WHERE MONTH(r.fecha_reserva)= @m AND YEAR(r.fecha_reserva)=@yr
	GROUP BY (em.p_nom+' '+em.p_apell);

--TODO: Crear visualizacion para reserva, habitaciones, crear insercion para reserva y hab_reserva
--Crear cualquier otro procedimiento que sea necesario. DEBE ESTAR COMENTADO

