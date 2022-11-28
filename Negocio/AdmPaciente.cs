using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            DateTime d = new DateTime(1900,1,1);

            Paciente paciente1 = new Paciente(153414, d);
            Paciente paciente2 = new Paciente(125532,d);
            Paciente paciente3 = new Paciente(185738,d);
            Paciente paciente4 = new Paciente(198340,d);
            Paciente paciente5 = new Paciente(102346, d);

            List<Paciente> pacientes1 = new List<Paciente>();

            pacientes1.Add(paciente1);
            pacientes1.Add(paciente2);
            pacientes1.Add(paciente3);
            pacientes1.Add(paciente4);
            pacientes1.Add(paciente5);

            return pacientes1;
        }

        //TODO
        public static int Insertar(Paciente paciente)
        {
            return 0;
        }

        //TODO
        public static int Eliminar(int id)
        {
            return 0;
        }

        //TODO
        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return null;
        }
    }
}
