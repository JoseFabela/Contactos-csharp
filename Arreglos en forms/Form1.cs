
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace Arreglos_en_forms
{
    public partial class Form1 : Form
    {
        private int cantidadPersonas = 0;
        private int RegistradosInt = 0;
        private Contacto[] arreglo;

        public Form1()
        {
            InitializeComponent();
        }

   
        

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((RegistradosInt < cantidadPersonas))
            {
                var nuevocontacto = new Contacto();

                nuevocontacto.FechaDenacimiento_ = dtpFecha.Value;
                nuevocontacto.Nombre_ = txtNombre.Text;
                nuevocontacto.telefono_ = txttelefono.Text;
                nuevocontacto.Correo = txtCorreo.Text;
                arreglo[RegistradosInt] = nuevocontacto;
                RegistradosInt = RegistradosInt + 1;
                string nuevaLinea = nuevocontacto.Nombre_ + ", " + nuevocontacto.Edad.ToString() + ", " + nuevocontacto.telefono_.ToString() + ", " + nuevocontacto.Correo.ToString() + Environment.NewLine;
                lblMostrar.Text = lblMostrar.Text + nuevaLinea;
            }
            else
                Interaction.MsgBox("Ya se registraron todos");
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(TextBox.Text);
            cantidadPersonas = valor;
            RegistradosInt = 0;
            arreglo = new Contacto[cantidadPersonas + 1];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
