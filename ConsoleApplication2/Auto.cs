using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Configuration;

namespace ConsoleApplication2
{
    public class Auto:Persona
    {
        
        public Auto()
        {
            
        }

        private Persona Propietario;

        public void setPropietario(Persona paramPropietario)
        {


            Console.WriteLine("Asginando un propietario");
  
            if (paramPropietario.Edad >= 18 && (paramPropietario.getLicenciaDeConducir() == true))
            {
                Console.WriteLine("Asignando el vehiculo " + Marca +" " + Modelo + " a su propietario");
                Propietario = paramPropietario;
                setEsPropietario(true);
            }
            else if (paramPropietario.Edad < 18)
            {
                Console.WriteLine("Eres demasiado joven!, debes ser mayor de 18 para conducir");
            }
            else if (paramPropietario.getLicenciaDeConducir() == false)
            {
                Console.WriteLine("No tienes lincencia de conducir, necesitas una para hacerlo!");
            }
        }

        public Persona getPropietario()
        {
            return Propietario;
        }

        private int v1;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        
        public bool Encendido { get; set; }
        public int velocidad { get; set; }

        public int velocidadActual;
        
     //   public int Count { get; set; }

        public int NumeroPasajeros;

        public List<Persona> Pasajeros;
        
        
        //Getters & Setters

        public void setVelocidadActual()
        {
             v1 = velocidad;
            velocidadActual = v1;
        }

        public int getVelocidadActual()
        {
            return velocidadActual;
        }
        public void setPasajeros(List<Persona> paramPasajeros)
        {
            Pasajeros = paramPasajeros;
        }

        public List<Persona> getPasajeros()
        {
            return Pasajeros;
        }

        public void setNumeroPasajeros()
        {
            Console.WriteLine(Pasajeros.Count);
            NumeroPasajeros = Pasajeros.Count; 
        }

        public int getNumeroPasajeros()
        {
            return NumeroPasajeros;
        }
        
        //Methods

        public void bajarPasajeros(List<Persona> paramListaPersona)
        {
            if (Encendido && velocidad > 0)
            {
                Console.WriteLine("No se puede bajar de un auto en movimiento!!!, detengalo para poder bajar");
            }
            else if (Encendido == true && velocidad == 0)
            {
                Console.WriteLine("No se puede bajar del auto sin apagarlo, deten el motor primero!");
            }
            else
            {
                Console.WriteLine("Bajando pasajeros...");
                paramListaPersona.Clear();
                int pasajeros_restantes = paramListaPersona.Count;
                NumeroPasajeros = pasajeros_restantes;
            }

        }

        public void mostrarInfo()
        {
            Console.WriteLine("Los datos del automovil son. \n Marca: {0} \n Modelo: {1} \n Color: {2}",Marca, Modelo,Color);
        }

        public void encederVehiculo()
        {
            if (Encendido == true)
            {
                
                Console.WriteLine("El vehiculo se encuentra encendido!, desea apagarlo? [S/N]");
                char decision = Console.ReadKey().KeyChar;
                if (decision == 'S')
                {
                    Console.WriteLine("apagando motor");
                    Encendido = false;
                }

                if (decision == 'N')
                {
                    Console.WriteLine("el auto continua encendido");
                    
                }
            }

            if (Encendido == false)
            {
                Console.WriteLine("prender vehiculo?");
                char decision2 = Console.ReadKey().KeyChar;
                if (decision2 == 'S')
                {
                    Console.WriteLine("Encendiendo motor");
                    Encendido = true;
                    
                }

                if (decision2 == 'N')
                {
                    Console.WriteLine("el vehiculo continua apagado");
                    
                }
            }
        }

        public void apagarVehiculo()
        {
            if (Encendido && velocidad==0)
            {
                Console.WriteLine("Apagando vehiculo...");
                Encendido = false;
            }
            else if (velocidad > 0)
            {
                Console.WriteLine("Debes Frenar el auto antes de apagarlo!!!");
            }
            else
            {
                Console.WriteLine("El vehiculo ya se encuentra apagado!");
            }
        }

        public void acelerar()
        {
            if (Encendido == true && velocidad < 150) 
            {
                Console.WriteLine("Aumentando velocidad en 10!");
                velocidad = velocidad + 10;
            }
            else if (Encendido == false)
            {
                Console.WriteLine("El vehiculo se encuentra apagado!, debes encenderlo primero para poder avanzar");
            }
            else if (velocidad >= 150)
            {
                Console.WriteLine("has alcanzado la velocidad maxima, cuidado!!!");
            }
        }

        public void frenar()
        {
            if (Encendido == true && velocidad > 0)
            {
                Console.WriteLine("Frenando...");
                velocidad = velocidad - 10;
            }
            else if (Encendido == false)
            {
                Console.WriteLine("El motor se encuentra apagado, debe encenderlo primero");
            }
            else if (velocidad <= 0)
            {
                Console.WriteLine("El vehiculo ya se encuentra detenido.");
            }
        }

        public void velocimetro()
        {
            Console.WriteLine("En este momento la velocidad del vehiculo es de {0} Km/h",getVelocidadActual());
        }
        
        
    }
}