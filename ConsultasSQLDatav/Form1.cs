using ConsultasSQL;

namespace ConsultasSQLDatav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgv_Personas.DataSource = PersonaAccesoDatos.Leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dtgv_Personas.SelectedRows.Count > 0)
            {
                
                   
              //  MessageBox.Show("Seleccionado");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}