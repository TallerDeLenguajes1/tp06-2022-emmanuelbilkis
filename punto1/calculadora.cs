using System;

namespace punto1
{
    class calculadora
    {
        double x;
        double y;

        public double suma(double x, double y)
        {
            return x + y ;
        }

        public double resta(double x, double y)
        {
            return x - y ;
        }

        public double producto(double x, double y)
        {
            return x * y ;
        }

        public double cociente(double x, double y)
        {
            return x / y ;
        }

        public void limpiar(double x , double y)
        {
            Console.WriteLine("Elija nuevos valores de x e y ");
            x =Convert.ToDouble (Console.ReadLine());
            y =Convert.ToDouble (Console.ReadLine());
        }

        public void ecandenamientoOperaciones (string operacion, calculadora z,double x,double y)
        {
            

            if (operacion == "suma")
            {
                x = z.suma(x,y);
                y = z.suma(x,y);

                Console.WriteLine("valor de x = "+ x + "| Valor de  y " + y );
            }

            if (operacion == "resta")
            {
                x = z.resta(x,y);
                y = z.resta(x,y);
                Console.WriteLine("valor de x = "+ x + "| Valor de  y " + y );
            }

            if (operacion == "producto")
            {
                x = z.producto(x,y);
                y = z.producto(x,y);
                Console.WriteLine("valor de x = "+ x + "| Valor de  y " + y );
            }

            if (operacion == "cociente")
            {
                x = z.cociente(x,y);
                y = z.cociente(x,y);
                Console.WriteLine("valor de x = "+ x + "| Valor de  y " + y );
            }

            if (operacion == "limpiar")
            {
                 z.limpiar(x,y);
                 Console.WriteLine("valor de x = "+ x + "| Valor de  y " + y );
            }

        }
    }
}

