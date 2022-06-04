using System;

namespace punto1
{
    class Program
    {
        static void Main(string[] args)
        {

            int bandera = Convert.ToInt32(0);
           
        
            Console.WriteLine("Escriba los valores de x e y " );
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            // empleado primerEmpleado = new empleado();
            calculadora calculadora1 = new calculadora();

            while (bandera == 0 )
            {
                Console.WriteLine("Ingrese una operacion");
                string operacion = Console.ReadLine();
                calculadora1.ecandenamientoOperaciones(operacion,calculadora1,x,y);

                Console.WriteLine("Desea continuar? 0=si , 1=no");
                bandera = Convert.ToInt32(Console.ReadLine());
            }

             Console.WriteLine("Fin");


        }
        

    }
}

