using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> Listar()
        {
            Medico Medico1 = new Medico("Clinico","Juan");
            Medico Medico2 = new Medico("Pediatra","Lucas");
            Medico Medico3 = new Medico("Traumatologo","Daniel");
            Medico Medico4 = new Medico("Clinico","Roberto");
            Medico Medico5 = new Medico("Cardiologo","Hipolito");

            List<Medico> medicos1 = new List<Medico>();

            medicos1.Add(Medico1);
            medicos1.Add(Medico2);
            medicos1.Add(Medico3);
            medicos1.Add(Medico4);
            medicos1.Add(Medico5);

            return medicos1;
        }

        //TODO
        public static List<Medico> Listar(string especialidad)
        {
            return null;
        }

        //TODO
        public static int Insertar(Medico medico)
        {
            return 0;
        }

        //TODO
        public static int Eliminar(int id)
        {
            return 0;
        }

        //TODO
        public static Medico TraerUno(int id)
        {
            return null;
        }
    }
}
