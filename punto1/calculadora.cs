using System;

namespace punto1
{
    public class calculadora
    {
        float suma(float num1, float num2)
        {
            return num1 + num2;
        }

        float resta(float num1, float num2)
        {
            return num1 - num2;
        }

        float producto(float num1, float num2)
        {
            return num1 * num2;
        }

        float cociente(float num1, float num2)
        {
            return num1 / num2;
        }

        void limpiar()
        {
            Console.ReadKey();
        }

        void calcula(float num1,float num2)
        {

                var seed = Environment.TickCount;
                var random = new Random(seed);
                int aleatorio = random.Next(1, 6);

                while (aleatorio != 6)
                {
                    switch (aleatorio)
                    {
                        case 1 : suma(num1,num2);
                                break;

                        case 2 : resta(num1,num2);
                                break;
                        case 3 : producto(num1,num2);
                                break;
                        case 4 : cociente(num1,num2);
                                break;
                        case 5 : limpiar();
                                break;
                    }

                    aleatorio = random.Next(1, 6);
                }


    }    }

}
