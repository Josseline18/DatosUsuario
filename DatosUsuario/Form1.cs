using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DatosUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string telefono = tbTelefono.Text;
            string estatura = tbEstatura.Text;
            string edad = tbEdad.Text;

            //obtener el genero 
            string genero = "";
                if (rbHombre.Checked)
            {
                genero = "Hombre"; 
            }
                else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            //crear cadena con los datos 
            string datos = $"Nombres: {nombres}\n\nApellidos: {apellidos}\n\nTelefono: {telefono}\n\nEstatura : {estatura} cm\n\nEdad: {edad} años\n\nGenero: {genero}";

            //Guardar datos en un archivo 
            string rutaArchivo = "C:\\Users\\Josseline\\Downloads\\3Mdatos24.txt";
            //verificar si el archivo existe 
            bool archivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            //Mostrar mensaje con datos guardados 
            MessageBox.Show("Datos Guardados con exito:\n\n" + datos, "información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
        }
    }

