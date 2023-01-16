namespace Atrapame_si_puedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int i=0;
            int j=0;
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    throw new ParametroVacioExcepcion("faltan datos");
                }

                if (int.Parse(textBox2.Text) == 0)
                {
                    throw new DivideByZeroException("No se puede dividir por cero");
                }
                i = int.Parse(textBox1.Text);
                j = int.Parse(textBox2.Text);
                float h = Calculador.Calculo(i, j);
                rch_texto.Text = h.ToString();
            }
            catch (ParametroVacioExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception z)
            {
                MessageBox.Show($"Error {z}");
            }


        }
       
    }
}