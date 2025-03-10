using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ObtenerUUID
{
    public partial class formObtenerUUID : Form
    {
        // Obtiene el Identificador de dispositivo en equipo Windows leyendo clave del registro
        public string obtenerUUID()
        {
            string uuid;

            try
            {
                //Accedemos a la clave de registro x64 que contiene el dato del UUID MID del equipo
                RegistryKey clave = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\SQMClient");
                //Obtenemos su valor, si es nulo lo comprobamos para evitar errores indeseados
                if (clave != null && clave.GetValue("MachineId") != null)
                {
                    uuid = clave.GetValue("MachineId").ToString();
                    // Quitamos las llaves que suele llevar de inicio y de cierre
                    uuid = uuid.Replace("{", "").Replace("}", "");
                }
                else
                    uuid = "";
                return uuid;
            }
            catch (Exception error)
            {
                string mensaje = $"Error al obtener el UUID (MID) del equipo: {error.Message}";
                MessageBox.Show(mensaje,"Error al obtener UUID MID...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
        }

        public formObtenerUUID()
        {
            InitializeComponent();
        }

        private void btObtenerUUID_Click(object sender, EventArgs e)
        {
            string uuid = "";
            uuid = obtenerUUID();
            txtUUID.Text = uuid;
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUUID.Text);
        }
    }
}
