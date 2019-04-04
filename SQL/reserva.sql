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

execute editar_reserva 4,2,3,'2019-02-02','CREDITO','NIO','PAGADO'

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

---habitacion reserva

select * from tipo_habitacion

select * from habitacion

select * from reserva

select * from habitacion_reserva

create procedure mostrar_habitacion_reserva
as
select 
hr.id_hab_reserva as [Id de Habitacion Reserva],
hr.no_habitacion as [Numero de la Habitación],
hr.id_reserva as [Id Reserva],
hr.fecha_entrada as [Fecha de Entrada],
hr.fecha_salida as [Fecha de Salida],
hr.precio as [Precio]
from habitacion_reserva hr;

execute mostrar_habitacion_reserva

create procedure mostrar_tipo_habitacion
as
select
th.cod_tipo as [Codigo],
th.nom_tipo as [Tipo de Habitacion],
th.precio as [Precio]
from tipo_habitacion th;

execute mostrar_tipo_habitacion

create procedure mostrar_habitaciones
as 
select
h.no_habitacion as [No Habitación],
h.stat as [Estado]
from habitacion h;

execute mostrar_habitaciones

create procedure mostrar_la_reservacion
as
select 
r.id_reserva as [Id de Reserva],
r.fecha_reserva as [Fecha de la Reserva]
from reserva r;

execute mostrar_la_reservacion

create procedure insertar_habitacion_reserva
@no_habitacion int,
@id_reserva int,
@fecha_entrada date,
@fecha_salida date,
@precio money
as
insert into habitacion_reserva(no_habitacion,id_reserva,fecha_entrada,fecha_salida,precio)
values(@no_habitacion,@id_reserva,@fecha_entrada,@fecha_salida,@precio);
select
hr.id_hab_reserva as [Id de Habitacion Reserva],
hr.no_habitacion as [Numero de la Habitación],
hr.id_reserva as [Id Reserva],
hr.fecha_entrada as [Fecha de Entrada],
hr.fecha_salida as [Fecha de Salida],
hr.precio as [Precio]
from habitacion_reserva hr;

execute insertar_habitacion_reserva 9,12,'2019-04-03','2019-04-04',150

