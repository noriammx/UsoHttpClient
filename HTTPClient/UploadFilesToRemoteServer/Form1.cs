using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubirEvidencias
{
    public partial class Form1 : Form
    {
        OpenFileDialog files;
        List<String> archivos;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtNombreArchivo.Text = openFileDialog1.FileName;
            }
        }

        private async void btnUpLoadOneFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1 == null)
            {
                MessageBox.Show("No se ha seleccionado ningún archivo");
                return;
            }


            if (openFileDialog1.FileName == null || openFileDialog1.FileName == string.Empty || txtNombreArchivo.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningún archivo");
                return;
            }

            //Definimos los parámetros que se enviarian al servicio.
            //Archivo, se tiene que convertir a StreamContent
            HttpContent fileStreamContent = new StreamContent(System.IO.File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read));
            //Parámetros adicionales
            HttpContent stringContent = new StringContent("NOM-ALTALT18-003");
            //Creamos el cliente que se va a usar
            using (var client = new HttpClient())
            {
                //Definimos la dirección base para los servicios
                client.BaseAddress = new Uri("http://localhost:53587/");
                //Definimos el tipo de contenido MultiparForm, para poder subir archivos
                var content = new MultipartFormDataContent();
                //Se agregan los parámetros que recibe el servicio
                content.Add(fileStreamContent, openFileDialog1.SafeFileName, openFileDialog1.SafeFileName);
                content.Add(stringContent, "folioNominacion");
                //Ejecutamos la llamada del servicio, indicando la acción que se debe ejecutar
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    var response = await client.PostAsync("BibliotecaService/GuardarPlantillaPropuestaFromWF", content);


                    //Con esta linea se lee la respuesta del resultado
                    var contents = await response.Content.ReadAsStringAsync();

                    Cursor.Current = Cursors.Default;
                    //Evaluamos  la repuesta del servicio
                    if (!response.IsSuccessStatusCode)
                    {
                        //return null;
                        //Evaluar lo que se se desea hacer en caso de que la llamada de servicio falle
                        MessageBox.Show("El servicio ha fallado, favor de intentarlo más tarde");
                    }
                    // return await response.Content.ReadAsStreamAsync();
                    openFileDialog1 = new OpenFileDialog();
                    txtNombreArchivo.Text = "";
                    MessageBox.Show("Servicio Ejecutado Satisfactoriamente" + "\n" + "Respuesta Obtenida: " + contents);

                }
                catch (Exception)
                {
                    MessageBox.Show("El servicio ha fallado, favor de intentarlo más tarde");
                }
            }

        }

        private void btnMultipleFiles_Click(object sender, EventArgs e)
        {
            files = new OpenFileDialog();
            files.Multiselect = true;
            archivos = new List<string>();

            if (files.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files.FileNames.ToList().ForEach(file =>
                {
                    archivos.Add(file);

                });

                listBox1.DataSource = archivos;

            }
        }

        private async void btnCargarMultiples_Click(object sender, EventArgs e)
        {
            if (files == null)
            {
                MessageBox.Show("No se ha seleccionado ningún archivo");
                return;
            }


            if (files.FileName == null || files.FileName == string.Empty || archivos == null || archivos.Count ==0)
            {
                MessageBox.Show("No se ha seleccionado ningún archivo");
                return;
            }

            //Definimos el tipo de contenido MultiparForm, para poder subir archivos
            //Definimos los parámetros que se enviarian al servicio.
            var content = new MultipartFormDataContent();

            for (int i = 0; i < files.FileNames.Length; i++)
            {
                //Archivo, se tiene que convertir a StreamContent
                HttpContent fileStreamContent = new StreamContent(File.Open(files.FileNames[i], FileMode.Open, FileAccess.Read));
                //Se agregan los parámetros que recibe el servicio
                content.Add(fileStreamContent, files.SafeFileNames[i], files.SafeFileNames[i]);
            }          
            //Parámetros adicionales
            HttpContent stringContent = new StringContent("NOM-ALTALT18-003");
            content.Add(stringContent, "folioNominacion");



            //Creamos el cliente que se va a usar
            using (var client = new HttpClient())
            {
                //Definimos la dirección base para los servicios
                client.BaseAddress = new Uri("http://localhost:53587/");
                //Ejecutamos la llamada del servicio, indicando la acción que se debe ejecutar
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    var response = await client.PostAsync("BibliotecaService/GuardarEvidencias", content);

                    //Con esta linea se lee la respuesta del resultado
                    var contents = await response.Content.ReadAsStringAsync();

                    Cursor.Current = Cursors.Default;
                    //Evaluamos  la repuesta del servicio
                    if (!response.IsSuccessStatusCode)
                    {
                        //return null;
                        //Evaluar lo que se se desea hacer en caso de que la llamada de servicio falle
                        MessageBox.Show("El servicio ha fallado, favor de intentarlo más tarde");
                    }
                    // return await response.Content.ReadAsStreamAsync();
                    files = new OpenFileDialog();
                    listBox1.DataSource = null;
                    archivos = new List<string>();
                    MessageBox.Show("Servicio Ejecutado Satisfactoriamente" + "\n" + "Respuesta Obtenida: " + contents);

                }
                catch (Exception)
                {
                    MessageBox.Show("El servicio ha fallado, favor de intentarlo más tarde");
                }
            }
        }
    }
}
