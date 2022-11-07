using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta_waza

{
    class Program
    {
        static void Main(string[] args)
        {

            string nameUser, lastName, contactNumber, city, FBProfile, email;
            string user, password, passwordConfirm, codeAccess;
            byte age = 0;

            Console.WriteLine("Ingresa tu nombre");
            nameUser = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido");
            lastName = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            age = Convert.ToByte(Console.ReadLine());

            if (age >= 18) {

                Console.WriteLine("Estas invitado a la fiesta, tu codigo de acceso es");

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();

                Console.WriteLine("Necesitamos tus datos");

                Console.WriteLine("Ingresa tu numero de contacto");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingresa la ciudad en donde vives");
                city = Console.ReadLine();
                Console.WriteLine("Ingresa tu perfil de Facebook");
                FBProfile = (Console.ReadLine());
                Console.WriteLine("Ingresa tu email");
                email = (Console.ReadLine());


                Console.WriteLine("Ingresa tu nombre de usuario");
                user = (Console.ReadLine());
                Console.WriteLine("Ingresa tu contraseña");
                password = (Console.ReadLine());
                Console.WriteLine("Vuelve a ingresar la contraseña");
                passwordConfirm = (Console.ReadLine());
                Console.WriteLine("Ingresa tu codigo de acceso");
                codeAccess = (Console.ReadLine());

                if(password == passwordConfirm)
                {

                    Random rnd = new Random();
                   codeAccess = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Codigo de acceso: {0}");


                }
                


            }

            else
            {

                Console.WriteLine("Usted no puede entrar a la fiesta porque no es mayor de edad");

            }






            Console.ReadKey();


        }
    }
}
