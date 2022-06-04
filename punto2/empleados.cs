using System;

namespace punto2
{
    public class empleado
    {
        public string Nombre = "dasdasd";

        public string Apellido = "ddasdasdad";
        public DateTime fechaDeNacimiento;

       /* public empleado(){

            Nombre = "NOMBRE";
            Apellido = "APELLIDO";
            fechaDeNacimiento = new DateTime (1992,09,30);
        }*/

        public char estadoCivil;
        public double sueldoBasico;

        public cargos cargoEmpleado;

        public int Edad(DateTime fechanac)
        {
            return DateTime.Now.Year - fechanac.Year;
        }

        public int antiguedad()
        {
            Console.WriteLine("Ingrese la fecha de inicio en la empresa");
            DateTime fechaInicio = Convert.ToDateTime(Console.ReadLine());
            return DateTime.Now.Year - fechaInicio.Year;
        }

        public int jubilacion(int edad, char genero)
        {
            if (genero == 'M')
            {
                return 65 -edad;
            }else
            {
                return 60 - edad;
            }
        }

        public double calculoSalario(double sueldoBasico, int antiguedad, char estadoCivil, cargos cargo )
        {

            double Salario;
            double adicional =0;

            if (antiguedad < 20)
            {
                adicional = sueldoBasico*0.01;
            }else
            {
                adicional = sueldoBasico*0.25;
            }

            if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
            {
                adicional = 0.5 * sueldoBasico;
            }

            if (estadoCivil == 'C')
            {
                adicional = adicional + 1500;
            }

            Salario = sueldoBasico + adicional;

            return Salario;

        }    

        public void cargar(empleado unEmpleado)
        {
            Console.WriteLine("Escriba apellido:");
            unEmpleado.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba nombre: ");
            unEmpleado.Nombre = Console.ReadLine();
            Console.WriteLine("Escriba estaado civil(S= soltero/a, C=casado/a, Vviudo/a=): ");
            unEmpleado.estadoCivil = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Escriba fecha de nac: ");
            unEmpleado.fechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Escriba sueldo basico: ");
            unEmpleado.sueldoBasico = Convert.ToDouble(Console.ReadLine());
            this.cargoEmpleado = cargos.Ingeniero;

        }

        public void mostrar(empleado primerEmpleado)
        {
            Console.WriteLine("Datos: ");
            Console.WriteLine("Apellido y nombre : " + primerEmpleado.Apellido + " - " + primerEmpleado.Nombre);
            Console.WriteLine("Fecha de nacimiento " + primerEmpleado.fechaDeNacimiento + " | Estado civil: "+ primerEmpleado.estadoCivil);
            Console.WriteLine("Edad : " + primerEmpleado.Edad(primerEmpleado.fechaDeNacimiento));
            Console.WriteLine("Antiguedad: " + primerEmpleado.antiguedad());
            Console.WriteLine("Años faltantes para la jubilacion: " + primerEmpleado.jubilacion( primerEmpleado.Edad(primerEmpleado.fechaDeNacimiento) , 'M' ) );
            Console.WriteLine("Sueldo: " + primerEmpleado.calculoSalario(primerEmpleado.sueldoBasico,primerEmpleado.antiguedad(),primerEmpleado.estadoCivil,primerEmpleado.cargoEmpleado));
            
        }
    
    }

        public enum cargos
        { 
            Auxiliar =0, Administrativo=1, Ingeniero=2, Especialista=3, Investigador=4
        }

}



/*

a. Calcular lo siguiente:
i. La antigüedad del empleado en la empresa.
ii. La edad del empleado,
iii. La cantidad de años que le falta al empleado para poder
jubilarse (para la mujer la edad es 60 años, para el varón es 65
años).


b. Calcular el salario,

Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
Adicional. Para ello el Adicional contempla la antigüedad en años, el
cargo y si es casado:
i) 1 % del sueldo básico por cada año de antigüedad hasta los
20 años, a partir de este, el porcentaje se fija en 25%.
ii) Si el cargo es Ingeniero o Especialista, el Adicional se
incrementa en un 50%.
iii) Si es casado al Adicional se le aumenta $15000.

*/