use hotel 
go

---muestra el id, nombre y apellido del cliente
create procedure clientes
as
select 
c.id_cliente as [ID del cliente],
c.p_nom as [Primer Nombre],
c.p_apell as [Primer Apellido]
from cliente c

execute clientes

---muestre el id y el nombre del empleado
create procedure Empleados
as
select
e.id_empleado as [ID del Empleado],
e.p_nom as [Primer Nombre],
e.p_apell as [Primer Apellido]
from empleado e

execute Empleados
---muestra todos los datos de la reserva
create procedure mostrar_reserva
as
select
a.id_reserva as [ID Reserva],
a.id_cliente as [ID Cliente],
a.id_empleado as [ID Empleado],
a.fecha_reserva as [Fecha de la Reserva],
a.forma_pago as [Forma de Pago],
a.divisa as [Divisa],
a.stat as [Estado]  
from reserva a;

execute mostrar_reserva

select * from reserva

---inserta nuevos datos a la reserva
create procedure insertar_reserva
@id_cliente int,
@id_empleado int,
@fecha_reserva date,
@forma_pago varchar(15),
@divisa varchar(3),
@stat varchar(15)
as
insert into reserva(id_cliente,id_empleado,fecha_reserva,forma_pago,divisa,stat)
values(@id_cliente,@id_empleado,@fecha_reserva,@forma_pago,@divisa,@stat);

select
a.id_reserva as [ID Reserva],
a.id_cliente as [ID Cliente],
a.id_empleado as [ID Empleado],
a.fecha_reserva as [Fecha de la Reserva],
a.forma_pago as [Forma de Pago],
a.divisa as [Divisa],
a.stat as [Estado]  
from reserva a;

execute insertar_reserva 5,3,'3/4/2019 12:00:00','CHEQUE','NIO','PAGADO'

---actualizar reserva

---editar reserva

create procedure editar_reserva
@id_reserva int,
@id_cliente int,
@id_empleado int,
@fecha_reserva date,
@forma_pago varchar(15),
@divisa varchar(3),
@stat varchar(15)
as
update reserva set
id_cliente = @id_cliente,
id_empleado = @id_empleado,
fecha_reserva = @fecha_reserva,
forma_pago = @forma_pago,
divisa = @divisa,
stat = @stat
where id_reserva = @id_reserva


---busqueda de la reserva guardada
create procedure buscar_reserva
@dato date
as
select
a.id_reserva as [ID Reserva],
a.id_cliente as [ID Cliente],
a.id_empleado as [ID Empleado],
a.fecha_reserva as [Fecha de la Reserva],
a.forma_pago as [Forma de Pago],
a.divisa as [Divisa],
a.stat as [Estado]  
from reserva a
where a.fecha_reserva like @dato + '%'

