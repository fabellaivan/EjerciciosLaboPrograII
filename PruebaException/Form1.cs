namespace PruebaException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            try
            {
                string nombre = txt_nombre.Text;
                int edad = int.Parse(txt_edad.Text);
                
                string resultado =  LogicaNegocio.CargarUsuario(nombre, edad);
                //Si se produce alguna excepcion(controlada)
                //en cargar usuario, pasara directo a los catch
                MessageBox.Show(resultado);
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"El dato no es correcto {ex.Message}");
                
            }
            catch(Exception ex)
            {
                string mensaje = "";
                while(ex.InnerException != null)
                {
                    mensaje += ex.Message + "\n";
                    ex = ex.InnerException;
                }
                mensaje += ex.Message + "\n";
                MessageBox.Show(mensaje);
                //MessageBox.Show(ex.Message);//muestra mensaje del Try
                //MessageBox.Show(ex.InnerException.Message);//Muestra mensaje del catch
            }
         
        }
    }
}