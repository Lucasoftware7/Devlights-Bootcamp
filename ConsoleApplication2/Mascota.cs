using System;

namespace ConsoleApplication2
{
    public class Mascota
    {
        
        public Mascota()
        {
            energia = 100;
        }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public int energia { get; set; }
        public void Correr()
        {
            
            if (energia >= 20)
            {
                Console.WriteLine("Estoy Corriendo!!!");
                energia=energia - 10;
            }
            if (energia < 20)
            {
                Console.WriteLine("Estoy agotado, necesito descansar!");
            }
            
        }
    }
    
}