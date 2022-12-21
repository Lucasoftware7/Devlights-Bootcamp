using System;
namespace ConsoleApplication2
{
    public class Persona 

    {
        //properties 
        private string Nombre;
        private string Apellido;
        private Auto Vehiculo;
        private DateTime FechaDeNacimiento;
        private DateTime FechaActual;
        public int Edad;
        private bool LicenciaDeConducir;
        private bool EsPropietario;
        
    public Persona()
        {
            FechaActual=DateTime.Now;
        }
    // Getters & Setters
    public void setEsPropietario(bool valor)
    {
        EsPropietario = valor;
    }

    public bool getEsPropietario()
    {
        return EsPropietario;
    }

    public void setNombre(string nombre)
    {
        Nombre = nombre;
    }

    public string getNombre()
    {
        return Nombre;
    }

    public void setApellido(string apellido)
    {
        Apellido = apellido;
    }

    public string getApellido()
    {
        return Apellido;
    }

    public void setLicenciaDeconducir(bool licencia)
    {
        LicenciaDeConducir = licencia;
    }

    public bool getLicenciaDeConducir()
    {
        return LicenciaDeConducir;
    }
    
    public void setFechaDeNacimiento(int dia, int mes, int ano)
    {

        if (ano <= FechaActual.Year)
        {
            DateTime nacimiento = new DateTime(ano,mes,dia);
            FechaDeNacimiento = nacimiento;

        }
        else
        {
            Console.WriteLine("La fecha de nacimiento no puede ser mayor a la actual!");
        }
    }
        
        public void nombreYApellido()
        {
            Console.WriteLine("ingrese un nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un apellido");
            string apellido = Console.ReadLine();
            
            Console.WriteLine($"Bienvenido! {nombre} {apellido}");
        }

        public int calcularEdad()
        {
            Edad = FechaActual.Year - FechaDeNacimiento.Year;
            return Edad;
            //Console.WriteLine(FechaActual.Year-FechaDeNacimiento.Year); 
        }

        public void setVehicle(Auto paramAuto)
        {
            Vehiculo = paramAuto;
            Console.WriteLine($"Verificnado resultado {Vehiculo}");
        }

        public void UsarVehiculo()
        {
            if (EsPropietario == true)
            {
                Console.WriteLine($"Estoy usando el vehiculo {Vehiculo.Marca} {Vehiculo.Modelo}");
            }
            else
            {
                Console.WriteLine("No eres propietario de un vehiculo!");
            }
        }
        
    }
}