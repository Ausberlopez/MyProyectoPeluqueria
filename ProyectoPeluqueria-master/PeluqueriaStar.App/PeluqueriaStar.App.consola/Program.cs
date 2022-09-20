using System;
using PeluqueriaStar.App.Dominio;
using PeluqueriaStar.App.Persistencia;
using System.Collections.Generic;

namespace PeluqueriaStar.App.consola
{
    class ProgramAdministrador
    {
        //creamos un campo o atributo de clase llamado _repocliente
        private static IRepositorioAdministrador _repoadministrador = new RepositorioAdministrador(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            bool control = true;
            while (true)
            {
                System.Console.WriteLine("### Bienvenido al programa probar peluqueria###");
                System.Console.WriteLine("         ### CRUD  Administrador  ####                   ");
                System.Console.WriteLine();
                System.Console.WriteLine("1. Adicionar Administrador ");
                System.Console.WriteLine("2. Borrar Administrador ");
                System.Console.WriteLine("3. buscar  Administrador ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AddAdmistrador();
                        break;
                    case 2:
                        System.Console.WriteLine("metodo para borrar Administrador");
                        BorrarAdministrador(7);
                        break;
                    case 3:
                        System.Console.WriteLine("metodo buscar  Administrador ");
                        buscarAdministrador(7);  
                        break;

                    case 4:
                        
                        System.Console.WriteLine("gracias por usar la aplicacion peluqueria");
                        control = false;
                        break;
                    default:
                        System.Console.WriteLine("opcion Incorecta, digite nuevamente");
                        break;
                }


            }


        }

        private static void AddAdmistrador()
        {
            var administrador = new Administrador
            {
                Nombre = "Juan",
                Apellidos = "Valdez",
                
                EstadoSalud = true,
                Celular = "400000",
                
                
                
                
            };
            _repoadministrador.AddAdministrador(administrador);
            System.Console.WriteLine($"El Administrador {administrador.Nombre} {administrador.Apellidos} ha sido Agregado con exito");

        }

        private static void BorrarAdministrador(int idAdministrador)
        {
            _repoadministrador.DeleteAdministrador(idAdministrador);
            System.Console.WriteLine("Administrador elininado con exito");

        }


        private static void buscarAdministrador(int idAdministrador){
            var administrador =  _repoadministrador.GetAdministrador(idAdministrador);
            System.Console.WriteLine("Administrador encontrado con exito" + administrador.Id + administrador.Nombre);

        }


    }
}