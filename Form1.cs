using System.Drawing;
using System.Security.Principal;

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
            while(Contador < Cantidad) 
            {
                Largo = 20;
                Vehiculo = new clsVehiculo();
                Vehiculo.crearVehiculoAleatorio();
                lstVehiculos.Add(Vehiculo);
                Vehiculo.imagVehiculo.Tag = "Vehiculo";
                Vehiculo.imagVehiculo.Location = new Point(Lugar, Largo);
                Controls.Add(Vehiculo.imagVehiculo);
                Contador++;
                Lugar = Lugar + 120;
            }
        }
    }
}
