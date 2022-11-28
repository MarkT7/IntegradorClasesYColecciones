using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            Habitacion habitacion1 = new Habitacion(46478,"En uso");
            Habitacion habitacion2 = new Habitacion(46234,"Libre");
            Habitacion habitacion3 = new Habitacion(43458,"En uso");
            Habitacion habitacion4 = new Habitacion(43459,"A limpiar");
            Habitacion habitacion5 = new Habitacion(43695,"Libre");

            List<Habitacion> habitaciones1 = new List<Habitacion>();
             
            habitaciones1.Add(habitacion1);
            habitaciones1.Add(habitacion2);
            habitaciones1.Add(habitacion3);
            habitaciones1.Add(habitacion4);
            habitaciones1.Add(habitacion5);

            return habitaciones1;
        }

        //TODO
        public static List<Habitacion> Listar(string estado)
        {
            return null;
        }

        //TODO
        public static int Insertar(Habitacion habitacion)
        {
            return 0;
        }

        //TODO
        public static int Eliminar(int id)
        {
            return 0;
        }

        //TODO
        public static Habitacion TraerUno(int numero)
        {
            return null;
        }
    }
}
