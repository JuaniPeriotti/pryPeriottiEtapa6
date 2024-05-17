using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

namespace pryPeriottiEtapa6
{
    public partial class Form1 : Form
    {
        clsVehiculo Vehiculo;
        List<clsVehiculo> lstVehiculos = new List<clsVehiculo>();
        int Ancho = 0;
        int Largo = 0;
        int Contador = 0;
        int Lugar = 0;
        public int Cantidad;
        Random aleatorioY = new Random();
        Random aleatorioX = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearVehiculos_Click(object sender, EventArgs e)
        {
            if (lstCantidad.Text != "")
            {
                Cantidad = Convert.ToInt32(lstCantidad.Text);
            }
            else
            {
                MessageBox.Show("Seleccionar Cantidad");
            }
            Contador = 0;
            while (Contador < Cantidad)
            {
                Largo = 20;
                Vehiculo = new clsVehiculo();
                Vehiculo.crearVehiculoAleatorio();                
                Vehiculo.imagVehiculo.Tag = "Vehiculo";
                Vehiculo.imagVehiculo.Location = new Point(Lugar, Largo);
                Controls.Add(Vehiculo.imagVehiculo);
                lstVehiculos.Add(Vehiculo);
                Contador++;
                Lugar = Lugar + 120;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (clsVehiculo lista in lstVehiculos)
            {
                Vehiculo.imagVehiculo.Location = new Point(Lugar - 10, Largo);
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
