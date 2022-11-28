using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //TODO establecer get/set para las propiedades
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
    
    public class Paciente:Persona
    {
        public int NroHistoriaClinica { get; set; }
        public DateTime Nacimiento { get; }
        public int Edad { get; }
        public Paciente(int nroHistoriaClinica, DateTime nacimiento)
        {
            NroHistoriaClinica = nroHistoriaClinica;
            Nacimiento = nacimiento;
            Edad = Ayudantes.UtilidadesFechas.CalcularEdad(Nacimiento);
        }

        public Paciente(string nombre, DateTime nacimiento)
        {
            Nombre = nombre;
            Nacimiento = nacimiento;
        }
    }

    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public int Matricula { get; set; }

        public Medico(string especialidad, string nombre)
        {
            Especialidad = especialidad;
            Nombre = nombre;
        }
    }

    public class Enfermero:Persona
    {
        public string Cuil { get; set; }
    }

    public class Director : Medico
    {
        public string PostGrado { get; set; }

        public Director(string especialidad, string nombre):base(especialidad, nombre)
        {
            
        }
    }

    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }

        public Habitacion(int id, string estado)
        {
            Id = id;
            Estado = estado;
        }
    }

    public class Clinica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
}
