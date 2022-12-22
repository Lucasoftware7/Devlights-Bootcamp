using System;

namespace ConsoleApplication2
{
    public class Mascota
    {
        //Constructor & inital values 
        public Mascota()
        {
            Energia = 100;
        }
        //Properties
        private string Nombre;
        private string Tipo;
        private int Energia;
        
        //Getters & setters
        public void setNombre(string paramNombre)
        {
            Nombre = paramNombre;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setTipo(string paramTipo)
        {
            Tipo = paramTipo;
        }

        public string getTipo()
        {
            return Tipo;
        }

        public void setEnergia(int paramEnergia)
        {
            Energia = paramEnergia;
        }

        public int getEnergia()
        {
            return Energia;
        }

        //Methods
        public void Comer()
        {
            Console.WriteLine("Estoy comiendo alimento balanceado y recuperando energia!");
            Energia = Energia + 30;
        }
        
        public void Correr()
        {
            
            if (Energia >= 20)
            {
                Console.WriteLine("Estoy Corriendo!!!");
                Energia=Energia - 10;
            }
            if (Energia < 20)
            {
                Console.WriteLine("Estoy agotado, necesito descansar!");
            }
            
        }
    }
    
}