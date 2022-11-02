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
    }

    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
    }

    public class Enfermero:Persona
    {
        public string Cuil { get; set; }
    }

    public class Director : Medico
    {
        public string PostGrado { get; set; }
    }

    public abstract class Lugar
    {
        public int Id { get; set; }
    }

    public class Habitacion : Lugar
    {
        public int Numero { get; set; }
        public string Estado { get; set; }
    }

    public class Clinica : Lugar
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
}
