using System.Security.Cryptography.X509Certificates;

namespace EjerciciosSesion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
        }

                
        public static void Ejercicio1()
        {
            int precio, descuento = 10, codCurso;
            
            Console.WriteLine("A continuación vamos cargar sus datos.\nNombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Email: ");
            string mail = Console.ReadLine();
            Console.WriteLine("Elija un curso, indicando el número:\n1-C# Precio del curso 50$\n2-Java Precio del curso 50$\n3-JavaScript Precio del curso 60$\n4-PHP Precio del curso 40$");
            codCurso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Poseé cupón de descuento? (s/n)");
            bool cupon = Console.ReadLine() == "s";

            if (!cupon) 
            {
                if (codCurso == 1 || codCurso == 2)
                {
                    precio = 50;
                    Console.WriteLine("El precio final del curso es de " + precio + "$");
                }
                else if (codCurso == 3)
                {
                    precio = 60;
                    Console.WriteLine("El precio final del curso es de " + precio + "$");
                }
                else if (codCurso == 4)
                {
                    precio = 40;
                    Console.WriteLine("El precio final del curso es de " + precio + "$");
                }
                else { Console.WriteLine("Código erroneo!"); }
            }
            else if (cupon)
            {
                if (codCurso == 1 || codCurso == 2)
                {
                    precio = 50;
                    precio = precio - (precio * descuento /100);
                    Console.WriteLine("El precio final del curso es de " + precio + "$");
                }
                else if (codCurso == 3)
                {
                    precio = 60;
                    precio = precio - (precio * descuento / 100);
                    Console.WriteLine("El precio final del curso es de " + precio + "$");
                }
                else if (codCurso == 4)
                {
                    precio = 40;
                    precio = precio - (precio * descuento / 100);
                    Console.WriteLine("El precio final del curso es de " + precio + "$");
                }
                else { Console.WriteLine("Código erroneo!"); }


            }

            

        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Elija el lenguaje de programación con el que desea continuar sus estudios, mediante el número asignado:\n1-C#\n2-Java\n3-JavaScript\n4-PHP");
            string codigo = Console.ReadLine();
            int precio;

            switch (codigo)
            {
                case "1":
                    Console.WriteLine("Usted ha seleccionado C#, felicitaciones! El precio de su curso es de 50$");
                    precio = 50;
                    break;
                case "2":
                    Console.WriteLine("Usted ha seleccionado Java, felicitaciones! El precio de su curso es de 50$");
                    precio = 50;
                    break;
                case "3":
                    Console.WriteLine("Usted ha seleccionado JavaScript, felicitaciones! El precio de su curso es de 60$");
                    precio = 60;
                    break;
                case "4":
                    Console.WriteLine("Usted ha seleccionado PHP, felicitaciones! El precio de su curso es de 45$");
                    precio = 45;
                    break;
                default : Console.WriteLine("La carga ha sido incorrecta.");
                        break;
            }

            
        }
    }
}