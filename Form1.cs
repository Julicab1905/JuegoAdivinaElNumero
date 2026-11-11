using AdivinaElNumero.BA;

namespace AdivinaElNumero.FE
{
    public partial class Form1 : Form
    {
        //Variable que guarda el juego del Backend
        private Juego juego= new Juego();
        public Form1()
        {
            InitializeComponent();
            NuevoJuego();
        }
        //Inicializa un nuevo juego
        private void NuevoJuego()
        {
            juego = new Juego();
            lblIntentos.Text = "Intentos: 0";
            dgvHistorial.Rows.Clear();
            txtNumero.Clear();
            txtNumero.Focus();

        }
        //Boton Probar
        private void btnProbar_Click(object sender, EventArgs e)
        {
            //validar que se ingreso un número
            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("ingresa un número válido", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Clear();
                txtNumero.Focus();
                return;
            }
            //Validar rango del número
            if (numero < 1 || numero > 100)
            {
                MessageBox.Show("El número debe estar entre 1 y 100.", "Error, fuera de rango",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Clear();
                txtNumero.Focus();
                return;
            }
            //Probar el número en el backend
            int resultado = juego.ProbarNumero(numero);
            //Agregar el intento al historial
            dgvHistorial.Rows.Add(DateTime.Now.ToString("HH:mm:ss"), numero);

            //Actualizar el contador de intentos
            lblIntentos.Text = "intentos: " + juego.Intentos.ToString();

            //Mostrar mensaje según el resultado
            if (resultado == 0)
            {
                MessageBox.Show("¡Felicitaciones! Adivinaste el número en " + juego.Intentos + " intentos.", "¡Ganaste!",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == -1)
            {
                MessageBox.Show("El número ingresado es menor que el número secreto.", "Pista",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El número ingresado es mayor que el número secreto.", "Pista",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }
        //Boton nuevo juego
        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            NuevoJuego();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
    }
}
