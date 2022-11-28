using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        List<Paciente> pacientes1 = null;
        List<Medico> medicos1 = null;
        List<Habitacion> habitaciones1 = null;
        Paciente pacienteA = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrearObj_Click(object sender, EventArgs e)
        {
            pacientes1 = AdmPaciente.Listar();
            medicos1 = AdmMedico.Listar();
            habitaciones1 = AdmHabitacion.Listar();

            dataGridView1.DataSource = pacientes1;
            dataGridView2.DataSource = medicos1;

            listBox1.BeginUpdate();

            foreach(Medico medico in medicos1)
            {
                if(medico.Especialidad == "Clinico")
                {
                    listBox1.Items.Add(medico.Nombre.ToString());
                }
            } 

            listBox1.EndUpdate();

            listBox2.BeginUpdate();

            foreach (Habitacion habitacion in habitaciones1)
            {
                listBox2.Items.Add(habitacion.Id.ToString()+" "+habitacion.Estado.ToString());
            }

            listBox2.EndUpdate();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            DateTime f = new DateTime(1962, 11, 7);
            pacienteA = new Paciente(473821,f);
            pacienteA.Nombre = "Romualdo";

            listBox3.BeginUpdate();
            listBox3.Items.Add("Nombre: "+pacienteA.Nombre+" Edad: "+pacienteA.Edad.ToString());
            listBox3.EndUpdate();
        }
    }
}
