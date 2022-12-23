using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Persona> passengers = new List<Persona>();
            Console.WriteLine("Creando personas");
            Persona persona = new Persona();
            Persona persona2 = new Persona();
            
            Auto auto = new Auto();
            auto.Encendido = true;
            auto.Color = "Rojo";
            auto.Marca = "Mercedes Benz";
            auto.Modelo = "A 220";
            persona.setNombre("Jhon");
            persona.setApellido("Cena");
            Console.WriteLine("Asignando fecha de nacimiento persona ");
            persona.setFechaDeNacimiento(23,04,1977);
            persona.calcularEdad();
            persona.setTieneCelular(true);
            persona.setEsPropietario(true);
            persona.setLicenciaDeconducir(true);
            persona2.setNombre("Michael");
            persona2.setApellido("Jackson");
            Console.WriteLine("Asignando fechas de nacimiento persona 2");
            persona2.setFechaDeNacimiento(29,10,1958);
            persona2.setLicenciaDeconducir(false);
            
           // persona2.ObtenerCelular();
           Console.WriteLine("Calculando edades de las personas 1 y 2");
           persona.calcularEdad();
           Console.WriteLine("edad de la persona 1: "+persona.Edad);
            persona2.calcularEdad();
            Console.WriteLine("edad de la persona 2: "+persona2.Edad);
            Console.WriteLine("Agregando personas a la lista de pasajeros");
            passengers.Add(persona);
            passengers.Add(persona2);
            Console.WriteLine("agregando propietarios de los vehiculos");
            Console.WriteLine("Es propiertario? "+persona.getEsPropietario());
            auto.setPropietario(persona);
            Console.WriteLine("Ahora es propietario? "+persona.getEsPropietario());
            Console.WriteLine("Es mayor? "+persona.Edad);
            Console.WriteLine("Tiene licencia? "+persona.getLicenciaDeConducir());
            auto.setPasajeros(passengers);
            auto.setNumeroPasajeros();
            auto.acelerar();
            Console.WriteLine("Velocidad actual = "+auto.getVelocidadActual());
            Console.WriteLine(auto.velocidad);
            auto.acelerar();
            Console.WriteLine(auto.velocidad);
            auto.velocimetro();
            Console.WriteLine(auto.getVelocidadActual());
            auto.frenar();
      //      auto.frenar();
            Console.WriteLine(auto.velocidad);
            auto.apagarVehiculo();
            Console.WriteLine(auto.velocidad);
            Console.WriteLine("Obteniendo el numero de pasajeros ");
            Console.WriteLine(auto.getNumeroPasajeros());
            auto.bajarPasajeros(passengers);
            Console.WriteLine("Hay pasajeros aun? "+ auto.getNumeroPasajeros());


        }
    }
}