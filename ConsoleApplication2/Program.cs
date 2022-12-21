using System;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
     /*       Console.WriteLine("Hola mundo!!!!");
            Ejercicios prueba = new Ejercicios();
            prueba.ejercicio2();*/
  //   Persona persona1 = new Persona();
  //   persona1.nombreYApellido();

 /*       Auto automovil1 = new Auto();
        automovil1.Marca = "Toyota";
        automovil1.Modelo = "Corolla";
        automovil1.color = "Gris";
        automovil1.mostrarInfo();*/
  /*      Mascota mascota1 = new Mascota();
        Console.WriteLine(mascota1.energia);
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();
        mascota1.Correr();


        Console.WriteLine(mascota1.energia);*/
/*  Smartphone celular = new Smartphone("motorola","moto g30", true, false,100);
 
  celular.mostrarMarca();
  celular.mostrarModelo(); */
    /*        Libro libro1 = new Libro();
            Console.WriteLine("Pidiendo autor sin asignarlo");
            libro1.getAuthor();
            Console.WriteLine("Asignando autor");
            libro1.setAuthor("Lucas Zapata");
            Console.WriteLine(libro1.getAuthor());*/

    Auto auto1 = new Auto();
    auto1.Marca = "Ford";
    auto1.Modelo = "F150";
    auto1.Color = "Blanco";
    auto1.Encendido = true;
    Console.WriteLine( auto1.Modelo);
    
    Console.WriteLine("Pasando a persona------------------------------------- ");
    
    Persona Nico = new Persona();
    Nico.setFechaDeNacimiento(5, 01, 2006);
    Nico.setVehicle(auto1);
    Nico.setNombre("Nico");
    Nico.setApellido("Estruciat");
    Nico.setLicenciaDeconducir(true);
    auto1.setPropietario(Nico);
    
 //   Console.WriteLine(Nico.FechaDeNacimiento);
// DateTime nacimiento = new DateTime(2006, 01, 25);
    Nico.calcularEdad();
    
    Nico.UsarVehiculo();
    

        }
    }
}