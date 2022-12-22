using System;

namespace ConsoleApplication2
{
    public class Smartphone:Persona
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Boolean Encendido { get; set; }
        public Boolean EnSilencio { get; set; }
        public int Brillo { get; set; }

        public Smartphone(string marca, string modelo, Boolean encendido, Boolean enSilencio, int brillo)
        {
            this.Brillo = brillo;
            this.Encendido = encendido;
            this.Modelo = modelo;
            this.Marca = marca;
            this.EnSilencio = enSilencio;
          
            
        }


        public void ponerEnSilencio()
        {
            Console.WriteLine("Silenciando telefono...");
            EnSilencio = true;
        }

        public void sacarSilencio()
        {
            Console.WriteLine("Telefono no silenciado...");
            EnSilencio = false;
        }

        public void subirBrillo()
        {
            if (Brillo >= 100)
            {
                Console.WriteLine("Brillo maximo alcanzado!!!");
            }

            if (Brillo > 0)
            {
                Console.WriteLine("Subiendo brillo un 10%");
                Brillo = Brillo + 10;
            }
        }

        public void bajarBrillo()
        {
            if (Brillo <= 0)
            {
                Console.WriteLine("Brillo minimo alcanzado!!!");
            }

            if (Brillo > 0)
            {
                Console.WriteLine("Bajando brillo un 10%");
                Brillo = Brillo - 10;
            }
        }

        public void mostrarMarca()
        {
            Console.WriteLine("La marca del telefono es {0}",Marca);
        }

        public void mostrarModelo()
        {
            Console.WriteLine("el modelo del telefono es {0}",Modelo);
        }

        
    }
}