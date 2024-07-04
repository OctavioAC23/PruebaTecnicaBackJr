select Users.Login, Emp.FechaIngreso 
from usuarios Users, empleados Emp 
where Users.userId = Emp.userId
and Emp.Sueldo > 10000
and Users.Paterno like 'T%'
order by Emp.FechaIngreso desc