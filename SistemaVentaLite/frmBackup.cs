using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace SistemaVentaLite
{
    public partial class frmBackup : Form
    {
        private DateTime fechaProgramada;
        private Timer timer = new Timer();
        public frmBackup()
        {
            InitializeComponent();
            timer.Interval = 1000;
           
        }

        private void txtSeleccionarUbi_TextChanged(object sender, EventArgs e)
        {
            txtUbicacionActual.Text = txtSeleccionarUbi.Text;

        }
        private void BackupDatabase(string backupFilePath)
        {
            try
            {
                // Obtener la cadena de conexión desde el archivo de configuración
                string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

                // Crear un objeto SqlConnection y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear un objeto SqlCommand para ejecutar el comando BACKUP DATABASE
                    SqlCommand command = new SqlCommand("BACKUP DATABASE DBMYVENTALITE TO DISK = @backupFilePath", connection);

                    // Agregar el parámetro de la ubicación del archivo de respaldo
                    command.Parameters.AddWithValue("@backupFilePath", backupFilePath);

                    // Ejecutar el comando BACKUP DATABASE
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear el respaldo de la base de datos. Error: " + ex.Message);
            }
        }
        private void RestoreDatabase(string backupFilePath)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
            string databaseName = new SqlConnectionStringBuilder(connectionString).InitialCatalog;

            string query = "USE [master];";
            query += "ALTER DATABASE " + databaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            query += "RESTORE DATABASE " + databaseName + " FROM DISK = @backupFilePath WITH REPLACE;";
            query += "ALTER DATABASE " + databaseName + " SET MULTI_USER;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@backupFilePath", backupFilePath);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime now = DateTime.Now;

            // Construir el nombre del archivo de respaldo
            string fileName = "Backup_" + DateTime.Now.ToString("HH-mm-dd-MM-yyyy") + ".bak";

            // Abrir un cuadro de diálogo para que el usuario seleccione la ubicación donde se creará el archivo de respaldo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar respaldo";
            saveFileDialog.FileName = fileName; // Establecer el nombre del archivo predeterminado

            // Si el usuario seleccionó una ubicación para el archivo de respaldo, iniciar el proceso de respaldo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // El usuario seleccionó una ubicación para el archivo de respaldo
                try
                {
                    BackupDatabase(saveFileDialog.FileName);
                    MessageBox.Show("El respaldo se ha creado correctamente.", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear el respaldo de la base de datos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeleccionarUbic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de respaldo de base de datos (*.bak)|*.bak";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFilePath = openFileDialog.FileName;
                txtSeleccionarUbi.Text = backupFilePath;
            }
        }

        private void bntRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string backupFilePath = txtUbicacionActual.Text;
                if (string.IsNullOrEmpty(backupFilePath))
                {
                    throw new Exception("Debes seleccionar un archivo de respaldo de la base de datos.");
                }

                if (!File.Exists(backupFilePath))
                {
                    throw new Exception("El archivo de respaldo seleccionado no existe en la ubicación especificada.");
                }

                RestoreDatabase(backupFilePath);
                MessageBox.Show("La base de datos se ha restaurado correctamente desde el archivo de respaldo seleccionado.", "Restauración de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al restaurar la base de datos: " + ex.Message, "Restauración de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
