select 
	case when Sueldo < 1200 then 'Menos de 1200'
		else '1200 o mas'
	end as Sueldos,
    count(*) as Cantidad_Empleados
from empleados
group by
	case when Sueldo <1200 then 'Menos de 1200'
		else '1200 o mas'
        end;