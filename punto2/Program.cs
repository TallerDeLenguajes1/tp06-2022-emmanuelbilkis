using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args )
        {
            
            empleado primerEmpleado = new empleado();
            empleado segundoEmpleado = new empleado();
            empleado terceroEmpleado = new empleado();  // creo en memoria un nuevo empleado llamado primerEmpleado
            
            primerEmpleado.cargar(primerEmpleado);
            segundoEmpleado.cargar(segundoEmpleado);
            terceroEmpleado.cargar(terceroEmpleado);

             double sueldoPrimero = primerEmpleado.calculoSalario(primerEmpleado.sueldoBasico,primerEmpleado.antiguedad(),primerEmpleado.estadoCivil,primerEmpleado.cargoEmpleado);
             double sueldoSegundo = segundoEmpleado.calculoSalario(segundoEmpleado.sueldoBasico,segundoEmpleado.antiguedad(),segundoEmpleado.estadoCivil,segundoEmpleado.cargoEmpleado);
             double sueldotercero = terceroEmpleado.calculoSalario(terceroEmpleado.sueldoBasico,terceroEmpleado.antiguedad(),terceroEmpleado.estadoCivil,terceroEmpleado.cargoEmpleado);

            double sumaSueldos = sueldoPrimero + sueldoSegundo + sueldotercero;

            if (primerEmpleado.antiguedad() > segundoEmpleado.antiguedad() && primerEmpleado.antiguedad()>terceroEmpleado.antiguedad())
            {
                primerEmpleado.mostrar(primerEmpleado);
            }else
            {
                if (primerEmpleado.antiguedad() < segundoEmpleado.antiguedad() && segundoEmpleado.antiguedad()>terceroEmpleado.antiguedad())
                {
                    segundoEmpleado.mostrar(segundoEmpleado);
                }else
                {
                    terceroEmpleado.mostrar(terceroEmpleado);
                }
            }

            Console.WriteLine("El monto total que se paga es : " + sumaSueldos);


        }
    }

}



