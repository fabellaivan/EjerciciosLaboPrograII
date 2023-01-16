using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class NotePad : Form
    {
        private OpenFileDialog openFileDialog;
        private Button selectButton;
        private TextBox textBox1;
        private string ultimoArchivo;

        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }

        public NotePad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            AbrirMenuItem();

        }

        private bool AbrirMenuItem()
        {
            bool rtn = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo = openFileDialog.FileName;
                    using StreamReader streamReader = new StreamReader(ultimoArchivo);
                    rchTxt_Texto.Text = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                   //  MostrarVentanaDeError(ex);
                }
            }
            return rtn;
        }
      

        private void rchTxt_Texto_TextChanged(object sender, EventArgs e)
        {
            toolStripContador.Text = $"{rchTxt_Texto.Text.Length} Caracteres.";
        
        }

        private void rchTxt_Texto_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.P) & e.Control)
            {

                MessageBox.Show("Llego");// no me anda con 

                //AbrirMenuItem();
            }
        }
    }
}
