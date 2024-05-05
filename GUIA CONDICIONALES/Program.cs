using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_CONDICIONALES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GUIA CONDICIONALES

            // PUNTO NUMERO UNO, EDAD PARA CONDICIR


            int edad = 18;

            Console.WriteLine(" ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine(" tiene edad para obtener licencia ");
            }
            else
            {
                Console.WriteLine(" no tiene edad para obtener la licencia");
            }

            //PUNTO DOS, CONTROL DE ACCESO

            string nombre;
            int edad1;  
            Console.WriteLine(" ingrese su nombre"); 
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ingrese su edad");
            edad1 = Convert.ToInt32(Console.ReadLine());

            if (edad1 > 18)
            {
                Console.WriteLine(" tiene edad para ingresar");
            }
            else

            {
                Console.WriteLine("no tiene edad para ingresar");
            }

            //PUNTO TRES, DESCUENTO DE EDAD EN CINE

            int EDAD;
            Console.WriteLine("ingrese su edad para saber si tienes derecho a un descuento");
            EDAD = Convert.ToInt32(Console.ReadLine());
            if(edad > 18) 
            {
                Console.WriteLine(" tiene la edad sufiente para el descuento");
            }
            else
            {
                Console.WriteLine(" no tiene la edad sufiente para el descuento");
            }

            //PUNTO CUATRO, CALIFICACION APROBATORIA
            
            Console.WriteLine("ingrese su calificacion");
            double cal = Convert.ToDouble(Console.ReadLine());
            if (cal > 4)
            {
                Console.WriteLine(" aprobaste la materia");
            }
            else
            {
                Console.WriteLine("desaprobaste la materia");
            }

            //PUNTO CINCO, VERIFICACION DE CONTRASEÑA

            Console.WriteLine(" ingrese su contaseña para verificar si es correcta");
            string contra = Convert.ToString(Console.ReadLine());
            if (contra == "colegioidra")
            {
                Console.WriteLine(" su contraseña es correcta");
            }
            else
            {
                Console.WriteLine(" su contaseña es incorrecta");
            }

            //PUNTO SEIS, COMPROBACION DE EDAD PARA REDES SOCIALES

            Console.WriteLine("ingrese su edad");
            byte edad2 = Convert.ToByte(Console.ReadLine());
            if (edad2 > 18)
            {
                Console.WriteLine("tienes la edad suficiente");
            }
            else
            {
                Console.WriteLine("no tienes edad sufiente, lo siento ");
            }

            //PUNTO SIETE, CALCULO DE IMPUESTOS

            Console.WriteLine("ingresa tu salario");
            double salario = Convert.ToDouble(Console.ReadLine());
            if (salario > 500.000) 
            {
                Console.WriteLine(" debe pagar impuestos ");
            }
            else 
            {
                Console.WriteLine(" no debe pagar impuestos");
            }

            //PUNTO OCHO, CONTROL DE ACCESO A UN BAR
            Console.WriteLine(" para el acceso al bar necesito primero ingrese su nombre");
            string nombre1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ingrese su edad");
            int edad3 = Convert.ToInt32(Console.ReadLine());
            if (edad3 > 18)
            { 
                 Console.WriteLine(" usted es mayor de edad " + nombre1 + " bienvenid@ ");
            }
            else 
            {
                Console.WriteLine(" acceso denegado es menor de edad");
            }

            //PUNTO NUEVE, VERIFICACION DE ASISTENCIA A CLASE

            Console.WriteLine(" ingresa el numero de asistecia que tuviste en las clases");
            int asist = Convert.ToInt32(Console.ReadLine());
            if (asist > 10)
            {
                Console.WriteLine(" su numero de asistencia es superior al minimo felicidades");
            }
            else 
            {
               Console.WriteLine(" no supera el numero minimo de asistencia");
            }

            //PUNTO DIEZ, VALIDACION DE NUMERO DE TELEFONO

            
            Console.WriteLine(" ingrese su telefono para saber si es valido");
            string numtel = Convert.ToString(Console.ReadLine());
            if ( numtel == "2235586654")
            {
                Console.WriteLine(" su numero es valido");
            }
            else 
            {
                Console.WriteLine(" su numero es invalido");
            }

            //PUNTO ONCE, CALCULO DE DESCUENTO EN TIENDA

            //los montos superiores de 500 tienen un descuento del 50%
            Console.WriteLine(" ingresa el monto de tu compra");
            double monto = Convert.ToDouble(Console.ReadLine());
            if( monto > 500)
            {
                Console.WriteLine("tiene un descuento del 50%");
            }
            else
            {
                Console.WriteLine(" no tiene ningun descuento");
            }

            //PUNTO DOCE, VERIFICACION DE DISPONIBILIDAD DE PRODUCTO
            //cantidad maxima de productos en inventario = 10 
            Console.WriteLine(" ingresa la cantidad de un producto para ver si esta en el inventario ");
            int cantprod = Convert.ToInt32(Console.ReadLine());
            if (cantprod < 10)
            {
                Console.WriteLine(" hay disponible esa cantidad en el inventario ");
            }
            else
            {
                Console.WriteLine(" no hay esa cantidad disponible en el inventario"); ;
            }

            //PUNTO TRECE, APROBACION DE CREDITO
            // puntaje minimo para acceder al prestamo 700
            Console.WriteLine(" ingrese su puntaje ");
            int puntaje = Convert.ToInt32(Console.ReadLine());
            if (puntaje >= 700)
            {
                Console.WriteLine(" posee el puntaje necesario para acceder al prestamo");
            }
            else
            {
                Console.WriteLine(" no posee el puntaje necesario para acceder al prestamo ");
            }

            //PUNTO CATORCE, VALIDACION DE CORREO 

            Console.WriteLine(" ingrese su correo electronico");
            string correo = Convert.ToString(Console.ReadLine());
            if (correo == "briiancourel@gmail.com") 
            {
               Console.WriteLine(" su correo electronico tiene un formato valido");
            }
            else 
            {
                Console.WriteLine(" correo electronico invalido ");
            }

            //PUNTO QUINCE, DISPONIBILIDAD DE ASIENTOS 
            // cantidad de asientos disponibles 10
            Console.WriteLine(" indique la cantidad de asientos que desea reservar");
            int cantasient = Convert.ToInt32(Console.ReadLine());
            if (cantasient < 10)
            {
                Console.WriteLine(" hay cantidad de asientos disponibles para realizar esa reserva");
            }
            else
            {
                Console.WriteLine(" no hay cantidad de asientos disponibles para realizar esa reserva");
            }











        }
    }
}
