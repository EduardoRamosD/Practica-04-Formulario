using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string telefonos = tbNombre.Text;
            string estaturas = tbEstatura.Text;
            string edades = Tbedad.Text;

            //GENERO SELECCIONADO

            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if(rbMujer.Checked)
            {
                genero = "Mujer";
            }

            //CREAR UNA CADENA CON LOS DATOS

            string datos = $"Nombres: {nombres}\r\n Apellidos: {apellidos}\r\n Telefono:{telefonos} kg\r\n Estatura: {estaturas} cm\r\nEdad:{edades} años\r\n Generozzzzz {genero}\r\n";

            //Guardar los datos en un archivo de texto
            string rutaArchivo = "C:/Users/jorge/OneDrive/Escritorio/UNACH/Tercer semestre/Programacion avanzada/Formulario de registro basico/Datos.TXT";

            //Verificar si el archivo ya existe

            bool archivoexiste = File.Exists(rutaArchivo);

            if (archivoexiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }

            else
            {

                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoexiste)
                    {
                        //si el archivo existe, añadir un separador antes del nuevo registro
                        writer.WriteLine(datos);
                    }
                }
            }

            //mostrar un mensaje con los datos capturados
            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar los controles despues de guardar

            tbNombre.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            Tbtelefono.Clear();
            Tbedad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
