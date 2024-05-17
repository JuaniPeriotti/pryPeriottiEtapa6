using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPeriottiEtapa6
{
    internal class clsVehiculo
    {
        string Nombre;
        public PictureBox imagVehiculo;

        public void crearAuto()
        {
            Nombre = "Zentorno";
            imagVehiculo = new PictureBox();
            imagVehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            imagVehiculo.Size = new Size(100, 100);
            imagVehiculo.ImageLocation = @"../../../" + "/Resources/" + "Zentorno.jpg";
        }

        public void crearMoto()
        {
            Nombre = "Bati 801";
            imagVehiculo = new PictureBox();
            imagVehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            imagVehiculo.Size = new Size(100, 100);
            imagVehiculo.ImageLocation = @"../../../" + "/Resources/" + "Bati801.jpg";
        }

        public void crearAvion()
        {
            Nombre = "Besra";
            imagVehiculo = new PictureBox();
            imagVehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            imagVehiculo.Size = new Size(100, 100);
            imagVehiculo.ImageLocation = @"../../../" + "/Resources/" + "Besra.jpg";
        }

        public void crearVehiculoAleatorio()
        {
            Random vehiculoRandom = new Random();
            int Vehiculo;
            Vehiculo = vehiculoRandom.Next(1, 4);
            if (Vehiculo == 1)
            {
                crearAuto();
            }
            if (Vehiculo == 2)
            {
                crearMoto();
            }
            if (Vehiculo == 3)
            {
                crearAvion();
            }
        }
    }
}
