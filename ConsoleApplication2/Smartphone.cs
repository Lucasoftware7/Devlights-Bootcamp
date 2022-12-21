using System;

namespace ConsoleApplication2
{
    public class Smartphone
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public Boolean encendido { get; set; }
        public Boolean enSilencio { get; set; }
        public int brillo { get; set; }

        public Smartphone(string marca, string modelo, Boolean encendido, Boolean enSilencio, int brillo)
        {
            this.brillo = brillo;
            this.encendido = encendido;
            this.modelo = modelo;
            this.marca = marca;
            this.enSilencio = enSilencio;
            brillo = 100;
            
        }


        public void ponerEnSilencio()
        {
            Console.WriteLine("Silenciando telefono...");
            enSilencio = true;
        }

        public void sacarSilencio()
        {
            Console.WriteLine("Telefono no silenciado...");
            enSilencio = false;
        }

        public void subirBrillo()
        {
            if (brillo >= 100)
            {
                Console.WriteLine("Brillo maximo alcanzado!!!");
            }

            if (brillo > 0)
            {
                Console.WriteLine("Subiendo brillo un 10%");
                brillo = brillo + 10;
            }
        }

        public void bajarBrillo()
        {
            if (brillo <= 0)
            {
                Console.WriteLine("Brillo minimo alcanzado!!!");
            }

            if (brillo > 0)
            {
                Console.WriteLine("Bajando brillo un 10%");
                brillo = brillo - 10;
            }
        }

        public void mostrarMarca()
        {
            Console.WriteLine("La marca del telefono es {0}",marca);
        }

        public void mostrarModelo()
        {
            Console.WriteLine("el modelo del telefono es {0}",modelo);
        }

        
    }
}